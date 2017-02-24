

// Generated on 02/23/2017 16:53:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyMemberInFightMessage : AbstractPartyMessage
    {
        public override ushort Id => 6342;
        
        
        public sbyte reason;
        public double memberId;
        public int memberAccountId;
        public string memberName;
        public int fightId;
        public Types.MapCoordinatesExtended fightMap;
        public short timeBeforeFightStart;
        
        public PartyMemberInFightMessage()
        {
        }
        
        public PartyMemberInFightMessage(uint partyId, sbyte reason, double memberId, int memberAccountId, string memberName, int fightId, Types.MapCoordinatesExtended fightMap, short timeBeforeFightStart)
         : base(partyId)
        {
            this.reason = reason;
            this.memberId = memberId;
            this.memberAccountId = memberAccountId;
            this.memberName = memberName;
            this.fightId = fightId;
            this.fightMap = fightMap;
            this.timeBeforeFightStart = timeBeforeFightStart;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(reason);
            writer.WriteVarLong(memberId);
            writer.WriteInt(memberAccountId);
            writer.WriteUTF(memberName);
            writer.WriteInt(fightId);
            fightMap.Serialize(writer);
            writer.WriteVarShort((int)timeBeforeFightStart);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            reason = reader.ReadSByte();
            memberId = reader.ReadVarUhLong();
            memberAccountId = reader.ReadInt();
            memberName = reader.ReadUTF();
            fightId = reader.ReadInt();
            fightMap = new Types.MapCoordinatesExtended();
            fightMap.Deserialize(reader);
            timeBeforeFightStart = reader.ReadVarShort();
        }
        
    }
    
}