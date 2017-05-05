









// Generated on 12/11/2014 19:01:16
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionFightCastOnTargetRequestMessage : Message
    {
        public new const uint ID =6330;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int spellId;
        public ulong targetId;
        
        public GameActionFightCastOnTargetRequestMessage()
        {
        }
        
        public GameActionFightCastOnTargetRequestMessage(int spellId, ulong targetId)
        {
            this.spellId = spellId;
            this.targetId = targetId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort((short)spellId);
            writer.WriteULong(targetId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            targetId = reader.ReadULong();
        }
        
    }
    
}