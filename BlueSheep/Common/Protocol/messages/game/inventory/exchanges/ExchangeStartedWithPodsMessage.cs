//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Exchanges
{


    public class ExchangeStartedWithPodsMessage : ExchangeStartedMessage
    {
        
        public const int ProtocolId = 6129;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private double m_firstCharacterId;
        
        public virtual double FirstCharacterId
        {
            get
            {
                return m_firstCharacterId;
            }
            set
            {
                m_firstCharacterId = value;
            }
        }
        
        private uint m_firstCharacterCurrentWeight;
        
        public virtual uint FirstCharacterCurrentWeight
        {
            get
            {
                return m_firstCharacterCurrentWeight;
            }
            set
            {
                m_firstCharacterCurrentWeight = value;
            }
        }
        
        private uint m_firstCharacterMaxWeight;
        
        public virtual uint FirstCharacterMaxWeight
        {
            get
            {
                return m_firstCharacterMaxWeight;
            }
            set
            {
                m_firstCharacterMaxWeight = value;
            }
        }
        
        private double m_secondCharacterId;
        
        public virtual double SecondCharacterId
        {
            get
            {
                return m_secondCharacterId;
            }
            set
            {
                m_secondCharacterId = value;
            }
        }
        
        private uint m_secondCharacterCurrentWeight;
        
        public virtual uint SecondCharacterCurrentWeight
        {
            get
            {
                return m_secondCharacterCurrentWeight;
            }
            set
            {
                m_secondCharacterCurrentWeight = value;
            }
        }
        
        private uint m_secondCharacterMaxWeight;
        
        public virtual uint SecondCharacterMaxWeight
        {
            get
            {
                return m_secondCharacterMaxWeight;
            }
            set
            {
                m_secondCharacterMaxWeight = value;
            }
        }
        
        public ExchangeStartedWithPodsMessage(double firstCharacterId, uint firstCharacterCurrentWeight, uint firstCharacterMaxWeight, double secondCharacterId, uint secondCharacterCurrentWeight, uint secondCharacterMaxWeight)
        {
            m_firstCharacterId = firstCharacterId;
            m_firstCharacterCurrentWeight = firstCharacterCurrentWeight;
            m_firstCharacterMaxWeight = firstCharacterMaxWeight;
            m_secondCharacterId = secondCharacterId;
            m_secondCharacterCurrentWeight = secondCharacterCurrentWeight;
            m_secondCharacterMaxWeight = secondCharacterMaxWeight;
        }
        
        public ExchangeStartedWithPodsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_firstCharacterId);
            writer.WriteVarInt(m_firstCharacterCurrentWeight);
            writer.WriteVarInt(m_firstCharacterMaxWeight);
            writer.WriteDouble(m_secondCharacterId);
            writer.WriteVarInt(m_secondCharacterCurrentWeight);
            writer.WriteVarInt(m_secondCharacterMaxWeight);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_firstCharacterId = reader.ReadDouble();
            m_firstCharacterCurrentWeight = reader.ReadVarUhInt();
            m_firstCharacterMaxWeight = reader.ReadVarUhInt();
            m_secondCharacterId = reader.ReadDouble();
            m_secondCharacterCurrentWeight = reader.ReadVarUhInt();
            m_secondCharacterMaxWeight = reader.ReadVarUhInt();
        }
    }
}
