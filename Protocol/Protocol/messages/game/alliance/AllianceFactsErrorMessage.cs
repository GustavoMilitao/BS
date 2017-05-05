









// Generated on 12/11/2014 19:01:20
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class AllianceFactsErrorMessage : Message
    {
        public new const uint ID =6423;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int allianceId;
        
        public AllianceFactsErrorMessage()
        {
        }
        
        public AllianceFactsErrorMessage(int allianceId)
        {
            this.allianceId = allianceId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarInt(allianceId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            allianceId = reader.ReadVarInt();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
        }
        
    }
    
}