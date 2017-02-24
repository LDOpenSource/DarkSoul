

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildInformationsPaddocksMessage : NetworkMessage
    {
        public override ushort Id => 5959;
        
        
        public sbyte nbPaddockMax;
        public IEnumerable<Types.PaddockContentInformations> paddocksInformations;
        
        public GuildInformationsPaddocksMessage()
        {
        }
        
        public GuildInformationsPaddocksMessage(sbyte nbPaddockMax, IEnumerable<Types.PaddockContentInformations> paddocksInformations)
        {
            this.nbPaddockMax = nbPaddockMax;
            this.paddocksInformations = paddocksInformations;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(nbPaddockMax);
            writer.WriteShort((short)paddocksInformations.Count());
            foreach (var entry in paddocksInformations)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            nbPaddockMax = reader.ReadSByte();
            var limit = reader.ReadUShort();
            paddocksInformations = new Types.PaddockContentInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (paddocksInformations as Types.PaddockContentInformations[])[i] = new Types.PaddockContentInformations();
                 (paddocksInformations as Types.PaddockContentInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}