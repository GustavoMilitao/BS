//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameMapNoMovementMessage : Message 
    {
        
        public new const int ID = 954;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private short m_cellX;
        
        public virtual short CellX
        {
            get
            {
                return m_cellX;
            }
            set
            {
                m_cellX = value;
            }
        }
        
        private short m_cellY;
        
        public virtual short CellY
        {
            get
            {
                return m_cellY;
            }
            set
            {
                m_cellY = value;
            }
        }
        
        public GameMapNoMovementMessage(short cellX, short cellY)
        {
            m_cellX = cellX;
            m_cellY = cellY;
        }
        
        public GameMapNoMovementMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_cellX);
            writer.WriteShort(m_cellY);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_cellX = reader.ReadShort();
            m_cellY = reader.ReadShort();
        }
    }
}
