









// Generated on 12/11/2014 19:01:33
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameRolePlayPlayerFightFriendlyAnsweredMessage : Message
    {
        public new const uint ID =5733;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int fightId;
        public int sourceId;
        public int targetId;
        public bool accept;
        
        public GameRolePlayPlayerFightFriendlyAnsweredMessage()
        {
        }
        
        public GameRolePlayPlayerFightFriendlyAnsweredMessage(int fightId, int sourceId, int targetId, bool accept)
        {
            this.fightId = fightId;
            this.sourceId = sourceId;
            this.targetId = targetId;
            this.accept = accept;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteInt(fightId);
            writer.WriteVarInt(sourceId);
            writer.WriteVarInt(targetId);
            writer.WriteBoolean(accept);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            fightId = reader.ReadInt();
            sourceId = reader.ReadVarInt();
            if (sourceId < 0)
                throw new Exception("Forbidden value on sourceId = " + sourceId + ", it doesn't respect the following condition : sourceId < 0");
            targetId = reader.ReadVarInt();
            if (targetId < 0)
                throw new Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < 0");
            accept = reader.ReadBoolean();
        }
        
    }
    
}