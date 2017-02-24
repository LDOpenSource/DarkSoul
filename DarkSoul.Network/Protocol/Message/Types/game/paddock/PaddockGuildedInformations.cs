

// Generated on 02/23/2017 18:06:46
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PaddockGuildedInformations : PaddockBuyableInformations
    {
        public override short TypeId => 508;
        
        public bool deserted;
        public Types.GuildInformations guildInfo;
        
        public PaddockGuildedInformations()
        {
        }
        
        public PaddockGuildedInformations(double price, bool locked, bool deserted, Types.GuildInformations guildInfo)
         : base(price, locked)
        {
            this.deserted = deserted;
            this.guildInfo = guildInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(deserted);
            guildInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            deserted = reader.ReadBoolean();
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
        }
        
    }
    
}