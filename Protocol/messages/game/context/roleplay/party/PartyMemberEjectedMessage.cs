//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.Party
{


    public class PartyMemberEjectedMessage : PartyMemberRemoveMessage
    {
        
        public override int ProtocolId { get; } = 6252;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_kickerId;
        
        public virtual ulong KickerId
        {
            get
            {
                return m_kickerId;
            }
            set
            {
                m_kickerId = value;
            }
        }
        
        public PartyMemberEjectedMessage(ulong kickerId)
        {
            m_kickerId = kickerId;
        }
        
        public PartyMemberEjectedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(m_kickerId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_kickerId = reader.ReadVarUhLong();
        }
    }
}
