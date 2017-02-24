

// Generated on 02/23/2017 16:53:32
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class MountInformationInPaddockRequestMessage : NetworkMessage
    {
        public override ushort Id => 5975;
        
        
        public int mapRideId;
        
        public MountInformationInPaddockRequestMessage()
        {
        }
        
        public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            this.mapRideId = mapRideId;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarInt((int)mapRideId);
        }
        
        public override void Deserialize(IReader reader)
        {
            mapRideId = reader.ReadVarInt();
        }
        
    }
    
}