

// Generated on 02/23/2017 16:53:51
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TeleportBuddiesRequestedMessage : NetworkMessage
    {
        public override ushort Id => 6302;
        
        
        public ushort dungeonId;
        public double inviterId;
        public IEnumerable<double> invalidBuddiesIds;
        
        public TeleportBuddiesRequestedMessage()
        {
        }
        
        public TeleportBuddiesRequestedMessage(ushort dungeonId, double inviterId, IEnumerable<double> invalidBuddiesIds)
        {
            this.dungeonId = dungeonId;
            this.inviterId = inviterId;
            this.invalidBuddiesIds = invalidBuddiesIds;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)dungeonId);
            writer.WriteVarLong(inviterId);
            writer.WriteShort((short)invalidBuddiesIds.Count());
            foreach (var entry in invalidBuddiesIds)
            {
                 writer.WriteVarLong(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            dungeonId = reader.ReadVarUhShort();
            inviterId = reader.ReadVarUhLong();
            var limit = reader.ReadUShort();
            invalidBuddiesIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (invalidBuddiesIds as double[])[i] = reader.ReadVarUhLong();
            }
        }
        
    }
    
}