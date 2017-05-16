//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Connection
{


    public class IdentificationFailedBannedMessage : IdentificationFailedMessage
    {
        
        protected override int ProtocolId { get; set; } = 6174;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_banEndDate;
        
        public virtual double BanEndDate
        {
            get
            {
                return m_banEndDate;
            }
            set
            {
                m_banEndDate = value;
            }
        }
        
        public IdentificationFailedBannedMessage(double banEndDate)
        {
            m_banEndDate = banEndDate;
        }
        
        public IdentificationFailedBannedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_banEndDate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_banEndDate = reader.ReadDouble();
        }
    }
}
