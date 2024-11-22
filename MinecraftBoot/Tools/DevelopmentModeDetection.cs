using System.Diagnostics;

namespace MinecraftBoot.Tools;
internal class DevelopmentModeDetection
{
    public static bool IsDevelopmentMode()
    {
        return File.Exists(@"%HOMEPATH%\\MINECRAFTBOOT.DEVELOPMENTMODEFILE");
    }
    public static void EnableDevelopmentMode()
    {
        File.Create(@"%HOMEPATH%\\MINECRAFTBOOT.DEVELOPMENTMODEFILE");
    }
    public static void DisableDevelopmentMode()
    {
        File.Delete(@"%HOMEPATH%\\MINECRAFTBOOT.DEVELOPMENTMODEFILE");
    }
}
