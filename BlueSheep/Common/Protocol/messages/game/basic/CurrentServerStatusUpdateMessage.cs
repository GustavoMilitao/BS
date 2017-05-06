//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Basic
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class CurrentServerStatusUpdateMessage : Message
    {
        
        public const int ProtocolId = 6525;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_status;
        
        public virtual byte Status
        {
            get
            {
                return m_status;
            }
            set
            {
                m_status = value;
            }
        }
        
        public CurrentServerStatusUpdateMessage(byte status)
        {
            m_status = status;
        }
        
        public CurrentServerStatusUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_status);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_status = reader.ReadByte();
        }
    }
}
