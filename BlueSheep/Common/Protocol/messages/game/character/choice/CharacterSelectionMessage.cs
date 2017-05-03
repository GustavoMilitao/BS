









// Generated on 12/11/2014 19:01:23
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class CharacterSelectionMessage : Message
    {
        public new const uint ID =152;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public ulong id;
        
        public CharacterSelectionMessage()
        {
        }
        
        public CharacterSelectionMessage(ulong id)
        {
            this.id = id;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarLong(id);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            id = reader.ReadVarUhLong();
            if (id < 1 || id > 2147483647)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 1 || id > 2147483647");
        }
        
    }
    
}