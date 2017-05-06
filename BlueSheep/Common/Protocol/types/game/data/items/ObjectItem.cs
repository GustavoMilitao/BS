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
    using System.Collections.Generic;


    public class ObjectItem : Item
    {
        
        public const int ProtocolId = 37;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
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
        
        private sbyte m_position;
        
        public virtual sbyte Position
        {
            get
            {
                return m_position;
            }
            set
            {
                m_position = value;
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
        
        private uint m_objectUID;
        
        public virtual uint ObjectUID
        {
            get
            {
                return m_objectUID;
            }
            set
            {
                m_objectUID = value;
            }
        }
        
        private uint m_quantity;
        
        public virtual uint Quantity
        {
            get
            {
                return m_quantity;
            }
            set
            {
                m_quantity = value;
            }
        }
        
        public ObjectItem(List<ObjectEffect> effects, sbyte position, ushort objectGID, uint objectUID, uint quantity)
        {
            m_effects = effects;
            m_position = position;
            m_objectGID = objectGID;
            m_objectUID = objectUID;
            m_quantity = quantity;
        }
        
        public ObjectItem()
        {
        }
        
        public override void Serialize(IDataWriter writer)
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
            writer.WriteSByte(m_position);
            writer.WriteVarShort(m_objectGID);
            writer.WriteVarInt(m_objectUID);
            writer.WriteVarInt(m_quantity);
        }
        
        public override void Deserialize(IDataReader reader)
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
            m_position = reader.ReadSByte();
            m_objectGID = reader.ReadVarUhShort();
            m_objectUID = reader.ReadVarUhInt();
            m_quantity = reader.ReadVarUhInt();
        }
    }
}
