//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Interactive.Skill
{


    public class SkillActionDescriptionCraft : SkillActionDescription
    {
        
        public const int ProtocolId = 100;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_probability;
        
        public virtual byte Probability
        {
            get
            {
                return m_probability;
            }
            set
            {
                m_probability = value;
            }
        }
        
        public SkillActionDescriptionCraft(byte probability)
        {
            m_probability = probability;
        }
        
        public SkillActionDescriptionCraft()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_probability);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_probability = reader.ReadByte();
        }
    }
}
