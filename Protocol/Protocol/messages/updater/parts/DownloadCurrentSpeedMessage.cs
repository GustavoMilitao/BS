









// Generated on 12/11/2014 19:02:00
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class DownloadCurrentSpeedMessage : Message
    {
        public new const uint ID =1511;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public sbyte downloadSpeed;
        
        public DownloadCurrentSpeedMessage()
        {
        }
        
        public DownloadCurrentSpeedMessage(sbyte downloadSpeed)
        {
            this.downloadSpeed = downloadSpeed;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteSByte(downloadSpeed);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            downloadSpeed = reader.ReadSByte();
            if (downloadSpeed < 1 || downloadSpeed > 10)
                throw new Exception("Forbidden value on downloadSpeed = " + downloadSpeed + ", it doesn't respect the following condition : downloadSpeed < 1 || downloadSpeed > 10");
        }
        
    }
    
}