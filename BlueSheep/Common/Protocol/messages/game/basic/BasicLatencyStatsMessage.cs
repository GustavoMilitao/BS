









// Generated on 12/11/2014 19:01:22
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class BasicLatencyStatsMessage : Message
    {
        public new const uint ID =5663;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int latency;
        public int sampleCount;
        public int max;
        
        public BasicLatencyStatsMessage()
        {
        }
        
        public BasicLatencyStatsMessage(int latency, int sampleCount, int max)
        {
            this.latency = latency;
            this.sampleCount = sampleCount;
            this.max = max;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteUShort((ushort)latency);
            writer.WriteVarShort((short)sampleCount);
            writer.WriteVarShort((short)max);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            latency = reader.ReadUShort();
            if (latency < 0 || latency > 65535)
                throw new Exception("Forbidden value on latency = " + latency + ", it doesn't respect the following condition : latency < 0 || latency > 65535");
            sampleCount = reader.ReadVarUhShort();
            if (sampleCount < 0)
                throw new Exception("Forbidden value on sampleCount = " + sampleCount + ", it doesn't respect the following condition : sampleCount < 0");
            max = reader.ReadVarUhShort();
            if (max < 0)
                throw new Exception("Forbidden value on max = " + max + ", it doesn't respect the following condition : max < 0");
        }
        
    }
    
}