//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Quest
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class QuestStepStartedMessage : Message
    {
        
        public const int ProtocolId = 6096;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_questId;
        
        public virtual ushort QuestId
        {
            get
            {
                return m_questId;
            }
            set
            {
                m_questId = value;
            }
        }
        
        private ushort m_stepId;
        
        public virtual ushort StepId
        {
            get
            {
                return m_stepId;
            }
            set
            {
                m_stepId = value;
            }
        }
        
        public QuestStepStartedMessage(ushort questId, ushort stepId)
        {
            m_questId = questId;
            m_stepId = stepId;
        }
        
        public QuestStepStartedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_questId);
            writer.WriteVarShort(m_stepId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_questId = reader.ReadVarUhShort();
            m_stepId = reader.ReadVarUhShort();
        }
    }
}
