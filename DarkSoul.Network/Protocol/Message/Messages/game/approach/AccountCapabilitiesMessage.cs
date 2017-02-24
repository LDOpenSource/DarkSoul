

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AccountCapabilitiesMessage : NetworkMessage
    {
        public override ushort Id => 6216;
        
        
        public bool tutorialAvailable;
        public bool canCreateNewCharacter;
        public int accountId;
        public uint breedsVisible;
        public uint breedsAvailable;
        public sbyte status;
        
        public AccountCapabilitiesMessage()
        {
        }
        
        public AccountCapabilitiesMessage(bool tutorialAvailable, bool canCreateNewCharacter, int accountId, uint breedsVisible, uint breedsAvailable, sbyte status)
        {
            this.tutorialAvailable = tutorialAvailable;
            this.canCreateNewCharacter = canCreateNewCharacter;
            this.accountId = accountId;
            this.breedsVisible = breedsVisible;
            this.breedsAvailable = breedsAvailable;
            this.status = status;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, tutorialAvailable);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canCreateNewCharacter);
            writer.WriteByte(flag1);
            writer.WriteInt(accountId);
            writer.WriteVarInt((int)breedsVisible);
            writer.WriteVarInt((int)breedsAvailable);
            writer.WriteSByte(status);
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            tutorialAvailable = BooleanByteWrapper.GetFlag(flag1, 0);
            canCreateNewCharacter = BooleanByteWrapper.GetFlag(flag1, 1);
            accountId = reader.ReadInt();
            breedsVisible = reader.ReadVarUhInt();
            breedsAvailable = reader.ReadVarUhInt();
            status = reader.ReadSByte();
        }
        
    }
    
}