

// Generated on 02/23/2017 16:53:36
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class GameRolePlayArenaRegistrationStatusMessage : NetworkMessage
    {
        public override ushort Id => 6284;
        
        
        public bool registered;
        public sbyte step;
        public int battleMode;
        
        public GameRolePlayArenaRegistrationStatusMessage()
        {
        }
        
        public GameRolePlayArenaRegistrationStatusMessage(bool registered, sbyte step, int battleMode)
        {
            this.registered = registered;
            this.step = step;
            this.battleMode = battleMode;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteBoolean(registered);
            writer.WriteSByte(step);
            writer.WriteInt(battleMode);
        }
        
        public override void Deserialize(IReader reader)
        {
            registered = reader.ReadBoolean();
            step = reader.ReadSByte();
            battleMode = reader.ReadInt();
        }
        
    }
    
}