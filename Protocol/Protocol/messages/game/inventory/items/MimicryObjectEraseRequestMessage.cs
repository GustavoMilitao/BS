









// Generated on 12/11/2014 19:01:54
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class MimicryObjectEraseRequestMessage : Message
    {
        public new const uint ID =6457;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int hostUID;
        public byte hostPos;
        
        public MimicryObjectEraseRequestMessage()
        {
        }
        
        public MimicryObjectEraseRequestMessage(int hostUID, byte hostPos)
        {
            this.hostUID = hostUID;
            this.hostPos = hostPos;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarInt(hostUID);
            writer.WriteByte(hostPos);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            hostUID = reader.ReadVarInt();
            if (hostUID < 0)
                throw new Exception("Forbidden value on hostUID = " + hostUID + ", it doesn't respect the following condition : hostUID < 0");
            hostPos = reader.ReadByte();
            if (hostPos < 0 || hostPos > 255)
                throw new Exception("Forbidden value on hostPos = " + hostPos + ", it doesn't respect the following condition : hostPos < 0 || hostPos > 255");
        }
        
    }
    
}