using MinecraftBoot.Tools.DevToolWindowContent;
using WinUIEx;

namespace MinecraftBoot.Tools;
public class DevTool
{
    public static Window DevWindow { get; set; }
    public static void CreateDevWindow()
    {
        var window = new Window();
        DevWindow = window;
        window.AppWindow.TitleBar.ExtendsContentIntoTitleBar = true;
        window.AppWindow.TitleBar.ButtonBackgroundColor = Colors.Transparent;
        window.AppWindow.TitleBar.BackgroundColor = Colors.Transparent;

        if (window.Content is not Frame rootFrame)
        {
            window.Content = rootFrame = new Frame();
        }

        rootFrame.Navigate(typeof(DevToolContentPage));

        window.Activate();

        WindowManager.Get(window).IsMaximizable = false;
        WindowManager.Get(window).IsMinimizable = false;
        WindowManager.Get(window).IsResizable = false;
        // WindowManager.Get(window).IsTitleBarVisible = false;
        WindowManager.Get(window).IsAlwaysOnTop = true;
        WindowManager.Get(window).Height = 255;
        WindowManager.Get(window).Width = 220;
    }
    private void NavFrame_Navigated(object sender, NavigationEventArgs e) { }
}
