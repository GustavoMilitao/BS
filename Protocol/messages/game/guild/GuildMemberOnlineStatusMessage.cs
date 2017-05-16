//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Guild
{
    public class GuildMemberOnlineStatusMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6061;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_memberId;
        
        public virtual ulong MemberId
        {
            get
            {
                return m_memberId;
            }
            set
            {
                m_memberId = value;
            }
        }
        
        private bool m_online;
        
        public virtual bool Online
        {
            get
            {
                return m_online;
            }
            set
            {
                m_online = value;
            }
        }
        
        public GuildMemberOnlineStatusMessage(ulong memberId, bool online)
        {
            m_memberId = memberId;
            m_online = online;
        }
        
        public GuildMemberOnlineStatusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_memberId);
            writer.WriteBoolean(m_online);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_memberId = reader.ReadVarUhLong();
            m_online = reader.ReadBoolean();
        }
    }
}
