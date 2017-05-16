//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;


    public class ExchangeBidPriceForSellerMessage : ExchangeBidPriceMessage
    {
        
        protected override int ProtocolId { get; set; } = 6464;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt64> m_minimalPrices;
        
        public virtual List<System.UInt64> MinimalPrices
        {
            get
            {
                return m_minimalPrices;
            }
            set
            {
                m_minimalPrices = value;
            }
        }
        
        private bool m_allIdentical;
        
        public virtual bool AllIdentical
        {
            get
            {
                return m_allIdentical;
            }
            set
            {
                m_allIdentical = value;
            }
        }
        
        public ExchangeBidPriceForSellerMessage(List<System.UInt64> minimalPrices, bool allIdentical)
        {
            m_minimalPrices = minimalPrices;
            m_allIdentical = allIdentical;
        }
        
        public ExchangeBidPriceForSellerMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_minimalPrices.Count)));
            int minimalPricesIndex;
            for (minimalPricesIndex = 0; (minimalPricesIndex < m_minimalPrices.Count); minimalPricesIndex = (minimalPricesIndex + 1))
            {
                writer.WriteVarLong(m_minimalPrices[minimalPricesIndex]);
            }
            writer.WriteBoolean(m_allIdentical);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int minimalPricesCount = reader.ReadUShort();
            int minimalPricesIndex;
            m_minimalPrices = new System.Collections.Generic.List<ulong>();
            for (minimalPricesIndex = 0; (minimalPricesIndex < minimalPricesCount); minimalPricesIndex = (minimalPricesIndex + 1))
            {
                m_minimalPrices.Add(reader.ReadVarUhLong());
            }
            m_allIdentical = reader.ReadBoolean();
        }
    }
}
