//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Objects
{
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class ObjectGroundListAddedMessage : Message
    {
        
        public const int ProtocolId = 5925;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_cells;
        
        public virtual List<System.UInt16> Cells
        {
            get
            {
                return m_cells;
            }
            set
            {
                m_cells = value;
            }
        }
        
        private List<System.UInt16> m_referenceIds;
        
        public virtual List<System.UInt16> ReferenceIds
        {
            get
            {
                return m_referenceIds;
            }
            set
            {
                m_referenceIds = value;
            }
        }
        
        public ObjectGroundListAddedMessage(List<System.UInt16> cells, List<System.UInt16> referenceIds)
        {
            m_cells = cells;
            m_referenceIds = referenceIds;
        }
        
        public ObjectGroundListAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_cells.Count)));
            int cellsIndex;
            for (cellsIndex = 0; (cellsIndex < m_cells.Count); cellsIndex = (cellsIndex + 1))
            {
                writer.WriteVarShort(m_cells[cellsIndex]);
            }
            writer.WriteShort(((short)(m_referenceIds.Count)));
            int referenceIdsIndex;
            for (referenceIdsIndex = 0; (referenceIdsIndex < m_referenceIds.Count); referenceIdsIndex = (referenceIdsIndex + 1))
            {
                writer.WriteVarShort(m_referenceIds[referenceIdsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int cellsCount = reader.ReadUShort();
            int cellsIndex;
            m_cells = new System.Collections.Generic.List<ushort>();
            for (cellsIndex = 0; (cellsIndex < cellsCount); cellsIndex = (cellsIndex + 1))
            {
                m_cells.Add(reader.ReadVarUhShort());
            }
            int referenceIdsCount = reader.ReadUShort();
            int referenceIdsIndex;
            m_referenceIds = new System.Collections.Generic.List<ushort>();
            for (referenceIdsIndex = 0; (referenceIdsIndex < referenceIdsCount); referenceIdsIndex = (referenceIdsIndex + 1))
            {
                m_referenceIds.Add(reader.ReadVarUhShort());
            }
        }
    }
}
