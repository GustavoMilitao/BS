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
    public class GuildInvitationMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5551;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        public GuildInvitationMessage(ulong targetId)
        {
            m_targetId = targetId;
        }
        
        public GuildInvitationMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_targetId = reader.ReadVarUhLong();
        }
    }
}
