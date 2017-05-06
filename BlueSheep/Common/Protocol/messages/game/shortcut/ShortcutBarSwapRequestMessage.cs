//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Shortcut
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class ShortcutBarSwapRequestMessage : Message
    {
        
        public const int ProtocolId = 6230;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        private byte m_firstSlot;
        
        public virtual byte FirstSlot
        {
            get
            {
                return m_firstSlot;
            }
            set
            {
                m_firstSlot = value;
            }
        }
        
        private byte m_secondSlot;
        
        public virtual byte SecondSlot
        {
            get
            {
                return m_secondSlot;
            }
            set
            {
                m_secondSlot = value;
            }
        }
        
        public ShortcutBarSwapRequestMessage(byte barType, byte firstSlot, byte secondSlot)
        {
            m_barType = barType;
            m_firstSlot = firstSlot;
            m_secondSlot = secondSlot;
        }
        
        public ShortcutBarSwapRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_barType);
            writer.WriteByte(m_firstSlot);
            writer.WriteByte(m_secondSlot);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_barType = reader.ReadByte();
            m_firstSlot = reader.ReadByte();
            m_secondSlot = reader.ReadByte();
        }
    }
}
