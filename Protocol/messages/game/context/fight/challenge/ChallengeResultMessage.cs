//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Fight.Challenge
{
    public class ChallengeResultMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6019;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_challengeId;
        
        public virtual ushort ChallengeId
        {
            get
            {
                return m_challengeId;
            }
            set
            {
                m_challengeId = value;
            }
        }
        
        private bool m_success;
        
        public virtual bool Success
        {
            get
            {
                return m_success;
            }
            set
            {
                m_success = value;
            }
        }
        
        public ChallengeResultMessage(ushort challengeId, bool success)
        {
            m_challengeId = challengeId;
            m_success = success;
        }
        
        public ChallengeResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_challengeId);
            writer.WriteBoolean(m_success);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_challengeId = reader.ReadVarUhShort();
            m_success = reader.ReadBoolean();
        }
    }
}
