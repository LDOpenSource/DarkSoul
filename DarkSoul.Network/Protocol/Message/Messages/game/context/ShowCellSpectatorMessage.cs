

// Generated on 02/23/2017 16:53:29
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class ShowCellSpectatorMessage : ShowCellMessage
    {
        public override ushort Id => 6158;
        
        
        public string playerName;
        
        public ShowCellSpectatorMessage()
        {
        }
        
        public ShowCellSpectatorMessage(double sourceId, ushort cellId, string playerName)
         : base(sourceId, cellId)
        {
            this.playerName = playerName;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(playerName);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            playerName = reader.ReadUTF();
        }
        
    }
    
}