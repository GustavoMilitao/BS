//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild.Tax
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GuildFightJoinRequestMessage : Message
    {
        
        public const int ProtocolId = 5717;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_taxCollectorId;
        
        public virtual int TaxCollectorId
        {
            get
            {
                return m_taxCollectorId;
            }
            set
            {
                m_taxCollectorId = value;
            }
        }
        
        public GuildFightJoinRequestMessage(int taxCollectorId)
        {
            m_taxCollectorId = taxCollectorId;
        }
        
        public GuildFightJoinRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_taxCollectorId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_taxCollectorId = reader.ReadInt();
        }
    }
}
