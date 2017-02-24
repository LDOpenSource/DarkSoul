

// Generated on 02/23/2017 16:53:35
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayArenaFightPropositionMessage : NetworkMessage
    {
        public override ushort Id => 6276;
        
        
        public int fightId;
        public IEnumerable<double> alliesId;
        public ushort duration;
        
        public GameRolePlayArenaFightPropositionMessage()
        {
        }
        
        public GameRolePlayArenaFightPropositionMessage(int fightId, IEnumerable<double> alliesId, ushort duration)
        {
            this.fightId = fightId;
            this.alliesId = alliesId;
            this.duration = duration;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteShort((short)alliesId.Count());
            foreach (var entry in alliesId)
            {
                 writer.WriteDouble(entry);
            }
            writer.WriteVarShort((int)duration);
        }
        
        public override void Deserialize(IReader reader)
        {
            fightId = reader.ReadInt();
            var limit = reader.ReadUShort();
            alliesId = new double[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alliesId as double[])[i] = reader.ReadDouble();
            }
            duration = reader.ReadVarUhShort();
        }
        
    }
    
}