









// Generated on 12/11/2014 19:01:49
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeItemPaymentForCraftMessage : Message
    {
        public new const uint ID =5831;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public bool onlySuccess;
        public Types.ObjectItemNotInContainer @object;
        
        public ExchangeItemPaymentForCraftMessage()
        {
        }
        
        public ExchangeItemPaymentForCraftMessage(bool onlySuccess, Types.ObjectItemNotInContainer @object)
        {
            this.onlySuccess = onlySuccess;
            this.@object = @object;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteBoolean(onlySuccess);
            @object.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            onlySuccess = reader.ReadBoolean();
            @object = new Types.ObjectItemNotInContainer();
            @object.Deserialize(reader);
        }
        
    }
    
}