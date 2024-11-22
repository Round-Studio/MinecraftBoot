using System.Diagnostics;
using MinecraftBoot.Tools;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MinecraftBoot.Views.UserControls;
public sealed partial class UserView : UserControl
{
    private bool IsDevMenuShow {  get; set; }
    public UserView()
    {
        this.InitializeComponent();
        IsDevMenuShow = Debugger.IsAttached;
    }

    private void SettingsMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
    {
        App.Current.JsonNavigationViewService.NavigateTo(typeof(SettingsPage));
    }

    private void UserMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
    {
        App.Current.JsonNavigationViewService.NavigateTo(typeof(UserInfoPage));
    }

    private void UserManagerMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
    {
        App.Current.JsonNavigationViewService.NavigateTo(typeof(UserInfoPage));
    }

    private void FocusTrackerMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
    {
        DevTool.CreateDevWindow();
    }

    private void ToggleMenuFlyoutItem_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.DebugSettings.IsTextPerformanceVisualizationEnabled = !(Application.Current.DebugSettings.IsTextPerformanceVisualizationEnabled);
    }
}
