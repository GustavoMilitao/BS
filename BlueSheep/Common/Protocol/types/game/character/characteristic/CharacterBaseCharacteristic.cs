//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Character.Characteristic
{
    using BlueSheep.Common.Protocol.Types;


    public class CharacterBaseCharacteristic : NetworkType
    {
        
        public const int ProtocolId = 4;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private short m_base;
        
        public virtual short Base
        {
            get
            {
                return m_base;
            }
            set
            {
                m_base = value;
            }
        }
        
        private short m_additionnal;
        
        public virtual short Additionnal
        {
            get
            {
                return m_additionnal;
            }
            set
            {
                m_additionnal = value;
            }
        }
        
        private short m_objectsAndMountBonus;
        
        public virtual short ObjectsAndMountBonus
        {
            get
            {
                return m_objectsAndMountBonus;
            }
            set
            {
                m_objectsAndMountBonus = value;
            }
        }
        
        private short m_alignGiftBonus;
        
        public virtual short AlignGiftBonus
        {
            get
            {
                return m_alignGiftBonus;
            }
            set
            {
                m_alignGiftBonus = value;
            }
        }
        
        private short m_contextModif;
        
        public virtual short ContextModif
        {
            get
            {
                return m_contextModif;
            }
            set
            {
                m_contextModif = value;
            }
        }
        
        public CharacterBaseCharacteristic(short @base, short additionnal, short objectsAndMountBonus, short alignGiftBonus, short contextModif)
        {
            m_base = @base;
            m_additionnal = additionnal;
            m_objectsAndMountBonus = objectsAndMountBonus;
            m_alignGiftBonus = alignGiftBonus;
            m_contextModif = contextModif;
        }
        
        public CharacterBaseCharacteristic()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_base);
            writer.WriteVarShort(m_additionnal);
            writer.WriteVarShort(m_objectsAndMountBonus);
            writer.WriteVarShort(m_alignGiftBonus);
            writer.WriteVarShort(m_contextModif);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_base = reader.ReadVarShort();
            m_additionnal = reader.ReadVarShort();
            m_objectsAndMountBonus = reader.ReadVarShort();
            m_alignGiftBonus = reader.ReadVarShort();
            m_contextModif = reader.ReadVarShort();
        }
    }
}
