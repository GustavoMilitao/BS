//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Types.Game.Context.Roleplay
{
    using MageBot.Protocol.Types.Game.Context.Roleplay.Quest;


    public class GameRolePlayNpcWithQuestInformations : GameRolePlayNpcInformations
    {
        
        public override int ProtocolId { get; } = 383;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GameRolePlayNpcQuestFlag m_questFlag;
        
        public virtual GameRolePlayNpcQuestFlag QuestFlag
        {
            get
            {
                return m_questFlag;
            }
            set
            {
                m_questFlag = value;
            }
        }
        
        public GameRolePlayNpcWithQuestInformations(GameRolePlayNpcQuestFlag questFlag)
        {
            m_questFlag = questFlag;
        }
        
        public GameRolePlayNpcWithQuestInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_questFlag.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_questFlag = new GameRolePlayNpcQuestFlag();
            m_questFlag.Deserialize(reader);
        }
    }
}
