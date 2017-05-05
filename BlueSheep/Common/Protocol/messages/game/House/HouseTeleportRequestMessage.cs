//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DofusBot.Protocol.Network.Messages.Game.House
{
    using System.Collections.Generic;
    using DofusBot.Protocol.Network.Messages;
    using DofusBot.Protocol.Network.Types;
    using DofusBot.Protocol;
    
    
    public class HouseTeleportRequestMessage : NetworkMessage
    {
        
        public const int ProtocolId = 6726;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_houseId;
        
        public virtual uint HouseId
        {
            get
            {
                return m_houseId;
            }
            set
            {
                m_houseId = value;
            }
        }
        
        private int m_houseInstanceId;
        
        public virtual int HouseInstanceId
        {
            get
            {
                return m_houseInstanceId;
            }
            set
            {
                m_houseInstanceId = value;
            }
        }
        
        public HouseTeleportRequestMessage(uint houseId, int houseInstanceId)
        {
            m_houseId = houseId;
            m_houseInstanceId = houseInstanceId;
        }
        
        public HouseTeleportRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarUhInt(m_houseId);
            writer.WriteInt(m_houseInstanceId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_houseId = reader.ReadVarUhInt();
            m_houseInstanceId = reader.ReadInt();
        }
    }
}
