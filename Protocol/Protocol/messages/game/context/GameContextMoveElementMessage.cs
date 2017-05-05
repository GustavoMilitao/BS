









// Generated on 12/11/2014 19:01:26
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameContextMoveElementMessage : Message
    {
        public new const uint ID =253;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.EntityMovementInformations movement;
        
        public GameContextMoveElementMessage()
        {
        }
        
        public GameContextMoveElementMessage(Types.EntityMovementInformations movement)
        {
            this.movement = movement;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            movement.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            movement = new Types.EntityMovementInformations();
            movement.Deserialize(reader);
        }
        
    }
    
}