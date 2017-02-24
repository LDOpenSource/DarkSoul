

// Generated on 02/23/2017 16:53:49
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TaxCollectorAttackedResultMessage : NetworkMessage
    {
        public override ushort Id => 5635;
        
        
        public bool deadOrAlive;
        public Types.TaxCollectorBasicInformations basicInfos;
        public Types.BasicGuildInformations guild;
        
        public TaxCollectorAttackedResultMessage()
        {
        }
        
        public TaxCollectorAttackedResultMessage(bool deadOrAlive, Types.TaxCollectorBasicInformations basicInfos, Types.BasicGuildInformations guild)
        {
            this.deadOrAlive = deadOrAlive;
            this.basicInfos = basicInfos;
            this.guild = guild;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(deadOrAlive);
            basicInfos.Serialize(writer);
            guild.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            deadOrAlive = reader.ReadBoolean();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            guild = new Types.BasicGuildInformations();
            guild.Deserialize(reader);
        }
        
    }
    
}