//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{


    public class TreasureHuntStepFollowDirectionToPOI : TreasureHuntStep
    {
        
        protected override int ProtocolId { get; set; } = 461;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_direction;
        
        public virtual byte Direction
        {
            get
            {
                return m_direction;
            }
            set
            {
                m_direction = value;
            }
        }
        
        private ushort m_poiLabelId;
        
        public virtual ushort PoiLabelId
        {
            get
            {
                return m_poiLabelId;
            }
            set
            {
                m_poiLabelId = value;
            }
        }
        
        public TreasureHuntStepFollowDirectionToPOI(byte direction, ushort poiLabelId)
        {
            m_direction = direction;
            m_poiLabelId = poiLabelId;
        }
        
        public TreasureHuntStepFollowDirectionToPOI()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_direction);
            writer.WriteVarShort(m_poiLabelId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_direction = reader.ReadByte();
            m_poiLabelId = reader.ReadVarUhShort();
        }
    }
}
