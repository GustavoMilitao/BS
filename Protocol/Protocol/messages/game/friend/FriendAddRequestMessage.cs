









// Generated on 12/11/2014 19:01:42
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class FriendAddRequestMessage : Message
    {
        public new const uint ID =4004;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public string name;
        
        public FriendAddRequestMessage()
        {
        }
        
        public FriendAddRequestMessage(string name)
        {
            this.name = name;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteUTF(name);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            name = reader.ReadUTF();
        }
        
    }
    
}