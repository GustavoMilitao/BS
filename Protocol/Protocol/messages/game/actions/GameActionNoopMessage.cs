









// Generated on 12/11/2014 19:01:15
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionNoopMessage : Message
    {
        public new const uint ID =1002;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public GameActionNoopMessage()
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