//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild
{
    using System.Collections.Generic;
    using BlueSheep.Common;


    public class GuildInfosUpgradeMessage : Message
    {
        
        public const int ProtocolId = 5636;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_spellId;
        
        public virtual List<System.UInt16> SpellId
        {
            get
            {
                return m_spellId;
            }
            set
            {
                m_spellId = value;
            }
        }
        
        private List<System.Int16> m_spellLevel;
        
        public virtual List<System.Int16> SpellLevel
        {
            get
            {
                return m_spellLevel;
            }
            set
            {
                m_spellLevel = value;
            }
        }
        
        private byte m_maxTaxCollectorsCount;
        
        public virtual byte MaxTaxCollectorsCount
        {
            get
            {
                return m_maxTaxCollectorsCount;
            }
            set
            {
                m_maxTaxCollectorsCount = value;
            }
        }
        
        private byte m_taxCollectorsCount;
        
        public virtual byte TaxCollectorsCount
        {
            get
            {
                return m_taxCollectorsCount;
            }
            set
            {
                m_taxCollectorsCount = value;
            }
        }
        
        private ushort m_taxCollectorLifePoints;
        
        public virtual ushort TaxCollectorLifePoints
        {
            get
            {
                return m_taxCollectorLifePoints;
            }
            set
            {
                m_taxCollectorLifePoints = value;
            }
        }
        
        private ushort m_taxCollectorDamagesBonuses;
        
        public virtual ushort TaxCollectorDamagesBonuses
        {
            get
            {
                return m_taxCollectorDamagesBonuses;
            }
            set
            {
                m_taxCollectorDamagesBonuses = value;
            }
        }
        
        private ushort m_taxCollectorPods;
        
        public virtual ushort TaxCollectorPods
        {
            get
            {
                return m_taxCollectorPods;
            }
            set
            {
                m_taxCollectorPods = value;
            }
        }
        
        private ushort m_taxCollectorProspecting;
        
        public virtual ushort TaxCollectorProspecting
        {
            get
            {
                return m_taxCollectorProspecting;
            }
            set
            {
                m_taxCollectorProspecting = value;
            }
        }
        
        private ushort m_taxCollectorWisdom;
        
        public virtual ushort TaxCollectorWisdom
        {
            get
            {
                return m_taxCollectorWisdom;
            }
            set
            {
                m_taxCollectorWisdom = value;
            }
        }
        
        private ushort m_boostPoints;
        
        public virtual ushort BoostPoints
        {
            get
            {
                return m_boostPoints;
            }
            set
            {
                m_boostPoints = value;
            }
        }
        
        public GuildInfosUpgradeMessage(List<System.UInt16> spellId, List<System.Int16> spellLevel, byte maxTaxCollectorsCount, byte taxCollectorsCount, ushort taxCollectorLifePoints, ushort taxCollectorDamagesBonuses, ushort taxCollectorPods, ushort taxCollectorProspecting, ushort taxCollectorWisdom, ushort boostPoints)
        {
            m_spellId = spellId;
            m_spellLevel = spellLevel;
            m_maxTaxCollectorsCount = maxTaxCollectorsCount;
            m_taxCollectorsCount = taxCollectorsCount;
            m_taxCollectorLifePoints = taxCollectorLifePoints;
            m_taxCollectorDamagesBonuses = taxCollectorDamagesBonuses;
            m_taxCollectorPods = taxCollectorPods;
            m_taxCollectorProspecting = taxCollectorProspecting;
            m_taxCollectorWisdom = taxCollectorWisdom;
            m_boostPoints = boostPoints;
        }
        
        public GuildInfosUpgradeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_spellId.Count)));
            int spellIdIndex;
            for (spellIdIndex = 0; (spellIdIndex < m_spellId.Count); spellIdIndex = (spellIdIndex + 1))
            {
                writer.WriteVarShort(m_spellId[spellIdIndex]);
            }
            writer.WriteShort(((short)(m_spellLevel.Count)));
            int spellLevelIndex;
            for (spellLevelIndex = 0; (spellLevelIndex < m_spellLevel.Count); spellLevelIndex = (spellLevelIndex + 1))
            {
                writer.WriteShort(m_spellLevel[spellLevelIndex]);
            }
            writer.WriteByte(m_maxTaxCollectorsCount);
            writer.WriteByte(m_taxCollectorsCount);
            writer.WriteVarShort(m_taxCollectorLifePoints);
            writer.WriteVarShort(m_taxCollectorDamagesBonuses);
            writer.WriteVarShort(m_taxCollectorPods);
            writer.WriteVarShort(m_taxCollectorProspecting);
            writer.WriteVarShort(m_taxCollectorWisdom);
            writer.WriteVarShort(m_boostPoints);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int spellIdCount = reader.ReadUShort();
            int spellIdIndex;
            m_spellId = new System.Collections.Generic.List<ushort>();
            for (spellIdIndex = 0; (spellIdIndex < spellIdCount); spellIdIndex = (spellIdIndex + 1))
            {
                m_spellId.Add(reader.ReadVarUhShort());
            }
            int spellLevelCount = reader.ReadUShort();
            int spellLevelIndex;
            m_spellLevel = new System.Collections.Generic.List<short>();
            for (spellLevelIndex = 0; (spellLevelIndex < spellLevelCount); spellLevelIndex = (spellLevelIndex + 1))
            {
                m_spellLevel.Add(reader.ReadShort());
            }
            m_maxTaxCollectorsCount = reader.ReadByte();
            m_taxCollectorsCount = reader.ReadByte();
            m_taxCollectorLifePoints = reader.ReadVarUhShort();
            m_taxCollectorDamagesBonuses = reader.ReadVarUhShort();
            m_taxCollectorPods = reader.ReadVarUhShort();
            m_taxCollectorProspecting = reader.ReadVarUhShort();
            m_taxCollectorWisdom = reader.ReadVarUhShort();
            m_boostPoints = reader.ReadVarUhShort();
        }
    }
}