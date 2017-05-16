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
    public class GameRolePlayDelayedActionFinishedMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6150;
        
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
        
        public GameRolePlayDelayedActionFinishedMessage(double delayedCharacterId, byte delayTypeId)
        {
            m_delayedCharacterId = delayedCharacterId;
            m_delayTypeId = delayTypeId;
        }
        
        public GameRolePlayDelayedActionFinishedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_delayedCharacterId);
            writer.WriteByte(m_delayTypeId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_delayedCharacterId = reader.ReadDouble();
            m_delayTypeId = reader.ReadByte();
        }
    }
}
