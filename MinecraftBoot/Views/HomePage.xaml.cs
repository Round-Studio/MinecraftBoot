using System.Collections.ObjectModel;
using System.Diagnostics;
using Microsoft.UI.Xaml.Media;
using MinecraftBoot.DialogContent;
using MinecraftBoot.Views;
using Windows.Foundation;
using Windows.UI;
using Microsoft.UI.Composition;
using MinecraftBoot.Tools;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MinecraftBoot.Views;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public partial class HomePage : Page
{
    private bool IsDevMod {  get; set; } = Debugger.IsAttached;

    public HomePage()
    {
        this.InitializeComponent();
    }

    private void gooeyButton_Invoked(object sender, GooeyButton.GooeyButtonInvokedEventArgs args)
    {
        Debug.WriteLine("Invoked");
    }

    private void gooeyButton_ItemInvoked(object sender, GooeyButton.GooeyButtonItemInvokedEventArgs args)
    {
        if (args.Item is Symbol symbol)
        {
            if (symbol == Symbol.Home)
            {
                HomeTeachingTip.IsOpen = true;
            }
            else if (symbol == Symbol.Play)
            {

            }
            else if (symbol == Symbol.Download)
            {
                App.Current.JsonNavigationViewService.NavigateTo(typeof(InstallPage));
            }
        }

        Debug.WriteLine(args.Item.ToString());
    }

    private async void HomeTeachingTip_ActionButtonClick(TeachingTip sender, object args)
    {
        sender.IsOpen = false;
        ContentDialog dialog = new ContentDialog();

        // XamlRoot must be set in the case of a ContentDialog running in a Desktop app
        dialog.XamlRoot = this.XamlRoot;
        dialog.Style = Application.Current.Resources["DefaultContentDialogStyle"] as Style;
        dialog.Title = "创建房间";
        dialog.BorderThickness = new Thickness(2);
        dialog.Content = new CreateNewRoom();

        var result = await dialog.ShowAsync();

    }

    private void DownloadSettingsCard_Click(object sender, RoutedEventArgs e)
    {
        App.Current.JsonNavigationViewService.NavigateTo(typeof(InstallPage));
    }

    private void CreateHomeSettingsCard_Click(object sender, RoutedEventArgs e)
    {
        HomeTeachingTip.IsOpen = true;
    }

    private async void NewAccountSettingsCard_Click(object sender, RoutedEventArgs e)
    {
        ContentDialog dialog = new ContentDialog();

        // XamlRoot must be set in the case of a ContentDialog running in a Desktop app
        dialog.XamlRoot = this.XamlRoot;
        dialog.Style = Application.Current.Resources["DefaultContentDialogStyle"] as Style;
        dialog.BorderThickness = new Thickness(2);
        dialog.Content = new CreateNewAccount();

        var result = await dialog.ShowAsync();
    }

    private void GoSettingsButton_Click(object sender, RoutedEventArgs e)
    {
        App.Current.JsonNavigationViewService.NavigateTo(typeof(SettingsPage));
    }
}
