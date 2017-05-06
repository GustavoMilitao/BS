//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Guild.Tax
{
    using BlueSheep.Common.Protocol.Types.Game.Character;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    public class TaxCollectorFightersInformation 
    {
        
        public new const int ID = 169;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private List<CharacterMinimalPlusLookInformations> m_allyCharactersInformations;
        
        public virtual List<CharacterMinimalPlusLookInformations> AllyCharactersInformations
        {
            get
            {
                return m_allyCharactersInformations;
            }
            set
            {
                m_allyCharactersInformations = value;
            }
        }
        
        private List<CharacterMinimalPlusLookInformations> m_enemyCharactersInformations;
        
        public virtual List<CharacterMinimalPlusLookInformations> EnemyCharactersInformations
        {
            get
            {
                return m_enemyCharactersInformations;
            }
            set
            {
                m_enemyCharactersInformations = value;
            }
        }
        
        private int m_collectorId;
        
        public virtual int CollectorId
        {
            get
            {
                return m_collectorId;
            }
            set
            {
                m_collectorId = value;
            }
        }
        
        public TaxCollectorFightersInformation(List<CharacterMinimalPlusLookInformations> allyCharactersInformations, List<CharacterMinimalPlusLookInformations> enemyCharactersInformations, int collectorId)
        {
            m_allyCharactersInformations = allyCharactersInformations;
            m_enemyCharactersInformations = enemyCharactersInformations;
            m_collectorId = collectorId;
        }
        
        public TaxCollectorFightersInformation()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_allyCharactersInformations.Count)));
            int allyCharactersInformationsIndex;
            for (allyCharactersInformationsIndex = 0; (allyCharactersInformationsIndex < m_allyCharactersInformations.Count); allyCharactersInformationsIndex = (allyCharactersInformationsIndex + 1))
            {
                CharacterMinimalPlusLookInformations objectToSend = m_allyCharactersInformations[allyCharactersInformationsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_enemyCharactersInformations.Count)));
            int enemyCharactersInformationsIndex;
            for (enemyCharactersInformationsIndex = 0; (enemyCharactersInformationsIndex < m_enemyCharactersInformations.Count); enemyCharactersInformationsIndex = (enemyCharactersInformationsIndex + 1))
            {
                CharacterMinimalPlusLookInformations objectToSend = m_enemyCharactersInformations[enemyCharactersInformationsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteInt(m_collectorId);
        }
        
        public void Deserialize(IDataReader reader)
        {
            int allyCharactersInformationsCount = reader.ReadUShort();
            int allyCharactersInformationsIndex;
            m_allyCharactersInformations = new System.Collections.Generic.List<CharacterMinimalPlusLookInformations>();
            for (allyCharactersInformationsIndex = 0; (allyCharactersInformationsIndex < allyCharactersInformationsCount); allyCharactersInformationsIndex = (allyCharactersInformationsIndex + 1))
            {
                CharacterMinimalPlusLookInformations objectToAdd = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_allyCharactersInformations.Add(objectToAdd);
            }
            int enemyCharactersInformationsCount = reader.ReadUShort();
            int enemyCharactersInformationsIndex;
            m_enemyCharactersInformations = new System.Collections.Generic.List<CharacterMinimalPlusLookInformations>();
            for (enemyCharactersInformationsIndex = 0; (enemyCharactersInformationsIndex < enemyCharactersInformationsCount); enemyCharactersInformationsIndex = (enemyCharactersInformationsIndex + 1))
            {
                CharacterMinimalPlusLookInformations objectToAdd = ProtocolTypeManager.GetInstance<CharacterMinimalPlusLookInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_enemyCharactersInformations.Add(objectToAdd);
            }
            m_collectorId = reader.ReadInt();
        }
    }
}
