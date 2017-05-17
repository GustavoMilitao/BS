//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Exchanges
{
    using BlueSheep.Common;


    public class ExchangeBidPriceMessage : Message
    {
        
        public const int ProtocolId = 5755;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_genericId;
        
        public virtual ushort GenericId
        {
            get
            {
                return m_genericId;
            }
            set
            {
                m_genericId = value;
            }
        }
        
        private long m_averagePrice;
        
        public virtual long AveragePrice
        {
            get
            {
                return m_averagePrice;
            }
            set
            {
                m_averagePrice = value;
            }
        }
        
        public ExchangeBidPriceMessage(ushort genericId, long averagePrice)
        {
            m_genericId = genericId;
            m_averagePrice = averagePrice;
        }
        
        public ExchangeBidPriceMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_genericId);
            writer.WriteVarLong(m_averagePrice);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_genericId = reader.ReadVarUhShort();
            m_averagePrice = reader.ReadVarLong();
        }
    }
}