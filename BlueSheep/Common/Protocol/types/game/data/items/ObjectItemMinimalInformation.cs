//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Data.Items
{
    using BlueSheep.Common.Protocol.Types.Game.Data.Items.Effects;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class ObjectItemMinimalInformation : Item
    {
        
        public new const int ID = 124;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private List<ObjectEffect> m_effects;
        
        public virtual List<ObjectEffect> Effects
        {
            get
            {
                return m_effects;
            }
            set
            {
                m_effects = value;
            }
        }
        
        private ushort m_objectGID;
        
        public virtual ushort ObjectGID
        {
            get
            {
                return m_objectGID;
            }
            set
            {
                m_objectGID = value;
            }
        }
        
        public ObjectItemMinimalInformation(List<ObjectEffect> effects, ushort objectGID)
        {
            m_effects = effects;
            m_objectGID = objectGID;
        }
        
        public ObjectItemMinimalInformation()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_effects.Count)));
            int effectsIndex;
            for (effectsIndex = 0; (effectsIndex < m_effects.Count); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToSend = m_effects[effectsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteVarShort(m_objectGID);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int effectsCount = reader.ReadUShort();
            int effectsIndex;
            m_effects = new System.Collections.Generic.List<ObjectEffect>();
            for (effectsIndex = 0; (effectsIndex < effectsCount); effectsIndex = (effectsIndex + 1))
            {
                ObjectEffect objectToAdd = ProtocolTypeManager.GetInstance<ObjectEffect>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_effects.Add(objectToAdd);
            }
            m_objectGID = reader.ReadVarUhShort();
        }
    }
}
