









// Generated on 12/11/2014 19:01:30
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class MountSetMessage : Message
    {
        public new const uint ID =5968;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.MountClientData mountData;
        
        public MountSetMessage()
        {
        }
        
        public MountSetMessage(Types.MountClientData mountData)
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