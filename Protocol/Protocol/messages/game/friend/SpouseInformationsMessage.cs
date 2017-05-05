









// Generated on 12/11/2014 19:01:43
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class SpouseInformationsMessage : Message
    {
        public new const uint ID =6356;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public Types.FriendSpouseInformations spouse;
        
        public SpouseInformationsMessage()
        {
        }
        
        public SpouseInformationsMessage(Types.FriendSpouseInformations spouse)
        {
            this.spouse = spouse;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteShort(spouse.TypeId);
            spouse.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            spouse = Types.ProtocolTypeManager.GetInstance<Types.FriendSpouseInformations>(reader.ReadShort());
            spouse.Deserialize(reader);
        }
        
    }
    
}