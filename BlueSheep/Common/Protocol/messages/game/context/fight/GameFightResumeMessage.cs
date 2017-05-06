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
    using BlueSheep.Common.Protocol.Types.Game.Context.Fight;
    using System.Collections.Generic;


    public class GameFightResumeMessage : GameFightSpectateMessage
    {
        
        public const int ProtocolId = 6067;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<GameFightSpellCooldown> m_spellCooldowns;
        
        public virtual List<GameFightSpellCooldown> SpellCooldowns
        {
            get
            {
                return m_spellCooldowns;
            }
            set
            {
                m_spellCooldowns = value;
            }
        }
        
        private byte m_summonCount;
        
        public virtual byte SummonCount
        {
            get
            {
                return m_summonCount;
            }
            set
            {
                m_summonCount = value;
            }
        }
        
        private byte m_bombCount;
        
        public virtual byte BombCount
        {
            get
            {
                return m_bombCount;
            }
            set
            {
                m_bombCount = value;
            }
        }
        
        public GameFightResumeMessage(List<GameFightSpellCooldown> spellCooldowns, byte summonCount, byte bombCount)
        {
            m_spellCooldowns = spellCooldowns;
            m_summonCount = summonCount;
            m_bombCount = bombCount;
        }
        
        public GameFightResumeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_spellCooldowns.Count)));
            int spellCooldownsIndex;
            for (spellCooldownsIndex = 0; (spellCooldownsIndex < m_spellCooldowns.Count); spellCooldownsIndex = (spellCooldownsIndex + 1))
            {
                GameFightSpellCooldown objectToSend = m_spellCooldowns[spellCooldownsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_summonCount);
            writer.WriteByte(m_bombCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int spellCooldownsCount = reader.ReadUShort();
            int spellCooldownsIndex;
            m_spellCooldowns = new System.Collections.Generic.List<GameFightSpellCooldown>();
            for (spellCooldownsIndex = 0; (spellCooldownsIndex < spellCooldownsCount); spellCooldownsIndex = (spellCooldownsIndex + 1))
            {
                GameFightSpellCooldown objectToAdd = new GameFightSpellCooldown();
                objectToAdd.Deserialize(reader);
                m_spellCooldowns.Add(objectToAdd);
            }
            m_summonCount = reader.ReadByte();
            m_bombCount = reader.ReadByte();
        }
    }
}
