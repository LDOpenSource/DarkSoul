

// Generated on 02/23/2017 16:53:48
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GuildInformationsGeneralMessage : NetworkMessage
    {
        public override ushort Id => 5557;
        
        
        public bool abandonnedPaddock;
        public byte level;
        public double expLevelFloor;
        public double experience;
        public double expNextLevelFloor;
        public int creationDate;
        public ushort nbTotalMembers;
        public ushort nbConnectedMembers;
        
        public GuildInformationsGeneralMessage()
        {
        }
        
        public GuildInformationsGeneralMessage(bool abandonnedPaddock, byte level, double expLevelFloor, double experience, double expNextLevelFloor, int creationDate, ushort nbTotalMembers, ushort nbConnectedMembers)
        {
            this.abandonnedPaddock = abandonnedPaddock;
            this.level = level;
            this.expLevelFloor = expLevelFloor;
            this.experience = experience;
            this.expNextLevelFloor = expNextLevelFloor;
            this.creationDate = creationDate;
            this.nbTotalMembers = nbTotalMembers;
            this.nbConnectedMembers = nbConnectedMembers;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(abandonnedPaddock);
            writer.WriteByte(level);
            writer.WriteVarLong(expLevelFloor);
            writer.WriteVarLong(experience);
            writer.WriteVarLong(expNextLevelFloor);
            writer.WriteInt(creationDate);
            writer.WriteVarShort((int)nbTotalMembers);
            writer.WriteVarShort((int)nbConnectedMembers);
        }
        
        public override void Deserialize(IReader reader)
        {
            abandonnedPaddock = reader.ReadBoolean();
            level = reader.ReadByte();
            expLevelFloor = reader.ReadVarUhLong();
            experience = reader.ReadVarUhLong();
            expNextLevelFloor = reader.ReadVarUhLong();
            creationDate = reader.ReadInt();
            nbTotalMembers = reader.ReadVarUhShort();
            nbConnectedMembers = reader.ReadVarUhShort();
        }
        
    }
    
}