//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Roleplay
{
    using BlueSheep.Common.Protocol.Types.Game.Guild;


    public class GuildInformations : BasicGuildInformations
    {
        
        public const int ProtocolId = 127;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildEmblem m_guildEmblem;
        
        public virtual GuildEmblem GuildEmblem
        {
            get
            {
                return m_guildEmblem;
            }
            set
            {
                m_guildEmblem = value;
            }
        }
        
        public GuildInformations(GuildEmblem guildEmblem)
        {
            m_guildEmblem = guildEmblem;
        }
        
        public GuildInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_guildEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guildEmblem = new GuildEmblem();
            m_guildEmblem.Deserialize(reader);
        }
    }
}
