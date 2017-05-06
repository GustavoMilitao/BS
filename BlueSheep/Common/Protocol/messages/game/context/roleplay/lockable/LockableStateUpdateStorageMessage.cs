//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class LockableStateUpdateStorageMessage : LockableStateUpdateAbstractMessage 
    {
        
        public new const int ID = 5669;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private int m_mapId;
        
        public virtual int MapId
        {
            get
            {
                return m_mapId;
            }
            set
            {
                m_mapId = value;
            }
        }
        
        private uint m_elementId;
        
        public virtual uint ElementId
        {
            get
            {
                return m_elementId;
            }
            set
            {
                m_elementId = value;
            }
        }
        
        public LockableStateUpdateStorageMessage(int mapId, uint elementId)
        {
            m_mapId = mapId;
            m_elementId = elementId;
        }
        
        public LockableStateUpdateStorageMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_mapId);
            writer.WriteVarInt(m_elementId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_mapId = reader.ReadInt();
            m_elementId = reader.ReadVarUhInt();
        }
    }
}
