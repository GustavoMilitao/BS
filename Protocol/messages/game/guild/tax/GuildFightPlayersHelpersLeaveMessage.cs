//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Guild.Tax
{
    public class GuildFightPlayersHelpersLeaveMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5719;
        
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
        
        public GuildFightPlayersHelpersLeaveMessage(int fightId, ulong playerId)
        {
            m_fightId = fightId;
            m_playerId = playerId;
        }
        
        public GuildFightPlayersHelpersLeaveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_fightId);
            writer.WriteVarLong(m_playerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightId = reader.ReadInt();
            m_playerId = reader.ReadVarUhLong();
        }
    }
}
