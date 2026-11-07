using System.Diagnostics;
using System.IO.Compression;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using Octokit;
using IniParser;
using IniParser.Model;

namespace RecFlareInstaller_GUI;

public partial class InstallationPage : UserControl
{
    public event Action? InstallationCompleted;
    public InstallationPage()
    {
        InitializeComponent();
        StartInstallation();
    }

    private async void StartInstallation()
    {
        const string clientHash = "33f6645d9cd61498748497a826c7a7ff47f0f214e04437454143994228580257";
        const string downloadUrl =  "https://s3.g.megas4.com/2koayuyiwxv4groxzwdbbxg43cwustavrkvfb/recflare/2026/client.zip"; // community mirror
        const string downloadPath = @"C:\Games\RecFlare\";
        string clientZip = Path.Combine(downloadPath, "client.zip");
        string patchzip = Path.Combine(downloadPath, "patch.zip");
        string latestPatch = "";
        const string patchHash = "2919e2de4ddeec18e26c9a37280afdfac92450cb99fa6f72e7a9f52cef31d975";
        string patchConfig = Path.Combine(downloadPath, "2026Patch.ini");
        const string apiHost = "https://ns.recflare.net";
        const string serverDomain = "recflare.net";
        const string voiceKeyXml =
            "<RSAKeyValue><Modulus>nu7lFZqLX+siEI2U8/JihESmm4JrBVLsCHdS8NoAipq2NdJqVouOHQoxtFfJTG6u/+kx4wocnsQ1Ydk5AISyy0GQeweQOTLKlkXsR6on/DL7LqKWxWp3M+MG4kkyZROWh2OELCAudC902p8VSaXmEyH8i1Sid9YiKe0FaNsyzWE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        var githubClient = new GitHubClient(new Octokit.ProductHeaderValue("RecFlareInstaller"));

        Release latest = await githubClient.Repository.Release.GetLatest("recflare", "patch-2026");
        foreach (var release in latest.Assets)
        {
            if (release.Name.StartsWith("2026Patch"))
            {
                latestPatch = release.BrowserDownloadUrl;
                break;
            }
        }
        UpdateLog("Making download directory");
        Directory.CreateDirectory(downloadPath);
        UpdateLog("Downloading from community mirror (this will take some time!)");
        await DownloadFromUrl(downloadUrl, clientZip);
        UpdateLog("Checking client integrity..");
        if (GetSha256Hash(clientZip) != clientHash)
        {
            UpdateLog("Client integrity check failed! \nPlease re-run the launcher.");
            File.Delete(clientZip);
            Environment.Exit(0);
        }
        UpdateLog("Extracting client archive... (again, can take some time.)");
        await ExtractZip(clientZip, downloadPath);
        UpdateLog("Deleting client archive...");
        File.Delete(clientZip);
        UpdateLog("Adding Defender Exclusion..");
        AddDefenderExclusion(downloadPath);
        UpdateLog("Downloading patch archive..");
        await DownloadFromUrl(latestPatch, patchzip);
        UpdateLog("Checking patch integrity..");
        if (GetSha256Hash(patchzip) != patchHash)
        {
            UpdateLog("Patch integrity check failed! \nPlease re-run the launcher.");
            File.Delete(patchzip);
            Environment.Exit(0);
        }
        UpdateLog("Extracting patch archive...");
        await ExtractZip(patchzip, downloadPath);
        UpdateLog("Deleting patch archive...");
        File.Delete(patchzip);
        UpdateLog("Fixing patch config..");

        FileIniDataParser parser = new FileIniDataParser();
        IniData data = parser.ReadFile(patchConfig);

        // modify the values
        data["config"]["ApiHost"] = apiHost;
        data["config"]["ServerDomain"] = serverDomain;
        data["config"]["VoiceKeyXml"] = voiceKeyXml;
        parser.WriteFile(patchConfig, data);

        UpdateLog("Done!");
        InstallationCompleted?.Invoke();
        
        
    }
    
    
    
    
    
    private void UpdateLog(string message)
    {
        richTextBox1.AppendText(message + Environment.NewLine);

        richTextBox1.SelectionStart = richTextBox1.TextLength;
        richTextBox1.ScrollToCaret();
    }
    
    
    private async Task ExtractZip(string zipPath, string extractPath)
    {
        await Task.Run(() =>
        {
            ZipFile.ExtractToDirectory(
                zipPath,
                extractPath,
                overwriteFiles: true
            );
        });
    }
    
    
    static bool AddDefenderExclusion(string path)
    {
        
        try
        {
            string command = $"Add-MpPreference -ExclusionPath {path}";

            var ps1 = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-NoProfile -WindowStyle Hidden -Command \"{command}\"",
                Verb = "runas",
                UseShellExecute = true,
                CreateNoWindow = true
            };
            using (var process = Process.Start(ps1))
            {
                process.WaitForExit();
                return process.ExitCode == 0;
            }
        }
        catch (System.ComponentModel.Win32Exception ex) when (ex.NativeErrorCode == 1223)
        {
            return false;
        }
    }
    
     async Task DownloadFromUrl(string url, string path)
        {
            HttpClient client = new HttpClient();
            using var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            long total = response.Content.Headers.ContentLength ?? -1;

            using var remote = await response.Content.ReadAsStreamAsync();
            using var file = new FileStream(path, System.IO.FileMode.Create, FileAccess.Write, FileShare.None, 1024 * 1024, FileOptions.Asynchronous);

            byte[] buffer = new byte[1024 * 1024];
            long done = 0;
            int read;
            int lastPercent = -1;

            while ((read = await remote.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                await file.WriteAsync(buffer, 0, read);
                done += read;

                if (total > 0)
                {
                    int percent = (int)(done * 100 / total);
                    if (percent != lastPercent)
                    {
                        UpdateLog($"\rDownloading... {percent}%");
                        lastPercent = percent;
                    }
                }
            }

            UpdateLog("");
        }

    static string GetSha256Hash(string filePath)
    {
        using var sha256 = SHA256.Create();
        using var stream = File.OpenRead(filePath);
        byte[] hashBytes = sha256.ComputeHash(stream);
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
    }
    
    
}