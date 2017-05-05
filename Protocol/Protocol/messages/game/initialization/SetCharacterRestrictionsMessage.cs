









// Generated on 12/11/2014 19:01:46
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class SetCharacterRestrictionsMessage : Message
    {
        public new const uint ID =170;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.ActorRestrictionsInformations restrictions;
        
        public SetCharacterRestrictionsMessage()
        {
        }
        
        public SetCharacterRestrictionsMessage(Types.ActorRestrictionsInformations restrictions)
        {
            this.restrictions = restrictions;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            restrictions.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            restrictions = new Types.ActorRestrictionsInformations();
            restrictions.Deserialize(reader);
        }
        
    }
    
}