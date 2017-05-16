//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Dare
{
    using BlueSheep.Protocol.Types.Game.Dare;


    public class DareRewardWonMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6678;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private DareReward m_reward;
        
        public virtual DareReward Reward
        {
            get
            {
                return m_reward;
            }
            set
            {
                m_reward = value;
            }
        }
        
        public DareRewardWonMessage(DareReward reward)
        {
            m_reward = reward;
        }
        
        public DareRewardWonMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_reward.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_reward = new DareReward();
            m_reward.Deserialize(reader);
        }
    }
}
