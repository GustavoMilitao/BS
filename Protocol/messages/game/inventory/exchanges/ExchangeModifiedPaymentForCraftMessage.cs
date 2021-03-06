//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Inventory.Exchanges
{
    using MageBot.Protocol.Types.Game.Data.Items;


    public class ExchangeModifiedPaymentForCraftMessage : Message
    {
        
        public override int ProtocolId { get; } = 5832;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_onlySuccess;
        
        public virtual bool OnlySuccess
        {
            get
            {
                return m_onlySuccess;
            }
            set
            {
                m_onlySuccess = value;
            }
        }
        
        private ObjectItemNotInContainer m_object;
        
        public virtual ObjectItemNotInContainer Object
        {
            get
            {
                return m_object;
            }
            set
            {
                m_object = value;
            }
        }
        
        public ExchangeModifiedPaymentForCraftMessage(bool onlySuccess, ObjectItemNotInContainer @object)
        {
            m_onlySuccess = onlySuccess;
            m_object = @object;
        }
        
        public ExchangeModifiedPaymentForCraftMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_onlySuccess);
            m_object.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_onlySuccess = reader.ReadBoolean();
            m_object = new ObjectItemNotInContainer();
            m_object.Deserialize(reader);
        }
    }
}
