//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Tinsel
{
    public class TitleSelectedMessage : Message
    {
        
        public override int ProtocolId { get; } = 6366;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_titleId;
        
        public virtual ushort TitleId
        {
            get
            {
                return m_titleId;
            }
            set
            {
                m_titleId = value;
            }
        }
        
        public TitleSelectedMessage(ushort titleId)
        {
            m_titleId = titleId;
        }
        
        public TitleSelectedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_titleId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_titleId = reader.ReadVarUhShort();
        }
    }
}
