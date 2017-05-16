//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Actions.Fight
{
    using System.Collections.Generic;


    public class GameActionFightSpellCastMessage : AbstractGameActionFightTargetedAbilityMessage
    {
        
        protected override int ProtocolId { get; set; } = 1010;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int16> m_portalsIds;
        
        public virtual List<System.Int16> PortalsIds
        {
            get
            {
                return m_portalsIds;
            }
            set
            {
                m_portalsIds = value;
            }
        }
        
        private ushort m_spellId;
        
        public virtual ushort SpellId
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
        
        private short m_spellLevel;
        
        public virtual short SpellLevel
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
        
        public GameActionFightSpellCastMessage(List<System.Int16> portalsIds, ushort spellId, short spellLevel)
        {
            m_portalsIds = portalsIds;
            m_spellId = spellId;
            m_spellLevel = spellLevel;
        }
        
        public GameActionFightSpellCastMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_portalsIds.Count)));
            int portalsIdsIndex;
            for (portalsIdsIndex = 0; (portalsIdsIndex < m_portalsIds.Count); portalsIdsIndex = (portalsIdsIndex + 1))
            {
                writer.WriteShort(m_portalsIds[portalsIdsIndex]);
            }
            writer.WriteVarShort(m_spellId);
            writer.WriteShort(m_spellLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_spellId = reader.ReadVarUhShort();
            m_spellLevel = reader.ReadShort();
            int portalsIdsCount = reader.ReadUShort();
            int portalsIdsIndex;
            m_portalsIds = new System.Collections.Generic.List<short>();
            for (portalsIdsIndex = 0; (portalsIdsIndex < portalsIdsCount); portalsIdsIndex = (portalsIdsIndex + 1))
            {
                m_portalsIds.Add(reader.ReadShort());
            }
        }
    }
}
