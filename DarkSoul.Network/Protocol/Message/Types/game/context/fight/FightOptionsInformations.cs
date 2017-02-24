

// Generated on 02/23/2017 18:06:39
using System;
using System.Collections.Generic;
using System.Linq;
using DarkSoul.Core.Interfaces;
using DarkSoul.Core.IO;

namespace DarkSoul.Network.Protocol.Types
{
    public class FightOptionsInformations
    {
        public virtual short TypeId => 20;
        
        public bool isSecret;
        public bool isRestrictedToPartyOnly;
        public bool isClosed;
        public bool isAskingForHelp;
        
        public FightOptionsInformations()
        {
        }
        
        public FightOptionsInformations(bool isSecret, bool isRestrictedToPartyOnly, bool isClosed, bool isAskingForHelp)
        {
            this.isSecret = isSecret;
            this.isRestrictedToPartyOnly = isRestrictedToPartyOnly;
            this.isClosed = isClosed;
            this.isAskingForHelp = isAskingForHelp;
        }
        
        public virtual void Serialize(IWriter writer)
        {
            byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isSecret);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, isRestrictedToPartyOnly);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, isClosed);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 3, isAskingForHelp);
            writer.WriteByte(flag1);
        }
        
        public virtual void Deserialize(IReader reader)
        {
            byte flag1 = reader.ReadByte();
            isSecret = BooleanByteWrapper.GetFlag(flag1, 0);
            isRestrictedToPartyOnly = BooleanByteWrapper.GetFlag(flag1, 1);
            isClosed = BooleanByteWrapper.GetFlag(flag1, 2);
            isAskingForHelp = BooleanByteWrapper.GetFlag(flag1, 3);
        }
        
    }
    
}