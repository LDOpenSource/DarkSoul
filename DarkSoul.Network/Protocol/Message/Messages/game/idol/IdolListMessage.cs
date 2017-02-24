

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
    public class IdolListMessage : NetworkMessage
    {
        public override ushort Id => 6585;
        
        
        public IEnumerable<ushort> chosenIdols;
        public IEnumerable<ushort> partyChosenIdols;
        public IEnumerable<Types.PartyIdol> partyIdols;
        
        public IdolListMessage()
        {
        }
        
        public IdolListMessage(IEnumerable<ushort> chosenIdols, IEnumerable<ushort> partyChosenIdols, IEnumerable<Types.PartyIdol> partyIdols)
        {
            this.chosenIdols = chosenIdols;
            this.partyChosenIdols = partyChosenIdols;
            this.partyIdols = partyIdols;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)chosenIdols.Count());
            foreach (var entry in chosenIdols)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)partyChosenIdols.Count());
            foreach (var entry in partyChosenIdols)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)partyIdols.Count());
            foreach (var entry in partyIdols)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            chosenIdols = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (chosenIdols as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            partyChosenIdols = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (partyChosenIdols as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            partyIdols = new Types.PartyIdol[limit];
            for (int i = 0; i < limit; i++)
            {
                 (partyIdols as Types.PartyIdol[])[i] = ProtocolTypeManager.GetInstance<Types.PartyIdol>(reader.ReadUShort());
                 (partyIdols as Types.PartyIdol[])[i].Deserialize(reader);
            }
        }
        
    }
    
}