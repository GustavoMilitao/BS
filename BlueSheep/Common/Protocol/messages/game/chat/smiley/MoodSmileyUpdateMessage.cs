//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Chat.Smiley
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class MoodSmileyUpdateMessage : Message 
    {
        
        public new const int ID = 6388;
        
        public override int MessageID
        {
            get
            {
                return ID;
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
        
        private ushort m_smileyId;
        
        public virtual ushort SmileyId
        {
            get
            {
                return m_smileyId;
            }
            set
            {
                m_smileyId = value;
            }
        }
        
        public MoodSmileyUpdateMessage(int accountId, ulong playerId, ushort smileyId)
        {
            m_accountId = accountId;
            m_playerId = playerId;
            m_smileyId = smileyId;
        }
        
        public MoodSmileyUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_accountId);
            writer.WriteVarLong(m_playerId);
            writer.WriteVarShort(m_smileyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_accountId = reader.ReadInt();
            m_playerId = reader.ReadVarUhLong();
            m_smileyId = reader.ReadVarUhShort();
        }
    }
}
