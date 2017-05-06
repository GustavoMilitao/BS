//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    public class MapCoordinates 
    {
        
        public new const int ID = 174;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private short m_worldX;
        
        public virtual short WorldX
        {
            get
            {
                return m_worldX;
            }
            set
            {
                m_worldX = value;
            }
        }
        
        private short m_worldY;
        
        public virtual short WorldY
        {
            get
            {
                return m_worldY;
            }
            set
            {
                m_worldY = value;
            }
        }
        
        public MapCoordinates(short worldX, short worldY)
        {
            m_worldX = worldX;
            m_worldY = worldY;
        }
        
        public MapCoordinates()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
        }
        
        public void Deserialize(IDataReader reader)
        {
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
        }
    }
}
