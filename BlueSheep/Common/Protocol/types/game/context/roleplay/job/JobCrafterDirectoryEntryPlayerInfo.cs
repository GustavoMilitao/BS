


















// Generated on 12/11/2014 19:02:07
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class JobCrafterDirectoryEntryPlayerInfo
{

public new const int ID = 194;
public virtual int TypeId
{
    get { return ID; }
}

public int playerId;
        public string playerName;
        public sbyte alignmentSide;
        public sbyte breed;
        public bool sex;
        public bool isInWorkshop;
        public int worldX;
        public int worldY;
        public int mapId;
        public int subAreaId;
        public Types.PlayerStatus status;
        

public JobCrafterDirectoryEntryPlayerInfo()
{
}

public JobCrafterDirectoryEntryPlayerInfo(int playerId, string playerName, sbyte alignmentSide, sbyte breed, bool sex, bool isInWorkshop, int worldX, int worldY, int mapId, int subAreaId, Types.PlayerStatus status)
        {
            this.playerId = playerId;
            this.playerName = playerName;
            this.alignmentSide = alignmentSide;
            this.breed = breed;
            this.sex = sex;
            this.isInWorkshop = isInWorkshop;
            this.worldX = worldX;
            this.worldY = worldY;
            this.mapId = mapId;
            this.subAreaId = subAreaId;
            this.status = status;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteVarInt(playerId);
            writer.WriteUTF(playerName);
            writer.WriteSByte(alignmentSide);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteBoolean(isInWorkshop);
            writer.WriteShort((short)worldX);
            writer.WriteShort((short)worldY);
            writer.WriteInt(mapId);
            writer.WriteVarShort((short)subAreaId);
            writer.WriteShort((short)status.TypeId);
            status.Serialize(writer);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

playerId = reader.ReadVarInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            playerName = reader.ReadUTF();
            alignmentSide = reader.ReadSByte();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            isInWorkshop = reader.ReadBoolean();
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
            status = Types.ProtocolTypeManager.GetInstance<Types.PlayerStatus>(reader.ReadUShort());
            status.Deserialize(reader);
            

}


}


}