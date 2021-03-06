//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Items
{
    public class ObjectQuantityMessage : Message
    {
        
        public override int ProtocolId { get; } = 3023;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_objectUID;
        
        public virtual uint ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ObjectQuantityMessage(uint objectUID, uint quantity)
        {
            m_objectUID = objectUID;
            m_quantity = quantity;
        }
        
        public ObjectQuantityMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_objectUID);
            writer.WriteVarInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_objectUID = reader.ReadVarUhInt();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
