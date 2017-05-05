









// Generated on 12/11/2014 19:01:40
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class QuestStartRequestMessage : Message
    {
        public new const uint ID =5643;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int questId;
        
        public QuestStartRequestMessage()
        {
        }
        
        public QuestStartRequestMessage(int questId)
        {
            this.questId = questId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort((short)questId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            questId = reader.ReadVarUhShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
        }
        
    }
    
}