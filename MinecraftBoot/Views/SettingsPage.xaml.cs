using Microsoft.UI.Xaml.Media.Animation;
using Windows.Storage.AccessCache;
using Windows.Storage.Pickers;
using Windows.Storage;

namespace MinecraftBoot.Views;
public sealed partial class SettingsPage : Page
{
    public SettingsPage()
    {
        this.InitializeComponent();
    }

    private void OnSettingCard_Click(object sender, RoutedEventArgs e)
    {
        var item = sender as SettingsCard;
        if (item.Tag != null)
        {
            var pageType = Application.Current.GetType().Assembly.GetType($"MinecraftBoot.Views.{item.Tag}");

            if (pageType != null)
            {
                SlideNavigationTransitionInfo entranceNavigation = new SlideNavigationTransitionInfo();
                entranceNavigation.Effect = SlideNavigationTransitionEffect.FromRight;
                App.Current.JsonNavigationViewService.NavigateTo(pageType, item.Header, false, entranceNavigation);
            }
        }
    }
}

