

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AllianceTaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionExtendedMessage
    {
        public override ushort Id => 6445;
        
        
        public Types.BasicNamedAllianceInformations alliance;
        
        public AllianceTaxCollectorDialogQuestionExtendedMessage()
        {
        }
        
        public AllianceTaxCollectorDialogQuestionExtendedMessage(Types.BasicGuildInformations guildInfo, ushort maxPods, ushort prospecting, ushort wisdom, sbyte taxCollectorsCount, int taxCollectorAttack, double kamas, double experience, uint pods, double itemsValue, Types.BasicNamedAllianceInformations alliance)
         : base(guildInfo, maxPods, prospecting, wisdom, taxCollectorsCount, taxCollectorAttack, kamas, experience, pods, itemsValue)
        {
            this.alliance = alliance;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            alliance.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            alliance = new Types.BasicNamedAllianceInformations();
            alliance.Deserialize(reader);
        }
        
    }
    
}