


















// Generated on 12/11/2014 19:02:11
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class PaddockInformationsForSell
{

public new const int ID = 222;
public virtual int TypeId
{
    get { return ID; }
}

public string guildOwner;
        public int worldX;
        public int worldY;
        public int subAreaId;
        public sbyte nbMount;
        public sbyte nbObject;
        public int price;
        

public PaddockInformationsForSell()
{
}

public PaddockInformationsForSell(string guildOwner, int worldX, int worldY, int subAreaId, sbyte nbMount, sbyte nbObject, int price)
        {
            this.guildOwner = guildOwner;
            this.worldX = worldX;
            this.worldY = worldY;
            this.subAreaId = subAreaId;
            this.nbMount = nbMount;
            this.nbObject = nbObject;
            this.price = price;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(guildOwner);
            writer.WriteShort((short)worldX);
            writer.WriteShort((short)worldY);
            writer.WriteVarShort((short)subAreaId);
            writer.WriteSByte(nbMount);
            writer.WriteSByte(nbObject);
            writer.WriteVarInt(price);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

guildOwner = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            nbMount = reader.ReadSByte();
            nbObject = reader.ReadSByte();
            price = reader.ReadVarInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}