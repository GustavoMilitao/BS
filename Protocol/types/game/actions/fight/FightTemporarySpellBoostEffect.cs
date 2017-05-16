//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Actions.Fight
{


    public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
    {
        
        protected override int ProtocolId { get; set; } = 207;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_boostedSpellId;
        
        public virtual ushort BoostedSpellId
        {
            get
            {
                return m_boostedSpellId;
            }
            set
            {
                m_boostedSpellId = value;
            }
        }
        
        public FightTemporarySpellBoostEffect(ushort boostedSpellId)
        {
            m_boostedSpellId = boostedSpellId;
        }
        
        public FightTemporarySpellBoostEffect()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_boostedSpellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_boostedSpellId = reader.ReadVarUhShort();
        }
    }
}
