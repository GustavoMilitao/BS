//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Notification
{
    using BlueSheep.Protocol;


    public class NotificationUpdateFlagMessage : Message
    {
        
        public const int ProtocolId = 6090;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_index;
        
        public virtual ushort Index
        {
            get
            {
                return m_index;
            }
            set
            {
                m_index = value;
            }
        }
        
        public NotificationUpdateFlagMessage(ushort index)
        {
            m_index = index;
        }
        
        public NotificationUpdateFlagMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_index);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_index = reader.ReadVarUhShort();
        }
    }
}