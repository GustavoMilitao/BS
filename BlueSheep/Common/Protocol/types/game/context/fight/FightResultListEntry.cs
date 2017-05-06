//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Fight
{
    using BlueSheep.Common.Protocol.Types;


    public class FightResultListEntry : NetworkType
    {
        
        public const int ProtocolId = 16;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private FightLoot m_rewards;
        
        public virtual FightLoot Rewards
        {
            get
            {
                return m_rewards;
            }
            set
            {
                m_rewards = value;
            }
        }
        
        private ushort m_outcome;
        
        public virtual ushort Outcome
        {
            get
            {
                return m_outcome;
            }
            set
            {
                m_outcome = value;
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
        
        public FightResultListEntry(FightLoot rewards, ushort outcome, byte wave)
        {
            m_rewards = rewards;
            m_outcome = outcome;
            m_wave = wave;
        }
        
        public FightResultListEntry()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_rewards.Serialize(writer);
            writer.WriteVarShort(m_outcome);
            writer.WriteByte(m_wave);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_rewards = new FightLoot();
            m_rewards.Deserialize(reader);
            m_outcome = reader.ReadVarUhShort();
            m_wave = reader.ReadByte();
        }
    }
}
