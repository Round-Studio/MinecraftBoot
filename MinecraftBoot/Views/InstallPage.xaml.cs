// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using System.Collections.ObjectModel;
using CmlLib.Core;

namespace MinecraftBoot.Views;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class InstallPage : Page
{
    public string LatestVersion { get; set; }
    private ObservableCollection<Type.GameVersionShowType> _games = new();
    private ObservableCollection<Type.GameVersionShowType> _releaseGames = new();
    private ObservableCollection<Type.GameVersionShowType> _snapshotGames = new();
    private ObservableCollection<Type.GameVersionShowType> _oldAlphaGames = new();
    private ObservableCollection<Type.GameVersionShowType> _oldBetaGames = new();
    public InstallPage()
    {
        this.InitializeComponent();
        LoadingState.IsOn = true;
        LoadVersions();
    }

    public static Visibility ReverseVisibility(Visibility vis) => vis switch
    {
        Visibility.Collapsed => Visibility.Visible,
        Visibility.Visible => Visibility.Collapsed,
        _ => throw new System.NotImplementedException(),

    };


    private async void LoadVersions()
    {
        var launcher = new MinecraftLauncher();
        var versions = await launcher.GetAllVersionsAsync();
        foreach (var version in versions)
        {
            var icon = "\uE9CE";
            var GoListTo = "all";
            if (version.Type == "snapshot")
            {
                icon = "\uF157";
            }
            else if (version.Type == "release")
            {
                icon = "\uF158";
            }
            else if (version.Type == "old_alpha")
            {
                icon = "\uE97E";
            }
            else if (version.Type == "old_beta")
            {
                icon = "\uEA24";
            }
            GoListTo = $"{version.Name}";

            _games.Add(new Type.GameVersionShowType()
            {
                Icon = icon,
                Name = version.Name,
                VersionCode = version.Type
            });

            if (GoListTo == "snapshot")
            {
                _snapshotGames.Add(new Type.GameVersionShowType()
                {
                    Icon = icon,
                    Name = version.Name,
                    VersionCode = version.Type
                });
            }
            else if (GoListTo == "release")
            {
                _releaseGames.Add(new Type.GameVersionShowType()
                {
                    Icon = icon,
                    Name = version.Name,
                    VersionCode = version.Type
                });
            }
            else if (GoListTo == "old_alpha")
            {
                _oldAlphaGames.Add(new Type.GameVersionShowType()
                {
                    Icon = icon,
                    Name = version.Name,
                    VersionCode = version.Type
                });
            }
            else if (GoListTo == "old_beta")
            {
                _oldBetaGames.Add(new Type.GameVersionShowType()
                {
                    Icon = icon,
                    Name = version.Name,
                    VersionCode = version.Type
                });
            }
        }
        LoadingState.IsOn = false;
    }
}
