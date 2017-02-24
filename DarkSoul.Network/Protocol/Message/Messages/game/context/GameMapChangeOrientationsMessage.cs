

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
    public class GameMapChangeOrientationsMessage : NetworkMessage
    {
        public override ushort Id => 6155;
        
        
        public IEnumerable<Types.ActorOrientation> orientations;
        
        public GameMapChangeOrientationsMessage()
        {
        }
        
        public GameMapChangeOrientationsMessage(IEnumerable<Types.ActorOrientation> orientations)
        {
            this.orientations = orientations;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)orientations.Count());
            foreach (var entry in orientations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            orientations = new Types.ActorOrientation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (orientations as Types.ActorOrientation[])[i] = new Types.ActorOrientation();
                 (orientations as Types.ActorOrientation[])[i].Deserialize(reader);
            }
        }
        
    }
    
}