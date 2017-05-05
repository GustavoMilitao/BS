









// Generated on 12/11/2014 19:01:16
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionFightCastRequestMessage : Message
    {
        public new const uint ID =1005;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int spellId;
        public int cellId;
        
        public GameActionFightCastRequestMessage()
        {
        }
        
        public GameActionFightCastRequestMessage(int spellId, int cellId)
        {
            this.spellId = spellId;
            this.cellId = cellId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort((short)spellId);
            writer.WriteShort((short)cellId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
        }
        
    }
    
}