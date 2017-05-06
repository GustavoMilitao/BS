//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using BlueSheep.Common.Protocol.Types.Game.Data.Items;
    using BlueSheep.Common.Protocol.Types.Game.Character.Characteristic;
    using BlueSheep.Common.Protocol.Types.Game.Shortcut;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class SlaveSwitchContextMessage : Message 
    {
        
        public new const int ID = 6214;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<SpellItem> m_slaveSpells;
        
        public virtual List<SpellItem> SlaveSpells
        {
            get
            {
                return m_slaveSpells;
            }
            set
            {
                m_slaveSpells = value;
            }
        }
        
        private CharacterCharacteristicsInformations m_slaveStats;
        
        public virtual CharacterCharacteristicsInformations SlaveStats
        {
            get
            {
                return m_slaveStats;
            }
            set
            {
                m_slaveStats = value;
            }
        }
        
        private List<Shortcut> m_shortcuts;
        
        public virtual List<Shortcut> Shortcuts
        {
            get
            {
                return m_shortcuts;
            }
            set
            {
                m_shortcuts = value;
            }
        }
        
        private double m_masterId;
        
        public virtual double MasterId
        {
            get
            {
                return m_masterId;
            }
            set
            {
                m_masterId = value;
            }
        }
        
        private double m_slaveId;
        
        public virtual double SlaveId
        {
            get
            {
                return m_slaveId;
            }
            set
            {
                m_slaveId = value;
            }
        }
        
        public SlaveSwitchContextMessage(List<SpellItem> slaveSpells, CharacterCharacteristicsInformations slaveStats, List<Shortcut> shortcuts, double masterId, double slaveId)
        {
            m_slaveSpells = slaveSpells;
            m_slaveStats = slaveStats;
            m_shortcuts = shortcuts;
            m_masterId = masterId;
            m_slaveId = slaveId;
        }
        
        public SlaveSwitchContextMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_slaveSpells.Count)));
            int slaveSpellsIndex;
            for (slaveSpellsIndex = 0; (slaveSpellsIndex < m_slaveSpells.Count); slaveSpellsIndex = (slaveSpellsIndex + 1))
            {
                SpellItem objectToSend = m_slaveSpells[slaveSpellsIndex];
                objectToSend.Serialize(writer);
            }
            m_slaveStats.Serialize(writer);
            writer.WriteShort(((short)(m_shortcuts.Count)));
            int shortcutsIndex;
            for (shortcutsIndex = 0; (shortcutsIndex < m_shortcuts.Count); shortcutsIndex = (shortcutsIndex + 1))
            {
                Shortcut objectToSend = m_shortcuts[shortcutsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteDouble(m_masterId);
            writer.WriteDouble(m_slaveId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int slaveSpellsCount = reader.ReadUShort();
            int slaveSpellsIndex;
            m_slaveSpells = new System.Collections.Generic.List<SpellItem>();
            for (slaveSpellsIndex = 0; (slaveSpellsIndex < slaveSpellsCount); slaveSpellsIndex = (slaveSpellsIndex + 1))
            {
                SpellItem objectToAdd = new SpellItem();
                objectToAdd.Deserialize(reader);
                m_slaveSpells.Add(objectToAdd);
            }
            m_slaveStats = new CharacterCharacteristicsInformations();
            m_slaveStats.Deserialize(reader);
            int shortcutsCount = reader.ReadUShort();
            int shortcutsIndex;
            m_shortcuts = new System.Collections.Generic.List<Shortcut>();
            for (shortcutsIndex = 0; (shortcutsIndex < shortcutsCount); shortcutsIndex = (shortcutsIndex + 1))
            {
                Shortcut objectToAdd = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_shortcuts.Add(objectToAdd);
            }
            m_masterId = reader.ReadDouble();
            m_slaveId = reader.ReadDouble();
        }
    }
}
