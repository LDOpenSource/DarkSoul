

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class HouseGuildedInformations : HouseInstanceInformations
    {
        public override short TypeId => 0x0200;
        
        public Types.GuildInformations guildInfo;
        
        public HouseGuildedInformations()
        {
        }
        
        public HouseGuildedInformations(bool secondHand, bool isOnSale, bool isSaleLocked, uint instanceId, string ownerName, Types.GuildInformations guildInfo)
         : base(secondHand, isOnSale, isSaleLocked, instanceId, ownerName)
        {
            this.guildInfo = guildInfo;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            guildInfo.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            guildInfo = new Types.GuildInformations();
            guildInfo.Deserialize(reader);
        }
        
    }
    
}