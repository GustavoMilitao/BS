









// Generated on 12/11/2014 19:01:56
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class StorageInventoryContentMessage : InventoryContentMessage
    {
        public new const uint ID =5646;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public StorageInventoryContentMessage()
        {
        }
        
        public StorageInventoryContentMessage(Types.ObjectItem[] objects, int kamas)
         : base(objects, kamas)
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