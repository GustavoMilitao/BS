//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Mount
{
    public class MountRidingMessage : Message
    {
        
        public override int ProtocolId { get; } = 5967;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_isRiding;
        
        public virtual bool IsRiding
        {
            get
            {
                return m_isRiding;
            }
            set
            {
                m_isRiding = value;
            }
        }
        
        public MountRidingMessage(bool isRiding)
        {
            m_isRiding = isRiding;
        }
        
        public MountRidingMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_isRiding);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_isRiding = reader.ReadBoolean();
        }
    }
}
