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
	using BlueSheep.Common.Protocol.Types;


    public class ExchangeBidHousePriceMessage : Message
    {
        
        public const int ProtocolId = 5805;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_genId;
        
        public virtual ushort GenId
        {
            get
            {
                return m_genId;
            }
            set
            {
                m_genId = value;
            }
        }
        
        public ExchangeBidHousePriceMessage(ushort genId)
        {
            m_genId = genId;
        }
        
        public ExchangeBidHousePriceMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_genId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_genId = reader.ReadVarUhShort();
        }
    }
}
