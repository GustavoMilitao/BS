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
    using BlueSheep.Common.Protocol.Types.Game.Mount;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class MountDataMessage : Message
    {
        
        public const int ProtocolId = 5973;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private MountClientData m_mountData;
        
        public virtual MountClientData MountData
        {
            get
            {
                return m_mountData;
            }
            set
            {
                m_mountData = value;
            }
        }
        
        public MountDataMessage(MountClientData mountData)
        {
            m_mountData = mountData;
        }
        
        public MountDataMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_mountData.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mountData = new MountClientData();
            m_mountData.Deserialize(reader);
        }
    }
}
