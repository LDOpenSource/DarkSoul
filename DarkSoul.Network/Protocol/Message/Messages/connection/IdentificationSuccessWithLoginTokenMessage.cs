

// Generated on 02/23/2017 16:53:16
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Network.Protocol.Types;
using DarkSoul.Network.Protocol.Message;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Messages
{
    public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
    {
        public override ushort Id => 6209;
        
        
        public string loginToken;
        
        public IdentificationSuccessWithLoginTokenMessage()
        {
        }
        
        public IdentificationSuccessWithLoginTokenMessage(bool hasRights, bool wasAlreadyConnected, string login, string nickname, int accountId, sbyte communityId, string secretQuestion, double accountCreation, double subscriptionElapsedDuration, double subscriptionEndDate, byte havenbagAvailableRoom, string loginToken)
         : base(hasRights, wasAlreadyConnected, login, nickname, accountId, communityId, secretQuestion, accountCreation, subscriptionElapsedDuration, subscriptionEndDate, havenbagAvailableRoom)
        {
            this.loginToken = loginToken;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(loginToken);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            loginToken = reader.ReadUTF();
        }
        
    }
    
}