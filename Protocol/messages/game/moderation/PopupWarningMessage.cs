//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Moderation
{
    public class PopupWarningMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6134;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_lockDuration;
        
        public virtual sbyte LockDuration
        {
            get
            {
                return m_lockDuration;
            }
            set
            {
                m_lockDuration = value;
            }
        }
        
        private string m_author;
        
        public virtual string Author
        {
            get
            {
                return m_author;
            }
            set
            {
                m_author = value;
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
        
        public PopupWarningMessage(sbyte lockDuration, string author, string content)
        {
            m_lockDuration = lockDuration;
            m_author = author;
            m_content = content;
        }
        
        public PopupWarningMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(m_lockDuration);
            writer.WriteUTF(m_author);
            writer.WriteUTF(m_content);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_lockDuration = reader.ReadSByte();
            m_author = reader.ReadUTF();
            m_content = reader.ReadUTF();
        }
    }
}
