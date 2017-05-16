//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Shortcut
{
    using BlueSheep.Protocol.Types.Game.Shortcut;
    using System.Collections.Generic;
    using BlueSheep.Protocol.Types;


    public class ShortcutBarContentMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6231;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        private byte m_barType;
        
        public virtual byte BarType
        {
            get
            {
                return m_barType;
            }
            set
            {
                m_barType = value;
            }
        }
        
        public ShortcutBarContentMessage(List<Shortcut> shortcuts, byte barType)
        {
            m_shortcuts = shortcuts;
            m_barType = barType;
        }
        
        public ShortcutBarContentMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_barType);
            writer.WriteShort(((short)(m_shortcuts.Count)));
            int shortcutsIndex;
            for (shortcutsIndex = 0; (shortcutsIndex < m_shortcuts.Count); shortcutsIndex = (shortcutsIndex + 1))
            {
                Shortcut objectToSend = m_shortcuts[shortcutsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_barType = reader.ReadByte();
            int shortcutsCount = reader.ReadUShort();
            int shortcutsIndex;
            m_shortcuts = new System.Collections.Generic.List<Shortcut>();
            for (shortcutsIndex = 0; (shortcutsIndex < shortcutsCount); shortcutsIndex = (shortcutsIndex + 1))
            {
                Shortcut objectToAdd = ProtocolTypeManager.GetInstance<Shortcut>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_shortcuts.Add(objectToAdd);
            }
        }
    }
}
