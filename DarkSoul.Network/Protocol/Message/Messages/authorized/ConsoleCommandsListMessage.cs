

// Generated on 02/23/2017 16:53:15
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ConsoleCommandsListMessage : NetworkMessage
    {
        public override ushort Id => 6127;
        
        
        public IEnumerable<string> aliases;
        public IEnumerable<string> args;
        public IEnumerable<string> descriptions;
        
        public ConsoleCommandsListMessage()
        {
        }
        
        public ConsoleCommandsListMessage(IEnumerable<string> aliases, IEnumerable<string> args, IEnumerable<string> descriptions)
        {
            this.aliases = aliases;
            this.args = args;
            this.descriptions = descriptions;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)aliases.Count());
            foreach (var entry in aliases)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)args.Count());
            foreach (var entry in args)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)descriptions.Count());
            foreach (var entry in descriptions)
            {
                 writer.WriteUTF(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            aliases = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (aliases as string[])[i] = reader.ReadUTF();
            }
            limit = reader.ReadUShort();
            args = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (args as string[])[i] = reader.ReadUTF();
            }
            limit = reader.ReadUShort();
            descriptions = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (descriptions as string[])[i] = reader.ReadUTF();
            }
        }
        
    }
    
}