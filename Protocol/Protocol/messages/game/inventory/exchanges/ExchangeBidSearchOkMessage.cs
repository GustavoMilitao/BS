









// Generated on 12/11/2014 19:01:48
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeBidSearchOkMessage : Message
    {
        public new const uint ID =5802;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public ExchangeBidSearchOkMessage()
        {
        }
        
        
        public override void Serialize(BigEndianWriter writer)
        {
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
        }
        
    }
    
}