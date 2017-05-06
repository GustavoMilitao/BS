//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Fight
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class FightTeamMemberCharacterInformations : FightTeamMemberInformations
    {
        
        public new const int ID = 13;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        public FightTeamMemberCharacterInformations(string name, sbyte level)
        {
            m_name = name;
            m_level = level;
        }
        
        public FightTeamMemberCharacterInformations()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_name);
            writer.WriteSByte(m_level);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_name = reader.ReadUTF();
            m_level = reader.ReadSByte();
        }
    }
}
