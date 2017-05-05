









// Generated on 12/11/2014 19:01:59
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class OrnamentSelectedMessage : Message
    {
        public new const uint ID =6369;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int ornamentId;
        
        public OrnamentSelectedMessage()
        {
        }
        
        public OrnamentSelectedMessage(int ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort((short)ornamentId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            ornamentId = reader.ReadVarUhShort();
            if (ornamentId < 0)
                throw new Exception("Forbidden value on ornamentId = " + ornamentId + ", it doesn't respect the following condition : ornamentId < 0");
        }
        
    }
    
}