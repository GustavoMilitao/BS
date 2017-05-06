//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Tinsel
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class TitleLostMessage : Message
    {
        
        public const int ProtocolId = 6371;
        
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
        
        public TitleLostMessage(ushort titleId)
        {
            m_titleId = titleId;
        }
        
        public TitleLostMessage()
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
