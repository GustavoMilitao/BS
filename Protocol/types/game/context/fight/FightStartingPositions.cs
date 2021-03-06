//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Fight
{
    using System.Collections.Generic;
    using MageBot.Protocol.Types;


    public class FightStartingPositions : NetworkType
    {
        
        public override int ProtocolId { get; } = 513;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_positionsForChallengers;
        
        public virtual List<System.UInt16> PositionsForChallengers
        {
            get
            {
                return m_positionsForChallengers;
            }
            set
            {
                m_positionsForChallengers = value;
            }
        }
        
        private List<System.UInt16> m_positionsForDefenders;
        
        public virtual List<System.UInt16> PositionsForDefenders
        {
            get
            {
                return m_positionsForDefenders;
            }
            set
            {
                m_positionsForDefenders = value;
            }
        }
        
        public FightStartingPositions(List<System.UInt16> positionsForChallengers, List<System.UInt16> positionsForDefenders)
        {
            m_positionsForChallengers = positionsForChallengers;
            m_positionsForDefenders = positionsForDefenders;
        }
        
        public FightStartingPositions()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_positionsForChallengers.Count)));
            int positionsForChallengersIndex;
            for (positionsForChallengersIndex = 0; (positionsForChallengersIndex < m_positionsForChallengers.Count); positionsForChallengersIndex = (positionsForChallengersIndex + 1))
            {
                writer.WriteVarShort(m_positionsForChallengers[positionsForChallengersIndex]);
            }
            writer.WriteShort(((short)(m_positionsForDefenders.Count)));
            int positionsForDefendersIndex;
            for (positionsForDefendersIndex = 0; (positionsForDefendersIndex < m_positionsForDefenders.Count); positionsForDefendersIndex = (positionsForDefendersIndex + 1))
            {
                writer.WriteVarShort(m_positionsForDefenders[positionsForDefendersIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int positionsForChallengersCount = reader.ReadUShort();
            int positionsForChallengersIndex;
            m_positionsForChallengers = new System.Collections.Generic.List<ushort>();
            for (positionsForChallengersIndex = 0; (positionsForChallengersIndex < positionsForChallengersCount); positionsForChallengersIndex = (positionsForChallengersIndex + 1))
            {
                m_positionsForChallengers.Add(reader.ReadVarUhShort());
            }
            int positionsForDefendersCount = reader.ReadUShort();
            int positionsForDefendersIndex;
            m_positionsForDefenders = new System.Collections.Generic.List<ushort>();
            for (positionsForDefendersIndex = 0; (positionsForDefendersIndex < positionsForDefendersCount); positionsForDefendersIndex = (positionsForDefendersIndex + 1))
            {
                m_positionsForDefenders.Add(reader.ReadVarUhShort());
            }
        }
    }
}
