//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Dare
{
    public class DareInformationsRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6659;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        public DareInformationsRequestMessage(double dareId)
        {
            m_dareId = dareId;
        }
        
        public DareInformationsRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_dareId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dareId = reader.ReadDouble();
        }
    }
}
