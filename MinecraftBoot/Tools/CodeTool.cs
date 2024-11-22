using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinecraftBoot.Tools;
internal class CodeTool
{
    public static FontIcon GetFontIcon(string Glyph)
    {
        return new FontIcon { FontFamily = new Microsoft.UI.Xaml.Media.FontFamily("Segoe Fluent Icons"), Glyph = Glyph };
    }
}
