









// Generated on 12/11/2014 19:01:56
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class InventoryPresetSaveResultMessage : Message
    {
        public new const uint ID =6170;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte presetId;
        public sbyte code;
        
        public InventoryPresetSaveResultMessage()
        {
        }
        
        public InventoryPresetSaveResultMessage(sbyte presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(code);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
        }
        
    }
    
}