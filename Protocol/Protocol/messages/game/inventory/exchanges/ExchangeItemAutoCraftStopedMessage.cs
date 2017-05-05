









// Generated on 12/11/2014 19:01:49
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeItemAutoCraftStopedMessage : Message
    {
        public new const uint ID =5810;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte reason;
        
        public ExchangeItemAutoCraftStopedMessage()
        {
        }
        
        public ExchangeItemAutoCraftStopedMessage(sbyte reason)
        {
            this.reason = reason;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(reason);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            reason = reader.ReadSByte();
        }
        
    }
    
}