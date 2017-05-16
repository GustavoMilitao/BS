//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Roleplay
{
    using System.Collections.Generic;
    using BlueSheep.Protocol.Types;


    public class AlternativeMonstersInGroupLightInformations : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 394;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<MonsterInGroupLightInformations> m_monsters;
        
        public virtual List<MonsterInGroupLightInformations> Monsters
        {
            get
            {
                return m_monsters;
            }
            set
            {
                m_monsters = value;
            }
        }
        
        private int m_playerCount;
        
        public virtual int PlayerCount
        {
            get
            {
                return m_playerCount;
            }
            set
            {
                m_playerCount = value;
            }
        }
        
        public AlternativeMonstersInGroupLightInformations(List<MonsterInGroupLightInformations> monsters, int playerCount)
        {
            m_monsters = monsters;
            m_playerCount = playerCount;
        }
        
        public AlternativeMonstersInGroupLightInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_monsters.Count)));
            int monstersIndex;
            for (monstersIndex = 0; (monstersIndex < m_monsters.Count); monstersIndex = (monstersIndex + 1))
            {
                MonsterInGroupLightInformations objectToSend = m_monsters[monstersIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteInt(m_playerCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int monstersCount = reader.ReadUShort();
            int monstersIndex;
            m_monsters = new System.Collections.Generic.List<MonsterInGroupLightInformations>();
            for (monstersIndex = 0; (monstersIndex < monstersCount); monstersIndex = (monstersIndex + 1))
            {
                MonsterInGroupLightInformations objectToAdd = new MonsterInGroupLightInformations();
                objectToAdd.Deserialize(reader);
                m_monsters.Add(objectToAdd);
            }
            m_playerCount = reader.ReadInt();
        }
    }
}
