









// Generated on 12/11/2014 19:01:30
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class MountDataMessage : Message
    {
        public new const uint ID =5973;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.MountClientData mountData;
        
        public MountDataMessage()
        {
        }
        
        public MountDataMessage(Types.MountClientData mountData)
        {
            this.mountData = mountData;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            mountData.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            mountData = new Types.MountClientData();
            mountData.Deserialize(reader);
        }
        
    }
    
}