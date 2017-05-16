//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Character.Stats
{


    public class LifePointsRegenEndMessage : UpdateLifePointsMessage
    {
        
        protected override int ProtocolId { get; set; } = 5686;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_lifePointsGained;
        
        public virtual uint LifePointsGained
        {
            get
            {
                return m_lifePointsGained;
            }
            set
            {
                m_lifePointsGained = value;
            }
        }
        
        public LifePointsRegenEndMessage(uint lifePointsGained)
        {
            m_lifePointsGained = lifePointsGained;
        }
        
        public LifePointsRegenEndMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_lifePointsGained);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_lifePointsGained = reader.ReadVarUhInt();
        }
    }
}
