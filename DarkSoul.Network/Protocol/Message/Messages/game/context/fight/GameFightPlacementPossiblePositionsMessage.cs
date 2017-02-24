

// Generated on 02/23/2017 16:53:30
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameFightPlacementPossiblePositionsMessage : NetworkMessage
    {
        public override ushort Id => 703;
        
        
        public IEnumerable<ushort> positionsForChallengers;
        public IEnumerable<ushort> positionsForDefenders;
        public sbyte teamNumber;
        
        public GameFightPlacementPossiblePositionsMessage()
        {
        }
        
        public GameFightPlacementPossiblePositionsMessage(IEnumerable<ushort> positionsForChallengers, IEnumerable<ushort> positionsForDefenders, sbyte teamNumber)
        {
            this.positionsForChallengers = positionsForChallengers;
            this.positionsForDefenders = positionsForDefenders;
            this.teamNumber = teamNumber;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)positionsForChallengers.Count());
            foreach (var entry in positionsForChallengers)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)positionsForDefenders.Count());
            foreach (var entry in positionsForDefenders)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteSByte(teamNumber);
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            positionsForChallengers = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (positionsForChallengers as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            positionsForDefenders = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (positionsForDefenders as ushort[])[i] = reader.ReadVarUhShort();
            }
            teamNumber = reader.ReadSByte();
        }
        
    }
    
}