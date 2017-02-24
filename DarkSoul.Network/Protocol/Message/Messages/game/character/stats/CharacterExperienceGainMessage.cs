

// Generated on 02/23/2017 16:53:25
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class CharacterExperienceGainMessage : NetworkMessage
    {
        public override ushort Id => 6321;
        
        
        public double experienceCharacter;
        public double experienceMount;
        public double experienceGuild;
        public double experienceIncarnation;
        
        public CharacterExperienceGainMessage()
        {
        }
        
        public CharacterExperienceGainMessage(double experienceCharacter, double experienceMount, double experienceGuild, double experienceIncarnation)
        {
            this.experienceCharacter = experienceCharacter;
            this.experienceMount = experienceMount;
            this.experienceGuild = experienceGuild;
            this.experienceIncarnation = experienceIncarnation;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarLong(experienceCharacter);
            writer.WriteVarLong(experienceMount);
            writer.WriteVarLong(experienceGuild);
            writer.WriteVarLong(experienceIncarnation);
        }
        
        public override void Deserialize(IReader reader)
        {
            experienceCharacter = reader.ReadVarUhLong();
            experienceMount = reader.ReadVarUhLong();
            experienceGuild = reader.ReadVarUhLong();
            experienceIncarnation = reader.ReadVarUhLong();
        }
        
    }
    
}