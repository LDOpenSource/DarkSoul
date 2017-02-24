

// Generated on 02/23/2017 16:53:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class DareSubscribedListMessage : NetworkMessage
    {
        public override ushort Id => 6658;
        
        
        public IEnumerable<Types.DareInformations> daresFixedInfos;
        public IEnumerable<Types.DareVersatileInformations> daresVersatilesInfos;
        
        public DareSubscribedListMessage()
        {
        }
        
        public DareSubscribedListMessage(IEnumerable<Types.DareInformations> daresFixedInfos, IEnumerable<Types.DareVersatileInformations> daresVersatilesInfos)
        {
            this.daresFixedInfos = daresFixedInfos;
            this.daresVersatilesInfos = daresVersatilesInfos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)daresFixedInfos.Count());
            foreach (var entry in daresFixedInfos)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)daresVersatilesInfos.Count());
            foreach (var entry in daresVersatilesInfos)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            daresFixedInfos = new Types.DareInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (daresFixedInfos as Types.DareInformations[])[i] = new Types.DareInformations();
                 (daresFixedInfos as Types.DareInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            daresVersatilesInfos = new Types.DareVersatileInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (daresVersatilesInfos as Types.DareVersatileInformations[])[i] = new Types.DareVersatileInformations();
                 (daresVersatilesInfos as Types.DareVersatileInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}