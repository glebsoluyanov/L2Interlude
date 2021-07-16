﻿using System;
using System.Threading.Tasks;
using Core.Controller;
using Core.Module.CharacterData.Template;
using Microsoft.Extensions.DependencyInjection;
using Network;

namespace Core.Module.CharacterData.Request
{
    public class CharacterCreate : PacketBase
    {
        private readonly GameServiceController _controller;
        private readonly IServiceProvider _serviceProvider;
        
        private readonly string _characterName;
        private readonly byte _race;
        private readonly byte _gender;
        private readonly byte _classId;
        private readonly byte _hairStyle;
        private readonly byte _hairColor;
        private readonly byte _face;
        
        public CharacterCreate(IServiceProvider serviceProvider, Packet packet, GameServiceController controller) : base(serviceProvider)
        {
            _controller = controller;
            _serviceProvider = serviceProvider;
          
            _characterName = packet.ReadString();
            _race = (byte)packet.ReadInt();
            _gender = (byte)packet.ReadInt();
            _classId = (byte)packet.ReadInt();
            packet.ReadInt(); //INT
            packet.ReadInt(); //STR
            packet.ReadInt(); //CON
            packet.ReadInt(); //MEN
            packet.ReadInt(); //DEX
            packet.ReadInt(); //WIT
            _hairStyle = (byte)packet.ReadInt();
            _hairColor = (byte)packet.ReadInt();
            _face = (byte)packet.ReadInt();
        }

        public override async Task Execute()
        {
            ITemplateHandler template = _serviceProvider.GetRequiredService<TemplateInit>().GetTemplateByClassId(_classId);
            
        }
   }
}