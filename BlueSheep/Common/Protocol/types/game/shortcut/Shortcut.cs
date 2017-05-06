//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Shortcut
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    public class Shortcut 
    {
        
        public new const int ID = 369;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_slot;
        
        public virtual byte Slot
        {
            get
            {
                return m_slot;
            }
            set
            {
                m_slot = value;
            }
        }
        
        public Shortcut(byte slot)
        {
            m_slot = slot;
        }
        
        public Shortcut()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_slot);
        }
        
        public void Deserialize(IDataReader reader)
        {
            m_slot = reader.ReadByte();
        }
    }
}
