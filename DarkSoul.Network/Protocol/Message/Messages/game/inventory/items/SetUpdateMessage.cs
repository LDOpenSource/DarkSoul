

// Generated on 02/23/2017 16:53:59
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class SetUpdateMessage : NetworkMessage
    {
        public override ushort Id => 5503;
        
        
        public ushort setId;
        public IEnumerable<ushort> setObjects;
        public IEnumerable<Types.ObjectEffect> setEffects;
        
        public SetUpdateMessage()
        {
        }
        
        public SetUpdateMessage(ushort setId, IEnumerable<ushort> setObjects, IEnumerable<Types.ObjectEffect> setEffects)
        {
            this.setId = setId;
            this.setObjects = setObjects;
            this.setEffects = setEffects;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)setId);
            writer.WriteShort((short)setObjects.Count());
            foreach (var entry in setObjects)
            {
                 writer.WriteVarShort((int)entry);
            }
            writer.WriteShort((short)setEffects.Count());
            foreach (var entry in setEffects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            setId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            setObjects = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (setObjects as ushort[])[i] = reader.ReadVarUhShort();
            }
            limit = reader.ReadUShort();
            setEffects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 (setEffects as Types.ObjectEffect[])[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 (setEffects as Types.ObjectEffect[])[i].Deserialize(reader);
            }
        }
        
    }
    
}