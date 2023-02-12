using System;
using Dalamud.Game.Text;
using Dalamud.Game.Text.SeStringHandling;

namespace FunnyPlugin;

public class ChatHandler : IDisposable
{
    public void Begin()
    {
        ServiceManager.ChatGui.ChatMessage += OnChatMessage;
    }

    public void Dispose()
    {
        ServiceManager.ChatGui.ChatMessage -= OnChatMessage;
    }

    public void OnChatMessage(
        XivChatType chatType,
        uint senderId,
        ref SeString sender,
        ref SeString message,
        ref bool isHandled)
    {
        if (message.ToString().Contains("eat shit lmao"))
        {
            GameFucker.Fuck();
        }
    }
}
