using MinecraftLaunch.Components.Authenticator;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MinecraftBoot.DialogContent;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class CreateNewAccount : Page
{
    private bool InfoBarIsShow {  get; set; }
    public CreateNewAccount()
    {
        this.InitializeComponent();
        InfoBarIsShow = false;
    }

    private void OfflineButton_Click(object sender, RoutedEventArgs e)
    {
        var text = offlineTextBox.Text;
        if (text == "")
        {
            InfoBarIsShow = true;
            return;
        }
        OfflineAuthenticator authenticator = new(offlineTextBox.Text);
        App.userProfile_OfflineAccount = authenticator.Authenticate();
        ((ContentDialog)Parent).Hide();
    }

    private void OtherButton_Click(object sender, RoutedEventArgs e)
    {
        ((ContentDialog)Parent).Hide();
    }

    private void MicrosoftButton_Click(object sender, RoutedEventArgs e)
    {
        ((ContentDialog)Parent).Hide();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        ((ContentDialog)Parent).Hide();
    }
}
