









// Generated on 12/11/2014 19:01:15
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class FriendGuildSetWarnOnAchievementCompleteMessage : Message
    {
        public new const uint ID =6382;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public bool enable;
        
        public FriendGuildSetWarnOnAchievementCompleteMessage()
        {
        }
        
        public FriendGuildSetWarnOnAchievementCompleteMessage(bool enable)
        {
            this.enable = enable;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteBoolean(enable);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            enable = reader.ReadBoolean();
        }
        
    }
    
}