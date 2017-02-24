

// Generated on 02/23/2017 16:53:18
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightDispellEffectMessage : GameActionFightDispellMessage
    {
        public override ushort Id => 6113;
        
        
        public int boostUID;
        
        public GameActionFightDispellEffectMessage()
        {
        }
        
        public GameActionFightDispellEffectMessage(ushort actionId, double sourceId, double targetId, int boostUID)
         : base(actionId, sourceId, targetId)
        {
            this.boostUID = boostUID;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(boostUID);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            boostUID = reader.ReadInt();
        }
        
    }
    
}