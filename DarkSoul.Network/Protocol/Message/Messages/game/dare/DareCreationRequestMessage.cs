

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
    public class DareCreationRequestMessage : NetworkMessage
    {
        public override ushort Id => 6665;
        
        
        public bool isPrivate;
        public bool isForGuild;
        public bool isForAlliance;
        public bool needNotifications;
        public double subscriptionFee;
        public double jackpot;
        public ushort maxCountWinners;
        public uint delayBeforeStart;
        public uint duration;
        public IEnumerable<Types.DareCriteria> criterions;
        
        public DareCreationRequestMessage()
        {
        }
        
        public DareCreationRequestMessage(bool isPrivate, bool isForGuild, bool isForAlliance, bool needNotifications, double subscriptionFee, double jackpot, ushort maxCountWinners, uint delayBeforeStart, uint duration, IEnumerable<Types.DareCriteria> criterions)
        {
            this.isPrivate = isPrivate;
            this.isForGuild = isForGuild;
            this.isForAlliance = isForAlliance;
            this.needNotifications = needNotifications;
            this.subscriptionFee = subscriptionFee;
            this.jackpot = jackpot;
            this.maxCountWinners = maxCountWinners;
            this.delayBeforeStart = delayBeforeStart;
            this.duration = duration;
            this.criterions = criterions;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isPrivate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isForGuild);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, isForAlliance);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 3, needNotifications);
            writer.WriteByte(flag1);
            writer.WriteVarLong(subscriptionFee);
            writer.WriteVarLong(jackpot);
            writer.WriteUShort(maxCountWinners);
            writer.WriteUInt(delayBeforeStart);
            writer.WriteUInt(duration);
            writer.WriteShort((short)criterions.Count());
            foreach (var entry in criterions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            isPrivate = BooleanByteWrapper.GetFlag(flag1, 0);
            isForGuild = BooleanByteWrapper.GetFlag(flag1, 1);
            isForAlliance = BooleanByteWrapper.GetFlag(flag1, 2);
            needNotifications = BooleanByteWrapper.GetFlag(flag1, 3);
            subscriptionFee = reader.ReadVarUhLong();
            jackpot = reader.ReadVarUhLong();
            maxCountWinners = reader.ReadUShort();
            delayBeforeStart = reader.ReadUInt();
            duration = reader.ReadUInt();
            var limit = reader.ReadUShort();
            criterions = new Types.DareCriteria[limit];
            for (int i = 0; i < limit; i++)
            {
                 (criterions as Types.DareCriteria[])[i] = new Types.DareCriteria();
                 (criterions as Types.DareCriteria[])[i].Deserialize(reader);
            }
        }
        
    }
    
}