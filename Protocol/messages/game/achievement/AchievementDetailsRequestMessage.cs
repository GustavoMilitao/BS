//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Achievement
{
    public class AchievementDetailsRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6380;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_achievementId;
        
        public virtual ushort AchievementId
        {
            get
            {
                return m_achievementId;
            }
            set
            {
                m_achievementId = value;
            }
        }
        
        public AchievementDetailsRequestMessage(ushort achievementId)
        {
            m_achievementId = achievementId;
        }
        
        public AchievementDetailsRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_achievementId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_achievementId = reader.ReadVarUhShort();
        }
    }
}
