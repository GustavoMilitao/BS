









// Generated on 12/11/2014 19:01:49
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeMountFreeFromPaddockMessage : Message
    {
        public new const uint ID =6055;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public string name;
        public int worldX;
        public int worldY;
        public string liberator;
        
        public ExchangeMountFreeFromPaddockMessage()
        {
        }
        
        public ExchangeMountFreeFromPaddockMessage(string name, int worldX, int worldY, string liberator)
        {
            this.name = name;
            this.worldX = worldX;
            this.worldY = worldY;
            this.liberator = liberator;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteUTF(name);
            writer.WriteShort((short)worldX);
            writer.WriteShort((short)worldY);
            writer.WriteUTF(liberator);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            name = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            liberator = reader.ReadUTF();
        }
        
    }
    
}