//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Authorized
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class AdminCommandMessage : Message
    {
        
        public const int ProtocolId = 76;
        
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
        
        public AdminCommandMessage(string content)
        {
            m_content = content;
        }
        
        public AdminCommandMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_content);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_content = reader.ReadUTF();
        }
    }
}
