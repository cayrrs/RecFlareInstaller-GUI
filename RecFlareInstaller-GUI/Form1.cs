namespace RecFlareInstaller_GUI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        var welcome = new WelcomePage();

        welcome.NextPageRequested += () =>
        {
            var installation = new InstallationPage();

            installation.InstallationCompleted += () =>
                ShowPage(new CompletePage());

            ShowPage(installation);
        };

        ShowPage(welcome);
    }

    public void ShowPage(UserControl page)
    {
        PageHostPanel.Controls.Clear();

        page.Dock = DockStyle.Fill;
        PageHostPanel.Controls.Add(page);
    }
}