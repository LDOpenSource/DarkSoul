

// Generated on 02/23/2017 16:53:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MapNpcsQuestStatusUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5642;
        
        
        public int mapId;
        public IEnumerable<int> npcsIdsWithQuest;
        public IEnumerable<Types.GameRolePlayNpcQuestFlag> questFlags;
        public IEnumerable<int> npcsIdsWithoutQuest;
        
        public MapNpcsQuestStatusUpdateMessage()
        {
        }
        
        public MapNpcsQuestStatusUpdateMessage(int mapId, IEnumerable<int> npcsIdsWithQuest, IEnumerable<Types.GameRolePlayNpcQuestFlag> questFlags, IEnumerable<int> npcsIdsWithoutQuest)
        {
            this.mapId = mapId;
            this.npcsIdsWithQuest = npcsIdsWithQuest;
            this.questFlags = questFlags;
            this.npcsIdsWithoutQuest = npcsIdsWithoutQuest;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(mapId);
            writer.WriteShort((short)npcsIdsWithQuest.Count());
            foreach (var entry in npcsIdsWithQuest)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteShort((short)questFlags.Count());
            foreach (var entry in questFlags)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)npcsIdsWithoutQuest.Count());
            foreach (var entry in npcsIdsWithoutQuest)
            {
                 writer.WriteInt(entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            mapId = reader.ReadInt();
            var limit = reader.ReadUShort();
            npcsIdsWithQuest = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (npcsIdsWithQuest as int[])[i] = reader.ReadInt();
            }
            limit = reader.ReadUShort();
            questFlags = new Types.GameRolePlayNpcQuestFlag[limit];
            for (int i = 0; i < limit; i++)
            {
                 (questFlags as Types.GameRolePlayNpcQuestFlag[])[i] = new Types.GameRolePlayNpcQuestFlag();
                 (questFlags as Types.GameRolePlayNpcQuestFlag[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            npcsIdsWithoutQuest = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 (npcsIdsWithoutQuest as int[])[i] = reader.ReadInt();
            }
        }
        
    }
    
}