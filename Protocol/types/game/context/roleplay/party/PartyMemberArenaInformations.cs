//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Roleplay.Party
{


    public class PartyMemberArenaInformations : PartyMemberInformations
    {
        
        protected override int ProtocolId { get; set; } = 391;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_rank;
        
        public virtual ushort Rank
        {
            get
            {
                return m_rank;
            }
            set
            {
                m_rank = value;
            }
        }
        
        public PartyMemberArenaInformations(ushort rank)
        {
            m_rank = rank;
        }
        
        public PartyMemberArenaInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_rank);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_rank = reader.ReadVarUhShort();
        }
    }
}
