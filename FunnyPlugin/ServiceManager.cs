using Dalamud.Game;
using Dalamud.Game.ClientState;
using Dalamud.Game.Gui;
using Dalamud.IoC;

namespace FunnyPlugin;

public class ServiceManager
{
    [PluginService]
    public static Framework Framework { get; private set; } = null!;
    [PluginService]
    public static ChatGui ChatGui { get; private set; } = null!;

    [PluginService]
    public static ClientState ClientState { get; private set; } = null!;
}
