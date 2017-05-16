//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Roleplay
{
    using BlueSheep.Protocol.Types;


    public class MonsterInGroupLightInformations : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 395;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_creatureGenericId;
        
        public virtual int CreatureGenericId
        {
            get
            {
                return m_creatureGenericId;
            }
            set
            {
                m_creatureGenericId = value;
            }
        }
        
        private byte m_grade;
        
        public virtual byte Grade
        {
            get
            {
                return m_grade;
            }
            set
            {
                m_grade = value;
            }
        }
        
        public MonsterInGroupLightInformations(int creatureGenericId, byte grade)
        {
            m_creatureGenericId = creatureGenericId;
            m_grade = grade;
        }
        
        public MonsterInGroupLightInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_creatureGenericId);
            writer.WriteByte(m_grade);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_creatureGenericId = reader.ReadInt();
            m_grade = reader.ReadByte();
        }
    }
}
