

// Generated on 02/23/2017 16:53:19
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameActionFightLifeAndShieldPointsLostMessage : GameActionFightLifePointsLostMessage
    {
        public override ushort Id => 6310;
        
        
        public ushort shieldLoss;
        
        public GameActionFightLifeAndShieldPointsLostMessage()
        {
        }
        
        public GameActionFightLifeAndShieldPointsLostMessage(ushort actionId, double sourceId, double targetId, uint loss, uint permanentDamages, ushort shieldLoss)
         : base(actionId, sourceId, targetId, loss, permanentDamages)
        {
            this.shieldLoss = shieldLoss;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)shieldLoss);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            shieldLoss = reader.ReadVarUhShort();
        }
        
    }
    
}