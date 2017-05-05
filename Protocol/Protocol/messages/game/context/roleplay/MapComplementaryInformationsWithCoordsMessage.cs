









// Generated on 12/11/2014 19:01:31
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class MapComplementaryInformationsWithCoordsMessage : MapComplementaryInformationsDataMessage
    {
        public new const uint ID =6268;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public short worldX;
        public short worldY;
        
        public MapComplementaryInformationsWithCoordsMessage()
        {
        }
        
        public MapComplementaryInformationsWithCoordsMessage(short subAreaId, int mapId, Types.HouseInformations[] houses, Types.GameRolePlayActorInformations[] actors, Types.InteractiveElement[] interactiveElements, Types.StatedElement[] statedElements, Types.MapObstacle[] obstacles, Types.FightCommonInformations[] fights, short worldX, short worldY)
         : base(subAreaId, mapId, houses, actors, interactiveElements, statedElements, obstacles, fights)
        {
            this.worldX = worldX;
            this.worldY = worldY;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
        }
        
    }
    
}