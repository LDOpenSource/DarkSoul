

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
    public class IdentificationMessage : NetworkMessage
    {
        public override ushort Id => 4;
        
        
        public bool autoconnect;
        public bool useCertificate;
        public bool useLoginToken;
        public Types.VersionExtended version;
        public string lang;
        public IEnumerable<sbyte> credentials;
        public short serverId;
        public double sessionOptionalSalt;
        public IEnumerable<ushort> failedAttempts;
        
        public IdentificationMessage()
        {
        }
        
        public IdentificationMessage(bool autoconnect, bool useCertificate, bool useLoginToken, Types.VersionExtended version, string lang, IEnumerable<sbyte> credentials, short serverId, double sessionOptionalSalt, IEnumerable<ushort> failedAttempts)
        {
            this.autoconnect = autoconnect;
            this.useCertificate = useCertificate;
            this.useLoginToken = useLoginToken;
            this.version = version;
            this.lang = lang;
            this.credentials = credentials;
            this.serverId = serverId;
            this.sessionOptionalSalt = sessionOptionalSalt;
            this.failedAttempts = failedAttempts;
        }
        
        public override void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, autoconnect);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, useCertificate);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, useLoginToken);
            writer.WriteByte(flag1);
            version.Serialize(writer);
            writer.WriteUTF(lang);
            writer.WriteVarInt((int)credentials.Count());
            foreach (var entry in credentials)
            {
                 writer.WriteSByte(entry);
            }
            writer.WriteShort(serverId);
            writer.WriteVarLong(sessionOptionalSalt);
            writer.WriteShort((short)failedAttempts.Count());
            foreach (var entry in failedAttempts)
            {
                 writer.WriteVarShort((int)entry);
            }
        }
        
        public override void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            autoconnect = BooleanByteWrapper.GetFlag(flag1, 0);
            useCertificate = BooleanByteWrapper.GetFlag(flag1, 1);
            useLoginToken = BooleanByteWrapper.GetFlag(flag1, 2);
            version = new Types.VersionExtended();
            version.Deserialize(reader);
            lang = reader.ReadUTF();
            var limit = reader.ReadVarInt();
            credentials = new sbyte[limit];
            for (int i = 0; i < limit; i++)
            {
                 (credentials as sbyte[])[i] = reader.ReadSByte();
            }
            serverId = reader.ReadShort();
            sessionOptionalSalt = reader.ReadVarLong();
            limit = reader.ReadUShort();
            failedAttempts = new ushort[limit];
            for (int i = 0; i < limit; i++)
            {
                 (failedAttempts as ushort[])[i] = reader.ReadVarUhShort();
            }
        }
        
    }
    
}