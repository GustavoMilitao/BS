









// Generated on 12/11/2014 19:01:18
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
    {
        public new const uint ID =6304;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int targetId;
        public short delta;
        
        public GameActionFightModifyEffectsDurationMessage()
        {
        }
        
        public GameActionFightModifyEffectsDurationMessage(short actionId, int sourceId, int targetId, short delta)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.delta = delta;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(targetId);
            writer.WriteShort(delta);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadInt();
            delta = reader.ReadShort();
        }
        
    }
    
}