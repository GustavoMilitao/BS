









// Generated on 12/11/2014 19:01:20
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class AllianceMembershipMessage : AllianceJoinedMessage
    {
        public new const uint ID =6390;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        
        public AllianceMembershipMessage()
        {
        }
        
        public AllianceMembershipMessage(Types.AllianceInformations allianceInfo, bool enabled)
         : base(allianceInfo, enabled)
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