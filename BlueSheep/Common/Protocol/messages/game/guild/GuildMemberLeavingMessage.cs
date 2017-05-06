//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GuildMemberLeavingMessage : Message
    {
        
        public const int ProtocolId = 5923;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_kicked;
        
        public virtual bool Kicked
        {
            get
            {
                return m_kicked;
            }
            set
            {
                m_kicked = value;
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
        
        public GuildMemberLeavingMessage(bool kicked, ulong memberId)
        {
            m_kicked = kicked;
            m_memberId = memberId;
        }
        
        public GuildMemberLeavingMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_kicked);
            writer.WriteVarLong(m_memberId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_kicked = reader.ReadBoolean();
            m_memberId = reader.ReadVarUhLong();
        }
    }
}
