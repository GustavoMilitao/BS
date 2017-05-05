









// Generated on 12/11/2014 19:01:41
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class QuestStepValidatedMessage : Message
    {
        public new const uint ID =6099;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public short questId;
        public short stepId;
        
        public QuestStepValidatedMessage()
        {
        }
        
        public QuestStepValidatedMessage(short questId, short stepId)
        {
            this.questId = questId;
            this.stepId = stepId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort(questId);
            writer.WriteVarShort(stepId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            questId = reader.ReadVarShort();
            if (questId < 0)
                throw new Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            stepId = reader.ReadVarShort();
            if (stepId < 0)
                throw new Exception("Forbidden value on stepId = " + stepId + ", it doesn't respect the following condition : stepId < 0");
        }
        
    }
    
}