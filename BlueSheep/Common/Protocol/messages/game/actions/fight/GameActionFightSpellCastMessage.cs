









// Generated on 12/11/2014 19:01:18
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.Protocol.Types;
using BlueSheep.Common.IO;
using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages
{
    public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        public new const uint ID =1010;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int spellId;
        public sbyte spellLevel;
        public int[] portalsIds;
        
        public GameActionFightSpellCastMessage()
        {
        }
        
        public GameActionFightSpellCastMessage(int actionId, ulong sourceId, ulong targetId, int destinationCellId, sbyte critical, bool silentCast, int spellId, sbyte spellLevel, int[] portalsIds)
         : base(actionId, sourceId, targetId, destinationCellId, critical, silentCast)
        {
            this.spellId = spellId;
            this.spellLevel = spellLevel;
            this.portalsIds = portalsIds;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort((short)spellId);
            writer.WriteSByte(spellLevel);
            writer.WriteUShort((ushort)portalsIds.Length);
            foreach (var entry in portalsIds)
            {
                 writer.WriteShort((short)entry);
            }
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            spellId = reader.ReadVarUhShort();
            if (spellId < 0)
                throw new Exception("Forbidden value on spellId = " + spellId + ", it doesn't respect the following condition : spellId < 0");
            spellLevel = reader.ReadSByte();
            if (spellLevel < 1 || spellLevel > 6)
                throw new Exception("Forbidden value on spellLevel = " + spellLevel + ", it doesn't respect the following condition : spellLevel < 1 || spellLevel > 6");
            var limit = reader.ReadUShort();
            portalsIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 portalsIds[i] = reader.ReadShort();
            }
        }
        
    }
    
}