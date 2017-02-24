

// Generated on 02/23/2017 16:53:37
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class AccountHouseMessage : NetworkMessage
    {
        public override ushort Id => 6315;
        
        
        public IEnumerable<Types.AccountHouseInformations> houses;
        
        public AccountHouseMessage()
        {
        }
        
        public AccountHouseMessage(IEnumerable<Types.AccountHouseInformations> houses)
        {
            this.houses = houses;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)houses.Count());
            foreach (var entry in houses)
            {
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            houses = new Types.AccountHouseInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (houses as Types.AccountHouseInformations[])[i] = new Types.AccountHouseInformations();
                 (houses as Types.AccountHouseInformations[])[i].Deserialize(reader);
            }
        }
        
    }
    
}