namespace RecFlareInstaller_GUI;

public partial class CompletePage : UserControl
{
    public CompletePage()
    {
        InitializeComponent();
    }

    private void InstallationPageQuit_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}