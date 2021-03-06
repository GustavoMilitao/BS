//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Mount
{
    using BlueSheep.Common;


    public class PaddockSellRequestMessage : Message
    {
        
        public const int ProtocolId = 5953;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_price;
        
        public virtual ulong Price
        {
            get
            {
                return m_price;
            }
            set
            {
                m_price = value;
            }
        }
        
        private bool m_forSale;
        
        public virtual bool ForSale
        {
            get
            {
                return m_forSale;
            }
            set
            {
                m_forSale = value;
            }
        }
        
        public PaddockSellRequestMessage(ulong price, bool forSale)
        {
            m_price = price;
            m_forSale = forSale;
        }
        
        public PaddockSellRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_price);
            writer.WriteBoolean(m_forSale);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_price = reader.ReadVarUhLong();
            m_forSale = reader.ReadBoolean();
        }
    }
}
