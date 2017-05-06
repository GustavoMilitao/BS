//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Mount
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    public class ItemDurability 
    {
        
        public new const int ID = 168;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private short m_durability;
        
        public virtual short Durability
        {
            get
            {
                return m_durability;
            }
            set
            {
                m_durability = value;
            }
        }
        
        private short m_durabilityMax;
        
        public virtual short DurabilityMax
        {
            get
            {
                return m_durabilityMax;
            }
            set
            {
                m_durabilityMax = value;
            }
        }
        
        public ItemDurability(short durability, short durabilityMax)
        {
            m_durability = durability;
            m_durabilityMax = durabilityMax;
        }
        
        public ItemDurability()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_durability);
            writer.WriteShort(m_durabilityMax);
        }
        
        public void Deserialize(IDataReader reader)
        {
            m_durability = reader.ReadShort();
            m_durabilityMax = reader.ReadShort();
        }
    }
}
