//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Job
{
    using BlueSheep.Protocol.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;


    public class JobBookSubscriptionMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6593;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<JobBookSubscription> m_subscriptions;
        
        public virtual List<JobBookSubscription> Subscriptions
        {
            get
            {
                return m_subscriptions;
            }
            set
            {
                m_subscriptions = value;
            }
        }
        
        public JobBookSubscriptionMessage(List<JobBookSubscription> subscriptions)
        {
            m_subscriptions = subscriptions;
        }
        
        public JobBookSubscriptionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_subscriptions.Count)));
            int subscriptionsIndex;
            for (subscriptionsIndex = 0; (subscriptionsIndex < m_subscriptions.Count); subscriptionsIndex = (subscriptionsIndex + 1))
            {
                JobBookSubscription objectToSend = m_subscriptions[subscriptionsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int subscriptionsCount = reader.ReadUShort();
            int subscriptionsIndex;
            m_subscriptions = new System.Collections.Generic.List<JobBookSubscription>();
            for (subscriptionsIndex = 0; (subscriptionsIndex < subscriptionsCount); subscriptionsIndex = (subscriptionsIndex + 1))
            {
                JobBookSubscription objectToAdd = new JobBookSubscription();
                objectToAdd.Deserialize(reader);
                m_subscriptions.Add(objectToAdd);
            }
        }
    }
}
