

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
    public class PartyInvitationDungeonDetailsMessage : PartyInvitationDetailsMessage
    {
        public override ushort Id => 6262;
        
        
        public ushort dungeonId;
        public IEnumerable<bool> playersDungeonReady;
        
        public PartyInvitationDungeonDetailsMessage()
        {
        }
        
        public PartyInvitationDungeonDetailsMessage(uint partyId, sbyte partyType, string partyName, double fromId, string fromName, double leaderId, IEnumerable<Types.PartyInvitationMemberInformations> members, IEnumerable<Types.PartyGuestInformations> guests, ushort dungeonId, IEnumerable<bool> playersDungeonReady)
         : base(partyId, partyType, partyName, fromId, fromName, leaderId, members, guests)
        {
            this.dungeonId = dungeonId;
            this.playersDungeonReady = playersDungeonReady;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((int)dungeonId);
            writer.WriteShort((short)playersDungeonReady.Count());
            foreach (var entry in playersDungeonReady)
            {
                 writer.WriteBoolean(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            dungeonId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            playersDungeonReady = new bool[limit];
            for (int i = 0; i < limit; i++)
            {
                 (playersDungeonReady as bool[])[i] = reader.ReadBoolean();
            }
        }
        
    }
    
}