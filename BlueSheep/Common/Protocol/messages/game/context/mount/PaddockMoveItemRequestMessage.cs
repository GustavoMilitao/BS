









// Generated on 12/11/2014 19:01:30
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class PaddockMoveItemRequestMessage : Message
    {
        public new const uint ID =6052;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int oldCellId;
        public int newCellId;
        
        public PaddockMoveItemRequestMessage()
        {
        }
        
        public PaddockMoveItemRequestMessage(int oldCellId, int newCellId)
        {
            this.oldCellId = oldCellId;
            this.newCellId = newCellId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort((short)oldCellId);
            writer.WriteVarShort((short)newCellId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            oldCellId = reader.ReadVarUhShort();
            if (oldCellId < 0 || oldCellId > 559)
                throw new Exception("Forbidden value on oldCellId = " + oldCellId + ", it doesn't respect the following condition : oldCellId < 0 || oldCellId > 559");
            newCellId = reader.ReadVarUhShort();
            if (newCellId < 0 || newCellId > 559)
                throw new Exception("Forbidden value on newCellId = " + newCellId + ", it doesn't respect the following condition : newCellId < 0 || newCellId > 559");
        }
        
    }
    
}