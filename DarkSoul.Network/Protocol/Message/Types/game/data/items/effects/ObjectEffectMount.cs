

// Generated on 02/23/2017 18:06:44
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class ObjectEffectMount : ObjectEffect
    {
        public override short TypeId => 179;
        
        public int mountId;
        public double date;
        public ushort modelId;
        
        public ObjectEffectMount()
        {
        }
        
        public ObjectEffectMount(ushort actionId, int mountId, double date, ushort modelId)
         : base(actionId)
        {
            this.mountId = mountId;
            this.date = date;
            this.modelId = modelId;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(mountId);
            writer.WriteDouble(date);
            writer.WriteVarShort((int)modelId);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            mountId = reader.ReadInt();
            date = reader.ReadDouble();
            modelId = reader.ReadVarUhShort();
        }
        
    }
    
}