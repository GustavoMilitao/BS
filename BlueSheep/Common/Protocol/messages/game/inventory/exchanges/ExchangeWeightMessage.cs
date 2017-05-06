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

 	 public class ExchangeWeightMessage : Message 
    {
        
        public new const int ID = 5793;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private uint m_currentWeight;
        
        public virtual uint CurrentWeight
        {
            get
            {
                return m_currentWeight;
            }
            set
            {
                m_currentWeight = value;
            }
        }
        
        private uint m_maxWeight;
        
        public virtual uint MaxWeight
        {
            get
            {
                return m_maxWeight;
            }
            set
            {
                m_maxWeight = value;
            }
        }
        
        public ExchangeWeightMessage(uint currentWeight, uint maxWeight)
        {
            m_currentWeight = currentWeight;
            m_maxWeight = maxWeight;
        }
        
        public ExchangeWeightMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_currentWeight);
            writer.WriteVarInt(m_maxWeight);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_currentWeight = reader.ReadVarUhInt();
            m_maxWeight = reader.ReadVarUhInt();
        }
    }
}
