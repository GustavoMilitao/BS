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
    using MageBot.Protocol.Types.Game.Look;


    public class MonsterInGroupInformations : MonsterInGroupLightInformations
    {
        
        public override int ProtocolId { get; } = 144;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private EntityLook m_look;
        
        public virtual EntityLook Look
        {
            get
            {
                return m_look;
            }
            set
            {
                m_look = value;
            }
        }
        
        public MonsterInGroupInformations(EntityLook look)
        {
            m_look = look;
        }
        
        public MonsterInGroupInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_look.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_look = new EntityLook();
            m_look.Deserialize(reader);
        }
    }
}
