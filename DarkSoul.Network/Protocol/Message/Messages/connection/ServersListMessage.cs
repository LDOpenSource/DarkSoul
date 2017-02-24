

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ServersListMessage : NetworkMessage
    {
        public override ushort Id => 30;
        
        
        public IEnumerable<Types.GameServerInformations> servers;
        public ushort alreadyConnectedToServerId;
        public bool canCreateNewCharacter;
        
        public ServersListMessage()
        {
        }
        
        public ServersListMessage(IEnumerable<Types.GameServerInformations> servers, ushort alreadyConnectedToServerId, bool canCreateNewCharacter)
        {
            this.servers = servers;
            this.alreadyConnectedToServerId = alreadyConnectedToServerId;
            this.canCreateNewCharacter = canCreateNewCharacter;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)servers.Count());
            foreach (var entry in servers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteVarShort((int)alreadyConnectedToServerId);
            writer.WriteBoolean(canCreateNewCharacter);
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            servers = new Types.GameServerInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (servers as Types.GameServerInformations[])[i] = new Types.GameServerInformations();
                 (servers as Types.GameServerInformations[])[i].Deserialize(reader);
            }
            alreadyConnectedToServerId = reader.ReadVarUhShort();
            canCreateNewCharacter = reader.ReadBoolean();
        }
        
    }
    
}