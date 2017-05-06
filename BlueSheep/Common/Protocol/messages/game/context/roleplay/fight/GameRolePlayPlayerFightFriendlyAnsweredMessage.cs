//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Fight
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameRolePlayPlayerFightFriendlyAnsweredMessage : Message
    {
        
        public const int ProtocolId = 5733;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_fightId;
        
        public virtual int FightId
        {
            get
            {
                return m_fightId;
            }
            set
            {
                m_fightId = value;
            }
        }
        
        private ulong m_sourceId;
        
        public virtual ulong SourceId
        {
            get
            {
                return m_sourceId;
            }
            set
            {
                m_sourceId = value;
            }
        }
        
        private ulong m_targetId;
        
        public virtual ulong TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private bool m_accept;
        
        public virtual bool Accept
        {
            get
            {
                return m_accept;
            }
            set
            {
                m_accept = value;
            }
        }
        
        public GameRolePlayPlayerFightFriendlyAnsweredMessage(int fightId, ulong sourceId, ulong targetId, bool accept)
        {
            m_fightId = fightId;
            m_sourceId = sourceId;
            m_targetId = targetId;
            m_accept = accept;
        }
        
        public GameRolePlayPlayerFightFriendlyAnsweredMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_fightId);
            writer.WriteVarLong(m_sourceId);
            writer.WriteVarLong(m_targetId);
            writer.WriteBoolean(m_accept);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightId = reader.ReadInt();
            m_sourceId = reader.ReadVarUhLong();
            m_targetId = reader.ReadVarUhLong();
            m_accept = reader.ReadBoolean();
        }
    }
}
