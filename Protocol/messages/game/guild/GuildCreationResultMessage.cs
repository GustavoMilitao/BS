//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Guild
{
    public class GuildCreationResultMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5554;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_result;
        
        public virtual byte Result
        {
            get
            {
                return m_result;
            }
            set
            {
                m_result = value;
            }
        }
        
        public GuildCreationResultMessage(byte result)
        {
            m_result = result;
        }
        
        public GuildCreationResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_result = reader.ReadByte();
        }
    }
}
