









// Generated on 12/11/2014 19:01:17
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionFightInvisibleDetectedMessage : AbstractGameActionMessage
    {
        public new const uint ID =6320;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public ulong targetId;
        public int cellId;
        
        public GameActionFightInvisibleDetectedMessage()
        {
        }
        
        public GameActionFightInvisibleDetectedMessage(int actionId, ulong sourceId, ulong targetId, int cellId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.cellId = cellId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteULong(targetId);
            writer.WriteShort((short)cellId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadULong();
            cellId = reader.ReadShort();
            if (cellId < -1 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < -1 || cellId > 559");
        }
        
    }
    
}