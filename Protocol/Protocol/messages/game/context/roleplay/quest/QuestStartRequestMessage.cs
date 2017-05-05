









// Generated on 12/11/2014 19:01:40
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class QuestStartRequestMessage : Message
    {
        public new const uint ID =5643;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public short questId;
        
        public QuestStartRequestMessage()
        {
        }
        
        public QuestStartRequestMessage(short questId)
        {
            this.questId = questId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort(questId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            questId = reader.ReadVarShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
        }
        
    }
    
}