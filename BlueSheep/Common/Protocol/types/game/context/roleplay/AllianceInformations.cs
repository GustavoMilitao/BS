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


    public class AllianceInformations : BasicNamedAllianceInformations
    {
        
        public const int ProtocolId = 417;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GuildEmblem m_allianceEmblem;
        
        public virtual GuildEmblem AllianceEmblem
        {
            get
            {
                return m_allianceEmblem;
            }
            set
            {
                m_allianceEmblem = value;
            }
        }
        
        public AllianceInformations(GuildEmblem allianceEmblem)
        {
            m_allianceEmblem = allianceEmblem;
        }
        
        public AllianceInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_allianceEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_allianceEmblem = new GuildEmblem();
            m_allianceEmblem.Deserialize(reader);
        }
    }
}
