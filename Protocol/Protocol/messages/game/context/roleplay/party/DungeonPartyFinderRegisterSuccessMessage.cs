









// Generated on 12/11/2014 19:01:36
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class DungeonPartyFinderRegisterSuccessMessage : Message
    {
        public new const uint ID =6241;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public short[] dungeonIds;
        
        public DungeonPartyFinderRegisterSuccessMessage()
        {
        }
        
        public DungeonPartyFinderRegisterSuccessMessage(short[] dungeonIds)
        {
            this.dungeonIds = dungeonIds;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteUShort((ushort)dungeonIds.Length);
            foreach (var entry in dungeonIds)
            {
                 writer.WriteVarShort(entry);
            }
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            var limit = reader.ReadUShort();
            dungeonIds = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 dungeonIds[i] = reader.ReadVarShort();
            }
        }
        
    }
    
}