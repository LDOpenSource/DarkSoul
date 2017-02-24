

// Generated on 02/23/2017 16:53:57
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class UpdateMountBoostMessage : NetworkMessage
    {
        public override ushort Id => 6179;
        
        
        public int rideId;
        public IEnumerable<Types.UpdateMountBoost> boostToUpdateList;
        
        public UpdateMountBoostMessage()
        {
        }
        
        public UpdateMountBoostMessage(int rideId, IEnumerable<Types.UpdateMountBoost> boostToUpdateList)
        {
            this.rideId = rideId;
            this.boostToUpdateList = boostToUpdateList;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)rideId);
            writer.WriteShort((short)boostToUpdateList.Count());
            foreach (var entry in boostToUpdateList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            rideId = reader.ReadVarInt();
            var limit = reader.ReadUShort();
            boostToUpdateList = new Types.UpdateMountBoost[limit];
            for (int i = 0; i < limit; i++)
            {
                 (boostToUpdateList as Types.UpdateMountBoost[])[i] = ProtocolTypeManager.GetInstance<Types.UpdateMountBoost>(reader.ReadUShort());
                 (boostToUpdateList as Types.UpdateMountBoost[])[i].Deserialize(reader);
            }
        }
        
    }
    
}