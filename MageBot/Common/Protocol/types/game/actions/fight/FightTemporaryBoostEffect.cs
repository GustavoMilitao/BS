//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Actions.Fight
{


    public class FightTemporaryBoostEffect : AbstractFightDispellableEffect
    {
        
        public const int ProtocolId = 209;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_delta;
        
        public virtual short Delta
        {
            get
            {
                return m_delta;
            }
            set
            {
                m_delta = value;
            }
        }
        
        public FightTemporaryBoostEffect(short delta)
        {
            m_delta = delta;
        }
        
        public FightTemporaryBoostEffect()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(m_delta);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_delta = reader.ReadShort();
        }
    }
}