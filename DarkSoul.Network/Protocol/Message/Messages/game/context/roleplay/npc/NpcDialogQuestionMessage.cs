

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
    public class NpcDialogQuestionMessage : NetworkMessage
    {
        public override ushort Id => 5617;
        
        
        public ushort messageId;
        public IEnumerable<string> dialogParams;
        public IEnumerable<ushort> visibleReplies;
        
        public NpcDialogQuestionMessage()
        {
        }
        
        public NpcDialogQuestionMessage(ushort messageId, IEnumerable<string> dialogParams, IEnumerable<ushort> visibleReplies)
        {
            this.messageId = messageId;
            this.dialogParams = dialogParams;
            this.visibleReplies = visibleReplies;
        }
        
        public override void Serialize(IWriter writer)
        {
            writer.WriteVarShort((int)messageId);
            writer.WriteShort((short)dialogParams.Count());
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteShort((short)visibleReplies.Count());
            foreach (var entry in visibleReplies)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            messageId = reader.ReadVarUhShort();
            var limit = reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 (dialogParams as string[])[i] = reader.ReadUTF();
            }
            limit = reader.ReadUShort();
            visibleReplies = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (visibleReplies as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}