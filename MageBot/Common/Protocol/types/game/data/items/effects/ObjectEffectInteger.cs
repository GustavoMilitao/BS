//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Data.Items.Effects
{


    public class ObjectEffectInteger : ObjectEffect
    {
        
        public const int ProtocolId = 70;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_value;
        
        public virtual ushort Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
        
        public ObjectEffectInteger(ushort value)
        {
            m_value = value;
        }
        
        public ObjectEffectInteger()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarShort(m_value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_value = reader.ReadVarUhShort();
        }
    }
}
