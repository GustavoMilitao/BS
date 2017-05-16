//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Inventory.Items
{


    public class MimicryObjectFeedAndAssociateRequestMessage : SymbioticObjectAssociateRequestMessage
    {
        
        protected override int ProtocolId { get; set; } = 6460;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_foodUID;
        
        public virtual uint FoodUID
        {
            get
            {
                return m_foodUID;
            }
            set
            {
                m_foodUID = value;
            }
        }
        
        private sbyte m_foodPos;
        
        public virtual sbyte FoodPos
        {
            get
            {
                return m_foodPos;
            }
            set
            {
                m_foodPos = value;
            }
        }
        
        private bool m_preview;
        
        public virtual bool Preview
        {
            get
            {
                return m_preview;
            }
            set
            {
                m_preview = value;
            }
        }
        
        public MimicryObjectFeedAndAssociateRequestMessage(uint foodUID, sbyte foodPos, bool preview)
        {
            m_foodUID = foodUID;
            m_foodPos = foodPos;
            m_preview = preview;
        }
        
        public MimicryObjectFeedAndAssociateRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_foodUID);
            writer.WriteSByte(m_foodPos);
            writer.WriteBoolean(m_preview);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_foodUID = reader.ReadVarUhInt();
            m_foodPos = reader.ReadSByte();
            m_preview = reader.ReadBoolean();
        }
    }
}
