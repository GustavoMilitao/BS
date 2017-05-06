//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Spell
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class SpellItemBoostMessage : Message
    {
        
        public const int ProtocolId = 6011;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_statId;
        
        public virtual uint StatId
        {
            get
            {
                return m_statId;
            }
            set
            {
                m_statId = value;
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
        
        private short m_value;
        
        public virtual short Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
        
        public SpellItemBoostMessage(uint statId, ushort spellId, short value)
        {
            m_statId = statId;
            m_spellId = spellId;
            m_value = value;
        }
        
        public SpellItemBoostMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(m_statId);
            writer.WriteVarShort(m_spellId);
            writer.WriteVarShort(m_value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_statId = reader.ReadVarUhInt();
            m_spellId = reader.ReadVarUhShort();
            m_value = reader.ReadVarShort();
        }
    }
}
