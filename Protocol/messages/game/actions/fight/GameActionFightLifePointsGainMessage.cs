//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Actions.Fight
{
    using BlueSheep.Protocol.Messages.Game.Actions;


    public class GameActionFightLifePointsGainMessage : AbstractGameActionMessage
    {
        
        protected override int ProtocolId { get; set; } = 6311;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private uint m_delta;
        
        public virtual uint Delta
        {
            get
            {
                return m_delta;
            }
            set
            {
                m_delta = value;
            }
        }
        
        public GameActionFightLifePointsGainMessage(double targetId, uint delta)
        {
            m_targetId = targetId;
            m_delta = delta;
        }
        
        public GameActionFightLifePointsGainMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteVarInt(m_delta);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_delta = reader.ReadVarUhInt();
        }
    }
}
