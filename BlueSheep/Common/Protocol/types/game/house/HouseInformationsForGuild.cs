


















// Generated on 12/11/2014 19:02:10
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class HouseInformationsForGuild
{

public new const int ID = 170;
public virtual int TypeId
{
    get { return ID; }
}

public int houseId;
        public int modelId;
        public string ownerName;
        public int worldX;
        public int worldY;
        public int mapId;
        public int subAreaId;
        public int[] skillListIds;
        public int guildshareParams;
        

public HouseInformationsForGuild()
{
}

public HouseInformationsForGuild(int houseId, int modelId, string ownerName, int worldX, int worldY, int mapId, int subAreaId, int[] skillListIds, int guildshareParams)
        {
            this.houseId = houseId;
            this.modelId = modelId;
            this.ownerName = ownerName;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.skillListIds = skillListIds;
            this.guildshareParams = guildshareParams;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

//writer.WriteInt(houseId);
    writer.WriteVarInt(houseId);
    writer.WriteVarInt(modelId);
            writer.WriteUTF(ownerName);
            writer.WriteShort((short)worldX);
            writer.WriteShort((short)worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((short)subAreaId);
            writer.WriteUShort((ushort)skillListIds.Length);
            foreach (var entry in skillListIds)
            {
                 writer.WriteInt(entry);
            }
            writer.WriteVarInt(guildshareParams);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

//houseId = reader.ReadInt();
    houseId = reader.ReadVarInt();
    if (houseId < 0)
                throw new Exception("Forbidden value on houseId = " + houseId + ", it doesn't respect the following condition : houseId < 0");
            modelId = reader.ReadVarInt();
            if (modelId < 0)
                throw new Exception("Forbidden value on modelId = " + modelId + ", it doesn't respect the following condition : modelId < 0");
            ownerName = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            mapId = reader.ReadInt();
            subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            var limit = reader.ReadUShort();
            skillListIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 skillListIds[i] = reader.ReadInt();
            }
            guildshareParams = reader.ReadVarInt();
            if (guildshareParams < 0)
                throw new Exception("Forbidden value on guildshareParams = " + guildshareParams + ", it doesn't respect the following condition : guildshareParams < 0");
            

}


}


}