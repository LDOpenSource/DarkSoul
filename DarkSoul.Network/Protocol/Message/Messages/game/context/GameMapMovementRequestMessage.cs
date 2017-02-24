

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameMapMovementRequestMessage : NetworkMessage
    {
        public override ushort Id => 950;
        
        
        public IEnumerable<short> keyMovements;
        public int mapId;
        
        public GameMapMovementRequestMessage()
        {
        }
        
        public GameMapMovementRequestMessage(IEnumerable<short> keyMovements, int mapId)
        {
            this.keyMovements = keyMovements;
            this.mapId = mapId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)keyMovements.Count());
            foreach (var entry in keyMovements)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteInt(mapId);
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            keyMovements = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 (keyMovements as short[])[i] = reader.ReadShort();
            }
            mapId = reader.ReadInt();
        }
        
    }
    
}