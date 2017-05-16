//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Alliance
{
    using BlueSheep.Protocol.Messages.Game.Social;


    public class AllianceBulletinSetRequestMessage : SocialNoticeSetRequestMessage
    {
        
        protected override int ProtocolId { get; set; } = 6693;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_content;
        
        public virtual string Content
        {
            get
            {
                return m_content;
            }
            set
            {
                m_content = value;
            }
        }
        
        private bool m_notifyMembers;
        
        public virtual bool NotifyMembers
        {
            get
            {
                return m_notifyMembers;
            }
            set
            {
                m_notifyMembers = value;
            }
        }
        
        public AllianceBulletinSetRequestMessage(string content, bool notifyMembers)
        {
            m_content = content;
            m_notifyMembers = notifyMembers;
        }
        
        public AllianceBulletinSetRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_content);
            writer.WriteBoolean(m_notifyMembers);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_content = reader.ReadUTF();
            m_notifyMembers = reader.ReadBoolean();
        }
    }
}
