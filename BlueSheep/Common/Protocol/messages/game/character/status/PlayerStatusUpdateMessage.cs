//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Character.Status
{
    using BlueSheep.Common.Protocol.Types.Game.Character.Status;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class PlayerStatusUpdateMessage : Message 
    {
        
        public new const int ID = 6386;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private PlayerStatus m_status;
        
        public virtual PlayerStatus Status
        {
            get
            {
                return m_status;
            }
            set
            {
                m_status = value;
            }
        }
        
        private int m_accountId;
        
        public virtual int AccountId
        {
            get
            {
                return m_accountId;
            }
            set
            {
                m_accountId = value;
            }
        }
        
        private ulong m_playerId;
        
        public virtual ulong PlayerId
        {
            get
            {
                return m_playerId;
            }
            set
            {
                m_playerId = value;
            }
        }
        
        public PlayerStatusUpdateMessage(PlayerStatus status, int accountId, ulong playerId)
        {
            m_status = status;
            m_accountId = accountId;
            m_playerId = playerId;
        }
        
        public PlayerStatusUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_status.TypeID)));
            m_status.Serialize(writer);
            writer.WriteInt(m_accountId);
            writer.WriteVarLong(m_playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
            m_status.Deserialize(reader);
            m_accountId = reader.ReadInt();
            m_playerId = reader.ReadVarUhLong();
        }
    }
}
