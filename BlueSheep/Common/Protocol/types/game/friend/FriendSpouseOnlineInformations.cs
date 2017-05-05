


















// Generated on 12/11/2014 19:02:09
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class FriendSpouseOnlineInformations : FriendSpouseInformations
{

public new const int ID = 93;
public override int TypeId
{
    get { return ID; }
}

public int mapId;
        public int subAreaId;
          public bool inFight;
      
      public bool followSpouse;
        

public FriendSpouseOnlineInformations()
{
}

public FriendSpouseOnlineInformations(int spouseAccountId, int spouseId, string spouseName, byte spouseLevel, sbyte breed, sbyte sex, Types.EntityLook spouseEntityLook, Types.BasicGuildInformations guildInfo, sbyte alignmentSide, int mapId, int subAreaId)
         : base(spouseAccountId, spouseId, spouseName, spouseLevel, breed, sex, spouseEntityLook, guildInfo, alignmentSide)
        {
            this.mapId = mapId;
            this.subAreaId = subAreaId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(mapId);
            writer.WriteVarShort((short)subAreaId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            byte b  = reader.ReadByte();
            inFight = BooleanByteWrapper.GetFlag(b,0);
            followSpouse = BooleanByteWrapper.GetFlag(b,1);
            mapId = reader.ReadInt();
            if (mapId < 0)
                throw new Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            

}


}


}