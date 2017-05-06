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
    using BlueSheep.Common.Protocol.Types.Game.Character.Alignment;
    using BlueSheep.Common.Protocol.Types.Game.Look;
    using BlueSheep.Common.Protocol.Types.Game.Context;
    using BlueSheep.Common.Protocol.Types.Game.Character.Status;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class GameFightCharacterInformations : GameFightFighterNamedInformations
    {
        
        public new const int ID = 46;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private ActorAlignmentInformations m_alignmentInfos;
        
        public virtual ActorAlignmentInformations AlignmentInfos
        {
            get
            {
                return m_alignmentInfos;
            }
            set
            {
                m_alignmentInfos = value;
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
        
        private byte m_breed;
        
        public virtual byte Breed
        {
            get
            {
                return m_breed;
            }
            set
            {
                m_breed = value;
            }
        }
        
        private bool m_sex;
        
        public virtual bool Sex
        {
            get
            {
                return m_sex;
            }
            set
            {
                m_sex = value;
            }
        }
        
        public GameFightCharacterInformations(ActorAlignmentInformations alignmentInfos, sbyte level, byte breed, bool sex)
        {
            m_alignmentInfos = alignmentInfos;
            m_level = level;
            m_breed = breed;
            m_sex = sex;
        }
        
        public GameFightCharacterInformations()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_alignmentInfos.Serialize(writer);
            writer.WriteSByte(m_level);
            writer.WriteByte(m_breed);
            writer.WriteBoolean(m_sex);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_alignmentInfos = new ActorAlignmentInformations();
            m_alignmentInfos.Deserialize(reader);
            m_level = reader.ReadSByte();
            m_breed = reader.ReadByte();
            m_sex = reader.ReadBoolean();
        }
    }
}
