//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Connection.Register
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class NicknameChoiceRequestMessage : Message
    {
        
        public const int ProtocolId = 5639;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_nickname;
        
        public virtual string Nickname
        {
            get
            {
                return m_nickname;
            }
            set
            {
                m_nickname = value;
            }
        }
        
        public NicknameChoiceRequestMessage(string nickname)
        {
            m_nickname = nickname;
        }
        
        public NicknameChoiceRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_nickname);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_nickname = reader.ReadUTF();
        }
    }
}
