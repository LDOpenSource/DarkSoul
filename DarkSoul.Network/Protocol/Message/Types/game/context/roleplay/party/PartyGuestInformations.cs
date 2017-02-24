

// Generated on 02/23/2017 18:06:42
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class PartyGuestInformations
    {
        public virtual short TypeId => 374;
        
        public double guestId;
        public double hostId;
        public string name;
        public Types.EntityLook guestLook;
        public sbyte breed;
        public bool sex;
        public Types.PlayerStatus status;
        public IEnumerable<Types.PartyCompanionBaseInformations> companions;
        
        public PartyGuestInformations()
        {
        }
        
        public PartyGuestInformations(double guestId, double hostId, string name, Types.EntityLook guestLook, sbyte breed, bool sex, Types.PlayerStatus status, IEnumerable<Types.PartyCompanionBaseInformations> companions)
        {
            this.guestId = guestId;
            this.hostId = hostId;
            this.name = name;
            this.guestLook = guestLook;
            this.breed = breed;
            this.sex = sex;
            this.status = status;
            this.companions = companions;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            writer.WriteVarLong(guestId);
            writer.WriteVarLong(hostId);
            writer.WriteUTF(name);
            guestLook.Serialize(writer);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteShort(status.TypeId);
            status.Serialize(writer);
            writer.WriteShort((short)companions.Count());
            foreach (var entry in companions)
            {
                 entry.Serialize(writer);
            }
        }
        
        public virtual void Deserialize(IReader reader)
        {
            guestId = reader.ReadVarUhLong();
            hostId = reader.ReadVarUhLong();
            name = reader.ReadUTF();
            guestLook = new Types.EntityLook();
            guestLook.Deserialize(reader);
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            status = ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
            var limit = reader.ReadUShort();
            companions = new Types.PartyCompanionBaseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (companions as Types.PartyCompanionBaseInformations[])[i] = new Types.PartyCompanionBaseInformations();
                 (companions as Types.PartyCompanionBaseInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}