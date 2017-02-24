

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
    public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage
    {
        public override ushort Id => 5669;
        
        
        public int mapId;
        public uint elementId;
        
        public LockableStateUpdateStorageMessage()
        {
        }
        
        public LockableStateUpdateStorageMessage(bool locked, int mapId, uint elementId)
         : base(locked)
        {
            this.mapId = mapId;
            this.elementId = elementId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(mapId);
            writer.WriteVarInt((int)elementId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            mapId = reader.ReadInt();
            elementId = reader.ReadVarUhInt();
        }
        
    }
    
}