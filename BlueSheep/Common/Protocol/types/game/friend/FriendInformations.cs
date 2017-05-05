


















// Generated on 12/11/2014 19:02:09
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class FriendInformations : AbstractContactInformations
{

public new const int ID = 78;
public override int TypeId
{
    get { return ID; }
}

public sbyte playerState;
        public int lastConnection;
        public int achievementPoints;
        

public FriendInformations()
{
}

public FriendInformations(int accountId, string accountName, sbyte playerState, int lastConnection, int achievementPoints)
         : base(accountId, accountName)
        {
            this.playerState = playerState;
            this.lastConnection = lastConnection;
            this.achievementPoints = achievementPoints;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(playerState);
            writer.WriteVarShort((short)lastConnection);
            writer.WriteInt(achievementPoints);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            playerState = reader.ReadSByte();
            if (playerState < 0)
                throw new Exception("Forbidden value on playerState = " + playerState + ", it doesn't respect the following condition : playerState < 0");
            lastConnection = reader.ReadVarUhShort();
            if (lastConnection < 0)
                throw new Exception("Forbidden value on lastConnection = " + lastConnection + ", it doesn't respect the following condition : lastConnection < 0");
            achievementPoints = reader.ReadInt();
            

}


}


}