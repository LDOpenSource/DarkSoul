

// Generated on 02/23/2017 16:53:43
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class QuestStepInfoMessage : NetworkMessage
    {
        public override ushort Id => 5625;
        
        
        public Types.QuestActiveInformations infos;
        
        public QuestStepInfoMessage()
        {
        }
        
        public QuestStepInfoMessage(Types.QuestActiveInformations infos)
        {
            this.infos = infos;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteShort(infos.TypeId);
            infos.Serialize(writer);
        }
        
        public override void Deserialize(IReader reader)
        {
            infos = ProtocolTypeManager.GetInstance<Types.QuestActiveInformations>(reader.ReadUShort());
            infos.Deserialize(reader);
        }
        
    }
    
}