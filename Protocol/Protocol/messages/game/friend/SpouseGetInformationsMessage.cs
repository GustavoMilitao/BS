









// Generated on 12/11/2014 19:01:43
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class SpouseGetInformationsMessage : Message
    {
        public new const uint ID =6355;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public SpouseGetInformationsMessage()
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