using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUIEx;

namespace MinecraftBoot.Type;

public struct GrowlType
{
    public string Info = "";
    public string Success = "";
    public string Warning = "";

    public GrowlType() { }
}

public struct GameVersionShowType
{
    public string VersionCode;
    public string Name;
    public string ReleaseTime;
    public string Icon;
}
