

// Generated on 02/23/2017 16:53:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class TreasureHuntMessage : NetworkMessage
    {
        public override ushort Id => 6486;
        
        
        public sbyte questType;
        public int startMapId;
        public IEnumerable<Types.TreasureHuntStep> knownStepsList;
        public sbyte totalStepCount;
        public uint checkPointCurrent;
        public uint checkPointTotal;
        public int availableRetryCount;
        public IEnumerable<Types.TreasureHuntFlag> flags;
        
        public TreasureHuntMessage()
        {
        }
        
        public TreasureHuntMessage(sbyte questType, int startMapId, IEnumerable<Types.TreasureHuntStep> knownStepsList, sbyte totalStepCount, uint checkPointCurrent, uint checkPointTotal, int availableRetryCount, IEnumerable<Types.TreasureHuntFlag> flags)
        {
            this.questType = questType;
            this.startMapId = startMapId;
            this.knownStepsList = knownStepsList;
            this.totalStepCount = totalStepCount;
            this.checkPointCurrent = checkPointCurrent;
            this.checkPointTotal = checkPointTotal;
            this.availableRetryCount = availableRetryCount;
            this.flags = flags;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteSByte(questType);
            writer.WriteInt(startMapId);
            writer.WriteShort((short)knownStepsList.Count());
            foreach (var entry in knownStepsList)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteSByte(totalStepCount);
            writer.WriteVarInt((int)checkPointCurrent);
            writer.WriteVarInt((int)checkPointTotal);
            writer.WriteInt(availableRetryCount);
            writer.WriteShort((short)flags.Count());
            foreach (var entry in flags)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            questType = reader.ReadSByte();
            startMapId = reader.ReadInt();
            var limit = reader.ReadUShort();
            knownStepsList = new Types.TreasureHuntStep[limit];
            for (int i = 0; i < limit; i++)
            {
                 (knownStepsList as Types.TreasureHuntStep[])[i] = ProtocolTypeManager.GetInstance<Types.TreasureHuntStep>(reader.ReadUShort());
                 (knownStepsList as Types.TreasureHuntStep[])[i].Deserialize(reader);
            }
            totalStepCount = reader.ReadSByte();
            checkPointCurrent = reader.ReadVarUhInt();
            checkPointTotal = reader.ReadVarUhInt();
            availableRetryCount = reader.ReadInt();
            limit = reader.ReadUShort();
            flags = new Types.TreasureHuntFlag[limit];
            for (int i = 0; i < limit; i++)
            {
                 (flags as Types.TreasureHuntFlag[])[i] = new Types.TreasureHuntFlag();
                 (flags as Types.TreasureHuntFlag[])[i].Deserialize(reader);
            }
        }
        
    }
    
}