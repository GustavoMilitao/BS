//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Houses
{
    using BlueSheep.Common;


    public class HouseToSellListRequestMessage : Message
    {
        
        public const int ProtocolId = 6139;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_pageIndex;
        
        public virtual ushort PageIndex
        {
            get
            {
                return m_pageIndex;
            }
            set
            {
                m_pageIndex = value;
            }
        }
        
        public HouseToSellListRequestMessage(ushort pageIndex)
        {
            m_pageIndex = pageIndex;
        }
        
        public HouseToSellListRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_pageIndex);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_pageIndex = reader.ReadVarUhShort();
        }
    }
}