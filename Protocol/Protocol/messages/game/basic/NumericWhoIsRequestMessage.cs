









// Generated on 12/11/2014 19:01:22
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class NumericWhoIsRequestMessage : Message
    {
        public new const uint ID =6298;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int playerId;
        
        public NumericWhoIsRequestMessage()
        {
        }
        
        public NumericWhoIsRequestMessage(int playerId)
        {
            this.playerId = playerId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarInt(playerId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            playerId = reader.ReadVarInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
        }
        
    }
    
}