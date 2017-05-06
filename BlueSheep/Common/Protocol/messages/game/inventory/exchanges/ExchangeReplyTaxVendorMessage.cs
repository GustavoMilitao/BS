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

 	 public class ExchangeReplyTaxVendorMessage : Message 
    {
        
        public new const int ID = 5787;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private ulong m_objectValue;
        
        public virtual ulong ObjectValue
        {
            get
            {
                return m_objectValue;
            }
            set
            {
                m_objectValue = value;
            }
        }
        
        private ulong m_totalTaxValue;
        
        public virtual ulong TotalTaxValue
        {
            get
            {
                return m_totalTaxValue;
            }
            set
            {
                m_totalTaxValue = value;
            }
        }
        
        public ExchangeReplyTaxVendorMessage(ulong objectValue, ulong totalTaxValue)
        {
            m_objectValue = objectValue;
            m_totalTaxValue = totalTaxValue;
        }
        
        public ExchangeReplyTaxVendorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_objectValue);
            writer.WriteVarLong(m_totalTaxValue);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectValue = reader.ReadVarUhLong();
            m_totalTaxValue = reader.ReadVarUhLong();
        }
    }
}
