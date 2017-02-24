

// Generated on 02/23/2017 16:53:31
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SlaveSwitchContextMessage : NetworkMessage
    {
        public override ushort Id => 6214;
        
        
        public double masterId;
        public double slaveId;
        public IEnumerable<Types.SpellItem> slaveSpells;
        public Types.CharacterCharacteristicsInformations slaveStats;
        public IEnumerable<Types.Shortcut> shortcuts;
        
        public SlaveSwitchContextMessage()
        {
        }
        
        public SlaveSwitchContextMessage(double masterId, double slaveId, IEnumerable<Types.SpellItem> slaveSpells, Types.CharacterCharacteristicsInformations slaveStats, IEnumerable<Types.Shortcut> shortcuts)
        {
            this.masterId = masterId;
            this.slaveId = slaveId;
            this.slaveSpells = slaveSpells;
            this.slaveStats = slaveStats;
            this.shortcuts = shortcuts;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteDouble(masterId);
            writer.WriteDouble(slaveId);
            writer.WriteShort((short)slaveSpells.Count());
            foreach (var entry in slaveSpells)
            {
                 entry.Serialize(writer);
            }
            slaveStats.Serialize(writer);
            writer.WriteShort((short)shortcuts.Count());
            foreach (var entry in shortcuts)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            masterId = reader.ReadDouble();
            slaveId = reader.ReadDouble();
            var limit = reader.ReadUShort();
            slaveSpells = new Types.SpellItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 (slaveSpells as Types.SpellItem[])[i] = new Types.SpellItem();
                 (slaveSpells as Types.SpellItem[])[i].Deserialize(reader);
            }
            slaveStats = new Types.CharacterCharacteristicsInformations();
            slaveStats.Deserialize(reader);
            limit = reader.ReadUShort();
            shortcuts = new Types.Shortcut[limit];
            for (int i = 0; i < limit; i++)
            {
                 (shortcuts as Types.Shortcut[])[i] = ProtocolTypeManager.GetInstance<Types.Shortcut>(reader.ReadUShort());
                 (shortcuts as Types.Shortcut[])[i].Deserialize(reader);
            }
        }
        
    }
    
}