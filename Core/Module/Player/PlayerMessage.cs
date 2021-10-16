﻿using System.Threading.Tasks;
using Core.Module.SkillData;
using Core.NetworkPacket.ServerPacket;

namespace Core.Module.Player
{
    public sealed class PlayerMessage
    {
        private readonly PlayerInstance _playerInstance;
        public PlayerMessage(PlayerInstance playerInstance)
        {
            _playerInstance = playerInstance;
        }
        
        public async Task SendMessageToPlayerAsync(SkillDataModel skill, int skillId)
        {
            SystemMessage sm = new SystemMessage(SystemMessageId.UseS1);
            switch (skillId)
            {
                case 2005:
                    sm.AddItemName(728);
                    break;
                case 2003:
                    sm.AddItemName(726);
                    break;
                case 2166 when (skill.Level == 2):
                    sm.AddItemName(5592);
                    break;
                case 2166 when (skill.Level == 1):
                    sm.AddItemName(5591);
                    break;
                default:
                    sm.AddSkillName(skillId, skill.Level);
                    break;
            }
            await _playerInstance.SendPacketAsync(sm);
        }
    }
}