//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Character.Stats
{
    using MageBot.Protocol.Types.Game.Character.Characteristic;


    public class CharacterStatsListMessage : Message
    {
        
        public override int ProtocolId { get; } = 500;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterCharacteristicsInformations m_stats;
        
        public virtual CharacterCharacteristicsInformations Stats
        {
            get
            {
                return m_stats;
            }
            set
            {
                m_stats = value;
            }
        }
        
        public CharacterStatsListMessage(CharacterCharacteristicsInformations stats)
        {
            m_stats = stats;
        }
        
        public CharacterStatsListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_stats.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_stats = new CharacterCharacteristicsInformations();
            m_stats.Deserialize(reader);
        }
    }
}
