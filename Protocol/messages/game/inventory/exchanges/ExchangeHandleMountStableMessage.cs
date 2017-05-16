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
    public class ExchangeHandleMountStableMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5965;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_actionType;
        
        public virtual byte ActionType
        {
            get
            {
                return m_actionType;
            }
            set
            {
                m_actionType = value;
            }
        }
        
        private uint m_rideId;
        
        public virtual uint RideId
        {
            get
            {
                return m_rideId;
            }
            set
            {
                m_rideId = value;
            }
        }
        
        public ExchangeHandleMountStableMessage(byte actionType, uint rideId)
        {
            m_actionType = actionType;
            m_rideId = rideId;
        }
        
        public ExchangeHandleMountStableMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_actionType);
            writer.WriteVarInt(m_rideId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_actionType = reader.ReadByte();
            m_rideId = reader.ReadVarUhInt();
        }
    }
}
