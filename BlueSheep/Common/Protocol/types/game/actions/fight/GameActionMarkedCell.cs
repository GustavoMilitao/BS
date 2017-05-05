


















// Generated on 12/11/2014 19:02:02
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class GameActionMarkedCell
{

public new const int ID = 85;
public virtual int TypeId
{
    get { return ID; }
}

public int cellId;
        public sbyte zoneSize;
        public int cellColor;
        public sbyte cellsType;
        

public GameActionMarkedCell()
{
}

public GameActionMarkedCell(int cellId, sbyte zoneSize, int cellColor, sbyte cellsType)
        {
            this.cellId = cellId;
            this.zoneSize = zoneSize;
            this.cellColor = cellColor;
            this.cellsType = cellsType;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteVarShort((short)cellId);
            writer.WriteSByte(zoneSize);
            writer.WriteInt(cellColor);
            writer.WriteSByte(cellsType);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

cellId = reader.ReadVarUhShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            zoneSize = reader.ReadSByte();
            cellColor = reader.ReadInt();
            cellsType = reader.ReadSByte();
            

}


}


}