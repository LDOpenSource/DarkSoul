

// Generated on 02/23/2017 18:06:45
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class TaxCollectorMovement
    {
        public virtual short TypeId => 493;
        
        public sbyte movementType;
        public Types.TaxCollectorBasicInformations basicInfos;
        public double playerId;
        public string playerName;
        
        public TaxCollectorMovement()
        {
        }
        
        public TaxCollectorMovement(sbyte movementType, Types.TaxCollectorBasicInformations basicInfos, double playerId, string playerName)
        {
            this.movementType = movementType;
            this.basicInfos = basicInfos;
            this.playerId = playerId;
            this.playerName = playerName;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteSByte(movementType);
            basicInfos.Serialize(writer);
            writer.WriteVarLong(playerId);
            writer.WriteUTF(playerName);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            movementType = reader.ReadSByte();
            basicInfos = new Types.TaxCollectorBasicInformations();
            basicInfos.Deserialize(reader);
            playerId = reader.ReadVarUhLong();
            playerName = reader.ReadUTF();
        }
        
    }
    
}