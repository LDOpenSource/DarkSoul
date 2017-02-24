

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FriendInformations : AbstractContactInformations
    {
        public override short TypeId => 78;
        
        public sbyte playerState;
        public ushort lastConnection;
        public int achievementPoints;
        
        public FriendInformations()
        {
        }
        
        public FriendInformations(int accountId, string accountName, sbyte playerState, ushort lastConnection, int achievementPoints)
         : base(accountId, accountName)
        {
            this.playerState = playerState;
            this.lastConnection = lastConnection;
            this.achievementPoints = achievementPoints;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(playerState);
            writer.WriteVarShort((int)lastConnection);
            writer.WriteInt(achievementPoints);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerState = reader.ReadSByte();
            lastConnection = reader.ReadVarUhShort();
            achievementPoints = reader.ReadInt();
        }
        
    }
    
}