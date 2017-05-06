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
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class ExchangeItemGoldAddAsPaymentMessage : Message 
    {
        
        public new const int ID = 5770;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_paymentType;
        
        public virtual byte PaymentType
        {
            get
            {
                return m_paymentType;
            }
            set
            {
                m_paymentType = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ExchangeItemGoldAddAsPaymentMessage(byte paymentType, uint quantity)
        {
            m_paymentType = paymentType;
            m_quantity = quantity;
        }
        
        public ExchangeItemGoldAddAsPaymentMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_paymentType);
            writer.WriteVarInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_paymentType = reader.ReadByte();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
