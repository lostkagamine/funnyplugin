using System;
using System.Runtime.InteropServices;
using FFXIVClientStructs.FFXIV.Client.System.Framework;
using FFXIVClientStructs.FFXIV.Client.UI;

namespace FunnyPlugin;

public class GameFucker
{
    public static unsafe void Fuck()
    {
        Framework.Instance()->UIModule = (UIModule*)0;
    }
}
