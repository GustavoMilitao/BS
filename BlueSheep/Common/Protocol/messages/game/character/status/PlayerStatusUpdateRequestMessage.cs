//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Character.Status
{
    using BlueSheep.Common.Protocol.Types.Game.Character.Status;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class PlayerStatusUpdateRequestMessage : Message
    {
        
        public const int ProtocolId = 6387;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PlayerStatus m_status;
        
        public virtual PlayerStatus Status
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
        
        public PlayerStatusUpdateRequestMessage(PlayerStatus status)
        {
            m_status = status;
        }
        
        public PlayerStatusUpdateRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_status.TypeID)));
            m_status.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
            m_status.Deserialize(reader);
        }
    }
}
