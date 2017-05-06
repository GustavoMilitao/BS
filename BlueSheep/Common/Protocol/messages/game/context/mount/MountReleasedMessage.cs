//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Mount
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class MountReleasedMessage : Message
    {
        
        public const int ProtocolId = 6308;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_mountId;
        
        public virtual int MountId
        {
            get
            {
                return m_mountId;
            }
            set
            {
                m_mountId = value;
            }
        }
        
        public MountReleasedMessage(int mountId)
        {
            m_mountId = mountId;
        }
        
        public MountReleasedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_mountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mountId = reader.ReadVarInt();
        }
    }
}
