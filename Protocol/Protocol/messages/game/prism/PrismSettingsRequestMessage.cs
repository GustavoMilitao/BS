









// Generated on 12/11/2014 19:01:58
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class PrismSettingsRequestMessage : Message
    {
        public new const uint ID =6437;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public short subAreaId;
        public sbyte startDefenseTime;
        
        public PrismSettingsRequestMessage()
        {
        }
        
        public PrismSettingsRequestMessage(short subAreaId, sbyte startDefenseTime)
        {
            this.subAreaId = subAreaId;
            this.startDefenseTime = startDefenseTime;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarShort(subAreaId);
            writer.WriteSByte(startDefenseTime);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            subAreaId = reader.ReadVarShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            startDefenseTime = reader.ReadSByte();
            if (startDefenseTime < 0)
                throw new Exception("Forbidden value on startDefenseTime = " + startDefenseTime + ", it doesn't respect the following condition : startDefenseTime < 0");
        }
        
    }
    
}