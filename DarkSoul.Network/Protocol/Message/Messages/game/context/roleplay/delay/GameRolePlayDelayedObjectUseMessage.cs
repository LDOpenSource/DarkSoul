

// Generated on 02/23/2017 16:53:34
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayDelayedObjectUseMessage : GameRolePlayDelayedActionMessage
    {
        public override ushort Id => 0x1919;
        
        
        public ushort objectGID;
        
        public GameRolePlayDelayedObjectUseMessage()
        {
        }
        
        public GameRolePlayDelayedObjectUseMessage(double delayedCharacterId, sbyte delayTypeId, double delayEndTime, ushort objectGID)
         : base(delayedCharacterId, delayTypeId, delayEndTime)
        {
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)objectGID);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            objectGID = reader.ReadVarUhShort();
        }
        
    }
    
}