//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Exchanges
{
    public class ExchangeBidHouseTypeMessage : Message
    {
        
        public override int ProtocolId { get; } = 5803;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_type;
        
        public virtual uint Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        
        public ExchangeBidHouseTypeMessage(uint type)
        {
            m_type = type;
        }
        
        public ExchangeBidHouseTypeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_type = reader.ReadVarUhInt();
        }
    }
}
