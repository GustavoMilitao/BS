









// Generated on 12/11/2014 19:01:30
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class MountRidingMessage : Message
    {
        public new const uint ID =5967;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public bool isRiding;
        
        public MountRidingMessage()
        {
        }
        
        public MountRidingMessage(bool isRiding)
        {
            this.isRiding = isRiding;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteBoolean(isRiding);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            isRiding = reader.ReadBoolean();
        }
        
    }
    
}