//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Data.Items.Effects
{


    public class ObjectEffectMount : ObjectEffect
    {
        
        protected override int ProtocolId { get; set; } = 179;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_mountId;
        
        public virtual int MountId
        {
            get
            {
                return m_mountId;
            }
            set
            {
                m_mountId = value;
            }
        }
        
        private double m_date;
        
        public virtual double Date
        {
            get
            {
                return m_date;
            }
            set
            {
                m_date = value;
            }
        }
        
        private ushort m_modelId;
        
        public virtual ushort ModelId
        {
            get
            {
                return m_modelId;
            }
            set
            {
                m_modelId = value;
            }
        }
        
        public ObjectEffectMount(int mountId, double date, ushort modelId)
        {
            m_mountId = mountId;
            m_date = date;
            m_modelId = modelId;
        }
        
        public ObjectEffectMount()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_mountId);
            writer.WriteDouble(m_date);
            writer.WriteVarShort(m_modelId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_mountId = reader.ReadInt();
            m_date = reader.ReadDouble();
            m_modelId = reader.ReadVarUhShort();
        }
    }
}
