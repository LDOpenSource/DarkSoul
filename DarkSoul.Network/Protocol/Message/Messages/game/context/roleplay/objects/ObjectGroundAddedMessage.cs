

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ObjectGroundAddedMessage : NetworkMessage
    {
        public override ushort Id => 3017;
        
        
        public ushort cellId;
        public ushort objectGID;
        
        public ObjectGroundAddedMessage()
        {
        }
        
        public ObjectGroundAddedMessage(ushort cellId, ushort objectGID)
        {
            this.cellId = cellId;
            this.objectGID = objectGID;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)cellId);
            writer.WriteVarShort((int)objectGID);
        }
        
        public override void Deserialize(IReader reader)
        {
            cellId = reader.ReadVarUhShort();
            objectGID = reader.ReadVarUhShort();
        }
        
    }
    
}