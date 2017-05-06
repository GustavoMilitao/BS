//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Party
{
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class DungeonPartyFinderRegisterSuccessMessage : Message
    {
        
        public const int ProtocolId = 6241;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_dungeonIds;
        
        public virtual List<System.UInt16> DungeonIds
        {
            get
            {
                return m_dungeonIds;
            }
            set
            {
                m_dungeonIds = value;
            }
        }
        
        public DungeonPartyFinderRegisterSuccessMessage(List<System.UInt16> dungeonIds)
        {
            m_dungeonIds = dungeonIds;
        }
        
        public DungeonPartyFinderRegisterSuccessMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_dungeonIds.Count)));
            int dungeonIdsIndex;
            for (dungeonIdsIndex = 0; (dungeonIdsIndex < m_dungeonIds.Count); dungeonIdsIndex = (dungeonIdsIndex + 1))
            {
                writer.WriteVarShort(m_dungeonIds[dungeonIdsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int dungeonIdsCount = reader.ReadUShort();
            int dungeonIdsIndex;
            m_dungeonIds = new System.Collections.Generic.List<ushort>();
            for (dungeonIdsIndex = 0; (dungeonIdsIndex < dungeonIdsCount); dungeonIdsIndex = (dungeonIdsIndex + 1))
            {
                m_dungeonIds.Add(reader.ReadVarUhShort());
            }
        }
    }
}
