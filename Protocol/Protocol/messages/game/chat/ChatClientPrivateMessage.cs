









// Generated on 12/11/2014 19:01:24
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ChatClientPrivateMessage : ChatAbstractClientMessage
    {
        public new const uint ID =851;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public string receiver;
        
        public ChatClientPrivateMessage()
        {
        }
        
        public ChatClientPrivateMessage(string content, string receiver)
         : base(content)
        {
            this.receiver = receiver;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(receiver);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            receiver = reader.ReadUTF();
        }
        
    }
    
}