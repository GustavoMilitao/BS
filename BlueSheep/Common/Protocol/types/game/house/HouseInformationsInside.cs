


















// Generated on 12/11/2014 19:02:10
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class HouseInformationsInside
{

public new const int ID = 218;
public virtual int TypeId
{
    get { return ID; }
}

public int houseId;
        public int modelId;
        public int ownerId;
        public string ownerName;
        public int worldX;
        public int worldY;
        public int price;
        public bool isLocked;
        

public HouseInformationsInside()
{
}

public HouseInformationsInside(int houseId, int modelId, int ownerId, string ownerName, int worldX, int worldY, int price, bool isLocked)
        {
            this.houseId = houseId;
            this.modelId = modelId;
            this.ownerId = ownerId;
            this.ownerName = ownerName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.price = price;
            this.isLocked = isLocked;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

//writer.WriteInt(houseId);
    writer.WriteVarInt(houseId);
    writer.WriteVarShort((short)modelId);
            writer.WriteInt(ownerId);
            writer.WriteUTF(ownerName);
            writer.WriteShort((short)worldX);
            writer.WriteShort((short)worldY);
            writer.WriteInt(price);
            writer.WriteBoolean(isLocked);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

//houseId = reader.ReadInt();
    houseId = reader.ReadVarInt();
    if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            modelId = reader.ReadVarUhShort();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            ownerId = reader.ReadInt();
            ownerName = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            price = reader.ReadInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            isLocked = reader.ReadBoolean();
            

}


}


}