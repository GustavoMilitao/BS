









// Generated on 12/11/2014 19:01:35
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class LockableStateUpdateAbstractMessage : Message
    {
        public new const uint ID =5671;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public bool locked;
        
        public LockableStateUpdateAbstractMessage()
        {
        }
        
        public LockableStateUpdateAbstractMessage(bool locked)
        {
            this.locked = locked;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteBoolean(locked);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            locked = reader.ReadBoolean();
        }
        
    }
    
}