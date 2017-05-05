









// Generated on 12/11/2014 19:01:47
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class TeleportBuddiesMessage : Message
    {
        public new const uint ID =6289;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public short dungeonId;
        
        public TeleportBuddiesMessage()
        {
        }
        
        public TeleportBuddiesMessage(short dungeonId)
        {
            this.dungeonId = dungeonId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort(dungeonId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            dungeonId = reader.ReadVarShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
        }
        
    }
    
}