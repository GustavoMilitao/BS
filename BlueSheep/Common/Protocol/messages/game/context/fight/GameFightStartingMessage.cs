//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameFightStartingMessage : Message
    {
        
        public const int ProtocolId = 700;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_fightType;
        
        public virtual byte FightType
        {
            get
            {
                return m_fightType;
            }
            set
            {
                m_fightType = value;
            }
        }
        
        private double m_attackerId;
        
        public virtual double AttackerId
        {
            get
            {
                return m_attackerId;
            }
            set
            {
                m_attackerId = value;
            }
        }
        
        private double m_defenderId;
        
        public virtual double DefenderId
        {
            get
            {
                return m_defenderId;
            }
            set
            {
                m_defenderId = value;
            }
        }
        
        public GameFightStartingMessage(byte fightType, double attackerId, double defenderId)
        {
            m_fightType = fightType;
            m_attackerId = attackerId;
            m_defenderId = defenderId;
        }
        
        public GameFightStartingMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_fightType);
            writer.WriteDouble(m_attackerId);
            writer.WriteDouble(m_defenderId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightType = reader.ReadByte();
            m_attackerId = reader.ReadDouble();
            m_defenderId = reader.ReadDouble();
        }
    }
}
