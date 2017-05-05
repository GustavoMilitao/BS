









// Generated on 12/11/2014 19:01:39
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class PartyNewMemberMessage : PartyUpdateMessage
    {
        public new const uint ID =6306;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public PartyNewMemberMessage()
        {
        }
        
        public PartyNewMemberMessage(int partyId, Types.PartyMemberInformations memberInformations)
         : base(partyId, memberInformations)
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