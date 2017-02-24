

// Generated on 02/23/2017 16:53:22
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class KohUpdateMessage : NetworkMessage
    {
        public override ushort Id => 6439;
        
        
        public IEnumerable<Types.AllianceInformations> alliances;
        public IEnumerable<ushort> allianceNbMembers;
        public IEnumerable<uint> allianceRoundWeigth;
        public IEnumerable<sbyte> allianceMatchScore;
        public Types.BasicAllianceInformations allianceMapWinner;
        public uint allianceMapWinnerScore;
        public uint allianceMapMyAllianceScore;
        public double nextTickTime;
        
        public KohUpdateMessage()
        {
        }
        
        public KohUpdateMessage(IEnumerable<Types.AllianceInformations> alliances, IEnumerable<ushort> allianceNbMembers, IEnumerable<uint> allianceRoundWeigth, IEnumerable<sbyte> allianceMatchScore, Types.BasicAllianceInformations allianceMapWinner, uint allianceMapWinnerScore, uint allianceMapMyAllianceScore, double nextTickTime)
        {
            this.alliances = alliances;
            this.allianceNbMembers = allianceNbMembers;
            this.allianceRoundWeigth = allianceRoundWeigth;
            this.allianceMatchScore = allianceMatchScore;
            this.allianceMapWinner = allianceMapWinner;
            this.allianceMapWinnerScore = allianceMapWinnerScore;
            this.allianceMapMyAllianceScore = allianceMapMyAllianceScore;
            this.nextTickTime = nextTickTime;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort((short)alliances.Count());
            foreach (var entry in alliances)
            {
                 entry.Serialize(writer);
            }
            writer.WriteShort((short)allianceNbMembers.Count());
            foreach (var entry in allianceNbMembers)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)allianceRoundWeigth.Count());
            foreach (var entry in allianceRoundWeigth)
            {
                 writer.WriteVarInt((int)entry);
            }
            writer.WriteShort((short)allianceMatchScore.Count());
            foreach (var entry in allianceMatchScore)
            {
                 writer.WriteSByte(entry);
            }
            allianceMapWinner.Serialize(writer);
            writer.WriteVarInt((int)allianceMapWinnerScore);
            writer.WriteVarInt((int)allianceMapMyAllianceScore);
            writer.WriteDouble(nextTickTime);
        }
        
        public override void Deserialize(IReader reader)
        {
            var limit = reader.ReadUShort();
            alliances = new Types.AllianceInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 (alliances as Types.AllianceInformations[])[i] = new Types.AllianceInformations();
                 (alliances as Types.AllianceInformations[])[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            allianceNbMembers = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (allianceNbMembers as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            allianceRoundWeigth = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 (allianceRoundWeigth as uint[])[i] = reader.ReadVarUhInt();
            }
            limit = reader.ReadUShort();
            allianceMatchScore = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (allianceMatchScore as sbyte[])[i] = reader.ReadSByte();
            }
            allianceMapWinner = new Types.BasicAllianceInformations();
            allianceMapWinner.Deserialize(reader);
            allianceMapWinnerScore = reader.ReadVarUhInt();
            allianceMapMyAllianceScore = reader.ReadVarUhInt();
            nextTickTime = reader.ReadDouble();
        }
        
    }
    
}