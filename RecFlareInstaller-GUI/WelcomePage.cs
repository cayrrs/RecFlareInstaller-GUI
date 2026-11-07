namespace RecFlareInstaller_GUI;

public partial class WelcomePage : UserControl
{
    public event Action? NextPageRequested;

    public WelcomePage()
    {
        InitializeComponent();
    }

    private void WelcomeNo_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }

    private void WelcomeYes_Click(object sender, EventArgs e)
    {
        NextPageRequested?.Invoke();
    }

}