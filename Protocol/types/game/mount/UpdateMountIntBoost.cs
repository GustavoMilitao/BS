//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Mount
{


    public class UpdateMountIntBoost : UpdateMountBoost
    {
        
        protected override int ProtocolId { get; set; } = 357;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_value;
        
        public virtual int Value
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
        
        public UpdateMountIntBoost(int value)
        {
            m_value = value;
        }
        
        public UpdateMountIntBoost()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_value);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_value = reader.ReadInt();
        }
    }
}
