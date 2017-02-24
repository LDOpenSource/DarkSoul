

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class DungeonPartyFinderPlayer
    {
        public virtual short TypeId => 373;
        
        public double playerId;
        public string playerName;
        public sbyte breed;
        public bool sex;
        public byte level;
        
        public DungeonPartyFinderPlayer()
        {
        }
        
        public DungeonPartyFinderPlayer(double playerId, string playerName, sbyte breed, bool sex, byte level)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.breed = breed;
            this.sex = sex;
            this.level = level;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteByte(level);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            level = reader.ReadByte();
        }
        
    }
    
}