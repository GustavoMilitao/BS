//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Paddock
{


    public class PaddockAbandonnedInformations : PaddockBuyableInformations
    {
        
        public const int ProtocolId = 133;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_guildId;
        
        public virtual int GuildId
        {
            get
            {
                return m_guildId;
            }
            set
            {
                m_guildId = value;
            }
        }
        
        public PaddockAbandonnedInformations(int guildId)
        {
            m_guildId = guildId;
        }
        
        public PaddockAbandonnedInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_guildId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_guildId = reader.ReadInt();
        }
    }
}
