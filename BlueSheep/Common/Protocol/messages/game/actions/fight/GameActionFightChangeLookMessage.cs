









// Generated on 12/11/2014 19:01:16
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionFightChangeLookMessage : AbstractGameActionMessage
    {
        public new const uint ID =5532;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public ulong targetId;
        public Types.EntityLook entityLook;
        
        public GameActionFightChangeLookMessage()
        {
        }
        
        public GameActionFightChangeLookMessage(int actionId, ulong sourceId, ulong targetId, Types.EntityLook entityLook)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.entityLook = entityLook;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteULong(targetId);
            entityLook.Serialize(writer);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            targetId = reader.ReadULong();
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
        }
        
    }
    
}