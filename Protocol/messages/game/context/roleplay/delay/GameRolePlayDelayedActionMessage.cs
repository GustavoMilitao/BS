//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Delay
{
    public class GameRolePlayDelayedActionMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6153;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_delayedCharacterId;
        
        public virtual double DelayedCharacterId
        {
            get
            {
                return m_delayedCharacterId;
            }
            set
            {
                m_delayedCharacterId = value;
            }
        }
        
        private byte m_delayTypeId;
        
        public virtual byte DelayTypeId
        {
            get
            {
                return m_delayTypeId;
            }
            set
            {
                m_delayTypeId = value;
            }
        }
        
        private double m_delayEndTime;
        
        public virtual double DelayEndTime
        {
            get
            {
                return m_delayEndTime;
            }
            set
            {
                m_delayEndTime = value;
            }
        }
        
        public GameRolePlayDelayedActionMessage(double delayedCharacterId, byte delayTypeId, double delayEndTime)
        {
            m_delayedCharacterId = delayedCharacterId;
            m_delayTypeId = delayTypeId;
            m_delayEndTime = delayEndTime;
        }
        
        public GameRolePlayDelayedActionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_delayedCharacterId);
            writer.WriteByte(m_delayTypeId);
            writer.WriteDouble(m_delayEndTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_delayedCharacterId = reader.ReadDouble();
            m_delayTypeId = reader.ReadByte();
            m_delayEndTime = reader.ReadDouble();
        }
    }
}
