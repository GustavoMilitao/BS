









// Generated on 12/11/2014 19:01:21
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class AtlasPointInformationsMessage : Message
    {
        public new const uint ID =5956;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.AtlasPointsInformations type;
        
        public AtlasPointInformationsMessage()
        {
        }
        
        public AtlasPointInformationsMessage(Types.AtlasPointsInformations type)
        {
            this.type = type;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            type.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            type = new Types.AtlasPointsInformations();
            type.Deserialize(reader);
        }
        
    }
    
}