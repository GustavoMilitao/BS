//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Character.Stats
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class LifePointsRegenBeginMessage : Message
    {
        
        public const int ProtocolId = 5684;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_regenRate;
        
        public virtual sbyte RegenRate
        {
            get
            {
                return m_regenRate;
            }
            set
            {
                m_regenRate = value;
            }
        }
        
        public LifePointsRegenBeginMessage(sbyte regenRate)
        {
            m_regenRate = regenRate;
        }
        
        public LifePointsRegenBeginMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(m_regenRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_regenRate = reader.ReadSByte();
        }
    }
}
