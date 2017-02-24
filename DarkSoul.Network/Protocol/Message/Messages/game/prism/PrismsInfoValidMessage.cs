

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
    public class PrismsInfoValidMessage : NetworkMessage
    {
        public override ushort Id => 6451;
        
        
        public IEnumerable<Types.PrismFightersInformation> fights;
        
        public PrismsInfoValidMessage()
        {
        }
        
        public PrismsInfoValidMessage(IEnumerable<Types.PrismFightersInformation> fights)
        {
            this.fights = fights;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)fights.Count());
            foreach (var entry in fights)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            fights = new Types.PrismFightersInformation[limit];
            for (int i = 0; i < limit; i++)
            {
                 (fights as Types.PrismFightersInformation[])[i] = new Types.PrismFightersInformation();
                 (fights as Types.PrismFightersInformation[])[i].Deserialize(reader);
            }
        }
        
    }
    
}