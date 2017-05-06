//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Items
{
    using BlueSheep.Common.Protocol.Messages.Game.Inventory.Exchanges;


    public class ExchangeObjectRemovedMessage : ExchangeObjectMessage
    {
        
        public const int ProtocolId = 5517;
        
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
        
        public ExchangeObjectRemovedMessage(uint objectUID)
        {
            m_objectUID = objectUID;
        }
        
        public ExchangeObjectRemovedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(m_objectUID);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_objectUID = reader.ReadVarUhInt();
        }
    }
}
