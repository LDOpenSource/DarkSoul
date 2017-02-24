

// Generated on 02/23/2017 16:53:41
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class PartyInvitationDungeonRequestMessage : PartyInvitationRequestMessage
    {
        public override ushort Id => 6245;
        
        
        public ushort dungeonId;
        
        public PartyInvitationDungeonRequestMessage()
        {
        }
        
        public PartyInvitationDungeonRequestMessage(string name, ushort dungeonId)
         : base(name)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)dungeonId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            dungeonId = reader.ReadVarUhShort();
        }
        
    }
    
}