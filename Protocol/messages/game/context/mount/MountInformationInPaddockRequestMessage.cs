//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Mount
{
    public class MountInformationInPaddockRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5975;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_mapRideId;
        
        public virtual int MapRideId
        {
            get
            {
                return m_mapRideId;
            }
            set
            {
                m_mapRideId = value;
            }
        }
        
        public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            m_mapRideId = mapRideId;
        }
        
        public MountInformationInPaddockRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_mapRideId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mapRideId = reader.ReadVarInt();
        }
    }
}
