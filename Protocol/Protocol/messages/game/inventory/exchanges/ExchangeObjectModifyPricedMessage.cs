









// Generated on 12/11/2014 19:01:50
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeObjectModifyPricedMessage : ExchangeObjectMovePricedMessage
    {
        public new const uint ID =6238;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public ExchangeObjectModifyPricedMessage()
        {
        }
        
        public ExchangeObjectModifyPricedMessage(int objectUID, int quantity, int price)
         : base(objectUID, quantity, price)
        {
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}