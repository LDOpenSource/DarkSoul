

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightFighterCompanionLightInformations : GameFightFighterLightInformations
    {
        public override short TypeId => 454;
        
        public sbyte companionId;
        public double masterId;
        
        public GameFightFighterCompanionLightInformations()
        {
        }
        
        public GameFightFighterCompanionLightInformations(bool sex, bool alive, double id, sbyte wave, ushort level, sbyte breed, sbyte companionId, double masterId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.companionId = companionId;
            this.masterId = masterId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(companionId);
            writer.WriteDouble(masterId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            companionId = reader.ReadSByte();
            masterId = reader.ReadDouble();
        }
        
    }
    
}