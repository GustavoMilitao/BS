


















// Generated on 12/11/2014 19:02:08
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class TreasureHuntStepFollowDirection : TreasureHuntStep
{

public new const int ID = 468;
public override int TypeId
{
    get { return ID; }
}

public sbyte direction;
        public int mapCount;
        

public TreasureHuntStepFollowDirection()
{
}

public TreasureHuntStepFollowDirection(sbyte direction, int mapCount)
        {
            this.direction = direction;
            this.mapCount = mapCount;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(direction);
            writer.WriteVarShort((short)mapCount);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            mapCount = reader.ReadVarUhShort();
            if (mapCount < 0)
                throw new Exception("Forbidden value on mapCount = " + mapCount + ", it doesn't respect the following condition : mapCount < 0");
            

}


}


}