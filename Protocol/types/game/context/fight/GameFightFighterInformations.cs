//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Fight
{
    using BlueSheep.Protocol.Types.Game.Context;
    using System.Collections.Generic;


    public class GameFightFighterInformations : GameContextActorInformations
    {
        
        protected override int ProtocolId { get; set; } = 143;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GameFightMinimalStats m_stats;
        
        public virtual GameFightMinimalStats Stats
        {
            get
            {
                return m_stats;
            }
            set
            {
                m_stats = value;
            }
        }
        
        private List<System.UInt16> m_previousPositions;
        
        public virtual List<System.UInt16> PreviousPositions
        {
            get
            {
                return m_previousPositions;
            }
            set
            {
                m_previousPositions = value;
            }
        }
        
        private byte m_teamId;
        
        public virtual byte TeamId
        {
            get
            {
                return m_teamId;
            }
            set
            {
                m_teamId = value;
            }
        }
        
        private byte m_wave;
        
        public virtual byte Wave
        {
            get
            {
                return m_wave;
            }
            set
            {
                m_wave = value;
            }
        }
        
        private bool m_alive;
        
        public virtual bool Alive
        {
            get
            {
                return m_alive;
            }
            set
            {
                m_alive = value;
            }
        }
        
        public GameFightFighterInformations(GameFightMinimalStats stats, List<System.UInt16> previousPositions, byte teamId, byte wave, bool alive)
        {
            m_stats = stats;
            m_previousPositions = previousPositions;
            m_teamId = teamId;
            m_wave = wave;
            m_alive = alive;
        }
        
        public GameFightFighterInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUShort(((ushort)(m_stats.TypeID)));
            m_stats.Serialize(writer);
            writer.WriteShort(((short)(m_previousPositions.Count)));
            int previousPositionsIndex;
            for (previousPositionsIndex = 0; (previousPositionsIndex < m_previousPositions.Count); previousPositionsIndex = (previousPositionsIndex + 1))
            {
                writer.WriteVarShort(m_previousPositions[previousPositionsIndex]);
            }
            writer.WriteByte(m_teamId);
            writer.WriteByte(m_wave);
            writer.WriteBoolean(m_alive);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_teamId = reader.ReadByte();
            m_wave = reader.ReadByte();
            m_alive = reader.ReadBoolean();
            m_stats = ProtocolTypeManager.GetInstance<GameFightMinimalStats>(reader.ReadUShort());
            m_stats.Deserialize(reader);
            int previousPositionsCount = reader.ReadUShort();
            int previousPositionsIndex;
            m_previousPositions = new System.Collections.Generic.List<ushort>();
            for (previousPositionsIndex = 0; (previousPositionsIndex < previousPositionsCount); previousPositionsIndex = (previousPositionsIndex + 1))
            {
                m_previousPositions.Add(reader.ReadVarUhShort());
            }
        }
    }
}
