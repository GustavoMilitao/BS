//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Inventory.Exchanges
{
    public class ExchangeMountPaddockRemoveMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6050;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_mountId;
        
        public virtual double MountId
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
        
        public ExchangeMountPaddockRemoveMessage(double mountId)
        {
            m_mountId = mountId;
        }
        
        public ExchangeMountPaddockRemoveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_mountId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mountId = reader.ReadDouble();
        }
    }
}
