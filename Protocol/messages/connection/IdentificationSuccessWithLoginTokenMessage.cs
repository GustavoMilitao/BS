//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Connection
{


    public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
    {
        
        public override int ProtocolId { get; } = 6209;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_loginToken;
        
        public virtual string LoginToken
        {
            get
            {
                return m_loginToken;
            }
            set
            {
                m_loginToken = value;
            }
        }
        
        public IdentificationSuccessWithLoginTokenMessage(string loginToken)
        {
            m_loginToken = loginToken;
        }
        
        public IdentificationSuccessWithLoginTokenMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_loginToken);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_loginToken = reader.ReadUTF();
        }
    }
}
