//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Character.Choice
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class CharacterToRemodelInformations : CharacterRemodelingInformation
    {
        
        public new const int ID = 477;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_possibleChangeMask;
        
        public virtual byte PossibleChangeMask
        {
            get
            {
                return m_possibleChangeMask;
            }
            set
            {
                m_possibleChangeMask = value;
            }
        }
        
        private byte m_mandatoryChangeMask;
        
        public virtual byte MandatoryChangeMask
        {
            get
            {
                return m_mandatoryChangeMask;
            }
            set
            {
                m_mandatoryChangeMask = value;
            }
        }
        
        public CharacterToRemodelInformations(byte possibleChangeMask, byte mandatoryChangeMask)
        {
            m_possibleChangeMask = possibleChangeMask;
            m_mandatoryChangeMask = mandatoryChangeMask;
        }
        
        public CharacterToRemodelInformations()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_possibleChangeMask);
            writer.WriteByte(m_mandatoryChangeMask);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_possibleChangeMask = reader.ReadByte();
            m_mandatoryChangeMask = reader.ReadByte();
        }
    }
}
