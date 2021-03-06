//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay.Fight.Arena
{
    using MageBot.Protocol.Types;


    public class ArenaRankInfos : NetworkType
    {
        
        public override int ProtocolId { get; } = 499;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_rank;
        
        public virtual ushort Rank
        {
            get
            {
                return m_rank;
            }
            set
            {
                m_rank = value;
            }
        }
        
        private ushort m_bestRank;
        
        public virtual ushort BestRank
        {
            get
            {
                return m_bestRank;
            }
            set
            {
                m_bestRank = value;
            }
        }
        
        private ushort m_victoryCount;
        
        public virtual ushort VictoryCount
        {
            get
            {
                return m_victoryCount;
            }
            set
            {
                m_victoryCount = value;
            }
        }
        
        private ushort m_fightcount;
        
        public virtual ushort Fightcount
        {
            get
            {
                return m_fightcount;
            }
            set
            {
                m_fightcount = value;
            }
        }
        
        public ArenaRankInfos(ushort rank, ushort bestRank, ushort victoryCount, ushort fightcount)
        {
            m_rank = rank;
            m_bestRank = bestRank;
            m_victoryCount = victoryCount;
            m_fightcount = fightcount;
        }
        
        public ArenaRankInfos()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_rank);
            writer.WriteVarShort(m_bestRank);
            writer.WriteVarShort(m_victoryCount);
            writer.WriteVarShort(m_fightcount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_rank = reader.ReadVarUhShort();
            m_bestRank = reader.ReadVarUhShort();
            m_victoryCount = reader.ReadVarUhShort();
            m_fightcount = reader.ReadVarUhShort();
        }
    }
}
