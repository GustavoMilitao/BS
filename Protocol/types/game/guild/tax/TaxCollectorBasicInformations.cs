//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Guild.Tax
{
    using BlueSheep.Protocol.Types;


    public class TaxCollectorBasicInformations : NetworkType
    {
        
        public const int ProtocolId = 96;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_firstNameId;
        
        public virtual ushort FirstNameId
        {
            get
            {
                return m_firstNameId;
            }
            set
            {
                m_firstNameId = value;
            }
        }
        
        private ushort m_lastNameId;
        
        public virtual ushort LastNameId
        {
            get
            {
                return m_lastNameId;
            }
            set
            {
                m_lastNameId = value;
            }
        }
        
        private short m_worldX;
        
        public virtual short WorldX
        {
            get
            {
                return m_worldX;
            }
            set
            {
                m_worldX = value;
            }
        }
        
        private short m_worldY;
        
        public virtual short WorldY
        {
            get
            {
                return m_worldY;
            }
            set
            {
                m_worldY = value;
            }
        }
        
        private int m_mapId;
        
        public virtual int MapId
        {
            get
            {
                return m_mapId;
            }
            set
            {
                m_mapId = value;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        public TaxCollectorBasicInformations(ushort firstNameId, ushort lastNameId, short worldX, short worldY, int mapId, ushort subAreaId)
        {
            m_firstNameId = firstNameId;
            m_lastNameId = lastNameId;
            m_worldX = worldX;
            m_worldY = worldY;
            m_mapId = mapId;
            m_subAreaId = subAreaId;
        }
        
        public TaxCollectorBasicInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_firstNameId);
            writer.WriteVarShort(m_lastNameId);
            writer.WriteShort(m_worldX);
            writer.WriteShort(m_worldY);
            writer.WriteInt(m_mapId);
            writer.WriteVarShort(m_subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_firstNameId = reader.ReadVarUhShort();
            m_lastNameId = reader.ReadVarUhShort();
            m_worldX = reader.ReadShort();
            m_worldY = reader.ReadShort();
            m_mapId = reader.ReadInt();
            m_subAreaId = reader.ReadVarUhShort();
        }
    }
}