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


    public class FightTemporaryBoostStateEffect : FightTemporaryBoostEffect
    {
        
        protected override int ProtocolId { get; set; } = 214;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_stateId;
        
        public virtual short StateId
        {
            get
            {
                return m_stateId;
            }
            set
            {
                m_stateId = value;
            }
        }
        
        public FightTemporaryBoostStateEffect(short stateId)
        {
            m_stateId = stateId;
        }
        
        public FightTemporaryBoostStateEffect()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(m_stateId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_stateId = reader.ReadShort();
        }
    }
}
