

// Generated on 02/23/2017 18:06:40
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class GameFightFighterTaxCollectorLightInformations : GameFightFighterLightInformations
    {
        public override short TypeId => 457;
        
        public ushort firstNameId;
        public ushort lastNameId;
        
        public GameFightFighterTaxCollectorLightInformations()
        {
        }
        
        public GameFightFighterTaxCollectorLightInformations(bool sex, bool alive, double id, sbyte wave, ushort level, sbyte breed, ushort firstNameId, ushort lastNameId)
         : base(sex, alive, id, wave, level, breed)
        {
            this.firstNameId = firstNameId;
            this.lastNameId = lastNameId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)firstNameId);
            writer.WriteVarShort((int)lastNameId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            firstNameId = reader.ReadVarUhShort();
            lastNameId = reader.ReadVarUhShort();
        }
        
    }
    
}