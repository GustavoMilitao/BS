//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Prism
{
    public class PrismInfoJoinLeaveRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5844;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_join;
        
        public virtual bool Join
        {
            get
            {
                return m_join;
            }
            set
            {
                m_join = value;
            }
        }
        
        public PrismInfoJoinLeaveRequestMessage(bool join)
        {
            m_join = join;
        }
        
        public PrismInfoJoinLeaveRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_join);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_join = reader.ReadBoolean();
        }
    }
}
