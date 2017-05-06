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

 	 public class ExchangeObjectMovePricedMessage : ExchangeObjectMoveMessage 
    {
        
        public new const int ID = 5514;
        
        public override int MessageID
        {
            get
            {
                return ID;
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
        
        public ExchangeObjectMovePricedMessage(ulong price)
        {
            m_price = price;
        }

        public ExchangeObjectMovePricedMessage(uint objectUID, int quantity, ulong price)
         : base(objectUID, quantity)
        {
            this.Price = price;
        }

        public ExchangeObjectMovePricedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(m_price);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_price = reader.ReadVarUhLong();
        }
    }
}
