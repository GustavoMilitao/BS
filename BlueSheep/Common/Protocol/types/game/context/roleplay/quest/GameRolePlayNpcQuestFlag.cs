//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.Quest
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Types;


    public class GameRolePlayNpcQuestFlag : NetworkType
    {
        
        public const int ProtocolId = 384;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt16> m_questsToValidId;
        
        public virtual List<System.UInt16> QuestsToValidId
        {
            get
            {
                return m_questsToValidId;
            }
            set
            {
                m_questsToValidId = value;
            }
        }
        
        private List<System.UInt16> m_questsToStartId;
        
        public virtual List<System.UInt16> QuestsToStartId
        {
            get
            {
                return m_questsToStartId;
            }
            set
            {
                m_questsToStartId = value;
            }
        }
        
        public GameRolePlayNpcQuestFlag(List<System.UInt16> questsToValidId, List<System.UInt16> questsToStartId)
        {
            m_questsToValidId = questsToValidId;
            m_questsToStartId = questsToStartId;
        }
        
        public GameRolePlayNpcQuestFlag()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_questsToValidId.Count)));
            int questsToValidIdIndex;
            for (questsToValidIdIndex = 0; (questsToValidIdIndex < m_questsToValidId.Count); questsToValidIdIndex = (questsToValidIdIndex + 1))
            {
                writer.WriteVarShort(m_questsToValidId[questsToValidIdIndex]);
            }
            writer.WriteShort(((short)(m_questsToStartId.Count)));
            int questsToStartIdIndex;
            for (questsToStartIdIndex = 0; (questsToStartIdIndex < m_questsToStartId.Count); questsToStartIdIndex = (questsToStartIdIndex + 1))
            {
                writer.WriteVarShort(m_questsToStartId[questsToStartIdIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int questsToValidIdCount = reader.ReadUShort();
            int questsToValidIdIndex;
            m_questsToValidId = new System.Collections.Generic.List<ushort>();
            for (questsToValidIdIndex = 0; (questsToValidIdIndex < questsToValidIdCount); questsToValidIdIndex = (questsToValidIdIndex + 1))
            {
                m_questsToValidId.Add(reader.ReadVarUhShort());
            }
            int questsToStartIdCount = reader.ReadUShort();
            int questsToStartIdIndex;
            m_questsToStartId = new System.Collections.Generic.List<ushort>();
            for (questsToStartIdIndex = 0; (questsToStartIdIndex < questsToStartIdCount); questsToStartIdIndex = (questsToStartIdIndex + 1))
            {
                m_questsToStartId.Add(reader.ReadVarUhShort());
            }
        }
    }
}
