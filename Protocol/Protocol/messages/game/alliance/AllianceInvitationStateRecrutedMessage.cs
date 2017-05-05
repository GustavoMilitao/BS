









// Generated on 12/11/2014 19:01:20
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class AllianceInvitationStateRecrutedMessage : Message
    {
        public new const uint ID =6392;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte invitationState;
        
        public AllianceInvitationStateRecrutedMessage()
        {
        }
        
        public AllianceInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(invitationState);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
        }
        
    }
    
}