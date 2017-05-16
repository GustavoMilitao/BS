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
    public class ExchangeOkMultiCraftMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5768;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_initiatorId;
        
        public virtual ulong InitiatorId
        {
            get
            {
                return m_initiatorId;
            }
            set
            {
                m_initiatorId = value;
            }
        }
        
        private ulong m_otherId;
        
        public virtual ulong OtherId
        {
            get
            {
                return m_otherId;
            }
            set
            {
                m_otherId = value;
            }
        }
        
        private byte m_role;
        
        public virtual byte Role
        {
            get
            {
                return m_role;
            }
            set
            {
                m_role = value;
            }
        }
        
        public ExchangeOkMultiCraftMessage(ulong initiatorId, ulong otherId, byte role)
        {
            m_initiatorId = initiatorId;
            m_otherId = otherId;
            m_role = role;
        }
        
        public ExchangeOkMultiCraftMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_initiatorId);
            writer.WriteVarLong(m_otherId);
            writer.WriteByte(m_role);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_initiatorId = reader.ReadVarUhLong();
            m_otherId = reader.ReadVarUhLong();
            m_role = reader.ReadByte();
        }
    }
}
