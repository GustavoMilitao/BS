//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Dare
{
    using MageBot.Protocol.Types.Game.Dare;
    using System.Collections.Generic;


    public class DareRewardsListMessage : Message
    {
        
        public override int ProtocolId { get; } = 6677;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<DareReward> m_rewards;
        
        public virtual List<DareReward> Rewards
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
        
        public DareRewardsListMessage(List<DareReward> rewards)
        {
            m_rewards = rewards;
        }
        
        public DareRewardsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_rewards.Count)));
            int rewardsIndex;
            for (rewardsIndex = 0; (rewardsIndex < m_rewards.Count); rewardsIndex = (rewardsIndex + 1))
            {
                DareReward objectToSend = m_rewards[rewardsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int rewardsCount = reader.ReadUShort();
            int rewardsIndex;
            m_rewards = new System.Collections.Generic.List<DareReward>();
            for (rewardsIndex = 0; (rewardsIndex < rewardsCount); rewardsIndex = (rewardsIndex + 1))
            {
                DareReward objectToAdd = new DareReward();
                objectToAdd.Deserialize(reader);
                m_rewards.Add(objectToAdd);
            }
        }
    }
}
