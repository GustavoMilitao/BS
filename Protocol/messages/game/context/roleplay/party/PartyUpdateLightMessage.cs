//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Party
{


    public class PartyUpdateLightMessage : AbstractPartyEventMessage
    {
        
        protected override int ProtocolId { get; set; } = 6054;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_ObjectId;
        
        public virtual ulong ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        private uint m_lifePoints;
        
        public virtual uint LifePoints
        {
            get
            {
                return m_lifePoints;
            }
            set
            {
                m_lifePoints = value;
            }
        }
        
        private uint m_maxLifePoints;
        
        public virtual uint MaxLifePoints
        {
            get
            {
                return m_maxLifePoints;
            }
            set
            {
                m_maxLifePoints = value;
            }
        }
        
        private ushort m_prospecting;
        
        public virtual ushort Prospecting
        {
            get
            {
                return m_prospecting;
            }
            set
            {
                m_prospecting = value;
            }
        }
        
        private sbyte m_regenRate;
        
        public virtual sbyte RegenRate
        {
            get
            {
                return m_regenRate;
            }
            set
            {
                m_regenRate = value;
            }
        }
        
        public PartyUpdateLightMessage(ulong objectId, uint lifePoints, uint maxLifePoints, ushort prospecting, sbyte regenRate)
        {
            m_ObjectId = objectId;
            m_lifePoints = lifePoints;
            m_maxLifePoints = maxLifePoints;
            m_prospecting = prospecting;
            m_regenRate = regenRate;
        }
        
        public PartyUpdateLightMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarLong(m_ObjectId);
            writer.WriteVarInt(m_lifePoints);
            writer.WriteVarInt(m_maxLifePoints);
            writer.WriteVarShort(m_prospecting);
            writer.WriteSByte(m_regenRate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_ObjectId = reader.ReadVarUhLong();
            m_lifePoints = reader.ReadVarUhInt();
            m_maxLifePoints = reader.ReadVarUhInt();
            m_prospecting = reader.ReadVarUhShort();
            m_regenRate = reader.ReadSByte();
        }
    }
}
