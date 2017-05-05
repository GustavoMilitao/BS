









// Generated on 12/11/2014 19:01:27
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameMapChangeOrientationMessage : Message
    {
        public new const uint ID =946;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.ActorOrientation orientation;
        
        public GameMapChangeOrientationMessage()
        {
        }
        
        public GameMapChangeOrientationMessage(Types.ActorOrientation orientation)
        {
            this.orientation = orientation;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            orientation.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            orientation = new Types.ActorOrientation();
            orientation.Deserialize(reader);
        }
        
    }
    
}