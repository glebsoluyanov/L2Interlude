﻿using Core.Attributes;
using Core.Enums;
using Core.Module.Player;
using Core.NetworkPacket.ServerPacket;
using System.Threading.Tasks;


//CLR: 4.0.30319.42000
//USER: GL
//DATE: 11.08.2024 0:26:02

namespace Core.Module.Handlers.Chat
{
    [ChatType(Type = ChatType.TRADE)]
    class ChatTrade : AbstractChatMessage
    {
        protected internal override async Task Chat(PlayerInstance player, ChatType chatType, string text, string paramsValue)
        {

            await player.SendPacketAsync(new Say2(player, chatType, text));
            foreach (PlayerInstance targetInstance in Initializer.WorldInit().GetVisiblePlayers(player))
            {

                await targetInstance.SendPacketAsync(new Say2(player, chatType, text));
            }
        }
    }
}
