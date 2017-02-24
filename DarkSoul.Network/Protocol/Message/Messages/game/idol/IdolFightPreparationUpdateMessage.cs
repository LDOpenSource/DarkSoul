

// Generated on 02/23/2017 16:53:50
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdolFightPreparationUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6586;
        
        
        public sbyte idolSource;
        public IEnumerable<Types.Idol> idols;
        
        public IdolFightPreparationUpdateMessage()
        {
        }
        
        public IdolFightPreparationUpdateMessage(sbyte idolSource, IEnumerable<Types.Idol> idols)
        {
            this.idolSource = idolSource;
            this.idols = idols;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(idolSource);
            writer.WriteShort((short)idols.Count());
            foreach (var entry in idols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            idolSource = reader.ReadSByte();
            var limit = reader.ReadUShort();
            idols = new Types.Idol[limit];
            for (int i = 0; i < limit; i++)
            {
                 (idols as Types.Idol[])[i] = ProtocolTypeManager.GetInstance<Types.Idol>(reader.ReadUShort());
                 (idols as Types.Idol[])[i].Deserialize(reader);
            }
        }
        
    }
    
}