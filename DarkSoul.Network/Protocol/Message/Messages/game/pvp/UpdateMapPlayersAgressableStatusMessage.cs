

// Generated on 02/23/2017 16:54:02
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class UpdateMapPlayersAgressableStatusMessage : NetworkMessage
    {
        public override ushort Id => 6454;
        
        
        public IEnumerable<double> playerIds;
        public IEnumerable<sbyte> enable;
        
        public UpdateMapPlayersAgressableStatusMessage()
        {
        }
        
        public UpdateMapPlayersAgressableStatusMessage(IEnumerable<double> playerIds, IEnumerable<sbyte> enable)
        {
            this.playerIds = playerIds;
            this.enable = enable;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)playerIds.Count());
            foreach (var entry in playerIds)
            {
                 writer.WriteVarLong(entry);
            }
            writer.WriteShort((short)enable.Count());
            foreach (var entry in enable)
            {
                 writer.WriteSByte(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            playerIds = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (playerIds as double[])[i] = reader.ReadVarUhLong();
            }
            limit = reader.ReadUShort();
            enable = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (enable as sbyte[])[i] = reader.ReadSByte();
            }
        }
        
    }
    
}