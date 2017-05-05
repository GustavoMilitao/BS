









// Generated on 12/11/2014 19:01:26
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameContextKickMessage : Message
    {
        public new const uint ID =6081;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int targetId;
        
        public GameContextKickMessage()
        {
        }
        
        public GameContextKickMessage(int targetId)
        {
            this.targetId = targetId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteInt(targetId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            targetId = reader.ReadInt();
        }
        
    }
    
}