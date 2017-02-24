

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
    public class TaxCollectorDialogQuestionExtendedMessage : TaxCollectorDialogQuestionBasicMessage
    {
        public override ushort Id => 5615;
        
        
        public ushort maxPods;
        public ushort prospecting;
        public ushort wisdom;
        public sbyte taxCollectorsCount;
        public int taxCollectorAttack;
        public double kamas;
        public double experience;
        public uint pods;
        public double itemsValue;
        
        public TaxCollectorDialogQuestionExtendedMessage()
        {
        }
        
        public TaxCollectorDialogQuestionExtendedMessage(Types.BasicGuildInformations guildInfo, ushort maxPods, ushort prospecting, ushort wisdom, sbyte taxCollectorsCount, int taxCollectorAttack, double kamas, double experience, uint pods, double itemsValue)
         : base(guildInfo)
        {
            this.maxPods = maxPods;
            this.prospecting = prospecting;
            this.wisdom = wisdom;
            this.taxCollectorsCount = taxCollectorsCount;
            this.taxCollectorAttack = taxCollectorAttack;
            this.kamas = kamas;
            this.experience = experience;
            this.pods = pods;
            this.itemsValue = itemsValue;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)maxPods);
            writer.WriteVarShort((int)prospecting);
            writer.WriteVarShort((int)wisdom);
            writer.WriteSByte(taxCollectorsCount);
            writer.WriteInt(taxCollectorAttack);
            writer.WriteVarLong(kamas);
            writer.WriteVarLong(experience);
            writer.WriteVarInt((int)pods);
            writer.WriteVarLong(itemsValue);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            maxPods = reader.ReadVarUhShort();
            prospecting = reader.ReadVarUhShort();
            wisdom = reader.ReadVarUhShort();
            taxCollectorsCount = reader.ReadSByte();
            taxCollectorAttack = reader.ReadInt();
            kamas = reader.ReadVarUhLong();
            experience = reader.ReadVarUhLong();
            pods = reader.ReadVarUhInt();
            itemsValue = reader.ReadVarUhLong();
        }
        
    }
    
}