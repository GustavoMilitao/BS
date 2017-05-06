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
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class SpellModifyRequestMessage : Message 
    {
        
        public new const int ID = 6655;
        
        public override int MessageID
        {
            get
            {
                return ID;
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
        
        public SpellModifyRequestMessage(ushort spellId, short spellLevel)
        {
            m_spellId = spellId;
            m_spellLevel = spellLevel;
        }
        
        public SpellModifyRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_spellId);
            writer.WriteShort(m_spellLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_spellId = reader.ReadVarUhShort();
            m_spellLevel = reader.ReadShort();
        }
    }
}
