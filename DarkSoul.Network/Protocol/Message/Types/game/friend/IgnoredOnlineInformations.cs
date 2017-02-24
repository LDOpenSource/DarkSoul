

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class IgnoredOnlineInformations : IgnoredInformations
    {
        public override short TypeId => 105;
        
        public double playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        
        public IgnoredOnlineInformations()
        {
        }
        
        public IgnoredOnlineInformations(int accountId, string accountName, double playerId, string playerName, sbyte breed, bool sex)
         : base(accountId, accountName)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
        }
        
    }
    
}