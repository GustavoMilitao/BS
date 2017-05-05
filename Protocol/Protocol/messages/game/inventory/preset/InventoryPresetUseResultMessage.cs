









// Generated on 12/11/2014 19:01:56
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class InventoryPresetUseResultMessage : Message
    {
        public new const uint ID =6163;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte presetId;
        public sbyte code;
        public byte[] unlinkedPosition;
        
        public InventoryPresetUseResultMessage()
        {
        }
        
        public InventoryPresetUseResultMessage(sbyte presetId, sbyte code, byte[] unlinkedPosition)
        {
            this.presetId = presetId;
            this.code = code;
            this.unlinkedPosition = unlinkedPosition;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            writer.WriteUShort((ushort)unlinkedPosition.Length);
            foreach (var entry in unlinkedPosition)
            {
                 writer.WriteByte(entry);
            }
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            var limit = reader.ReadUShort();
            unlinkedPosition = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 unlinkedPosition[i] = reader.ReadByte();
            }
        }
        
    }
    
}