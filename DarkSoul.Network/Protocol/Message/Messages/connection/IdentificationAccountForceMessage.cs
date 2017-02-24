

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
    public class IdentificationAccountForceMessage : IdentificationMessage
    {
        public override ushort Id => 6119;
        
        
        public string forcedAccountLogin;
        
        public IdentificationAccountForceMessage()
        {
        }
        
        public IdentificationAccountForceMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.VersionExtended version, string lang, IEnumerable<sbyte> credentials, short serverId, double sessionOptionalSalt, IEnumerable<ushort> failedAttempts, string forcedAccountLogin)
         : base(autoconnect, useCertificate, useLoginToken, version, lang, credentials, serverId, sessionOptionalSalt, failedAttempts)
        {
            this.forcedAccountLogin = forcedAccountLogin;
        }
        
        public override void Serialize(IWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(forcedAccountLogin);
        }
        
        public override void Deserialize(IReader reader)
        {
            base.Deserialize(reader);
            forcedAccountLogin = reader.ReadUTF();
        }
        
    }
    
}