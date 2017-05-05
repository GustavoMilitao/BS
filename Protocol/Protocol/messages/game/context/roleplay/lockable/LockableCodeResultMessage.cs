









// Generated on 12/11/2014 19:01:35
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class LockableCodeResultMessage : Message
    {
        public new const uint ID =5672;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte result;
        
        public LockableCodeResultMessage()
        {
        }
        
        public LockableCodeResultMessage(sbyte result)
        {
            this.result = result;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(result);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            result = reader.ReadSByte();
            if (result < 0)
                throw new Exception("Forbidden value on result = " + result + ", it doesn't respect the following condition : result < 0");
        }
        
    }
    
}