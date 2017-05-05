









// Generated on 12/11/2014 19:01:41
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class SpellItemBoostMessage : Message
    {
        public new const uint ID =6011;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int statId;
        public int spellId;
        public int value;
        
        public SpellItemBoostMessage()
        {
        }
        
        public SpellItemBoostMessage(int statId, int spellId, int value)
        {
            this.statId = statId;
            this.spellId = spellId;
            this.value = value;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarInt(statId);
            writer.WriteVarShort((short)spellId);
            writer.WriteVarShort((short)value);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            statId = reader.ReadVarInt();
            if (statId < 0)
                throw new Exception("Forbidden value on statId = " + statId + ", it doesn't respect the following condition : statId < 0");
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            value = reader.ReadVarUhShort();
        }
        
    }
    
}