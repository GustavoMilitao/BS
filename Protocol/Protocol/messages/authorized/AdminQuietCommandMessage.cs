









// Generated on 12/11/2014 19:01:13
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class AdminQuietCommandMessage : AdminCommandMessage
    {
        public new const uint ID =5662;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public AdminQuietCommandMessage()
        {
        }
        
        public AdminQuietCommandMessage(string content)
         : base(content)
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