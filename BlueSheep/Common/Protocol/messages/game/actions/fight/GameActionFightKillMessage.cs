//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Actions.Fight
{
    using BlueSheep.Common.Protocol.Messages.Game.Actions;


    public class GameActionFightKillMessage : AbstractGameActionMessage
    {
        
        public const int ProtocolId = 5571;
        
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
        
        public GameActionFightKillMessage(double targetId)
        {
            m_targetId = targetId;
        }
        
        public GameActionFightKillMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
        }
    }
}
