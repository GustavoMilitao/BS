//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Fight
{


    public class GameFightFighterCompanionLightInformations : GameFightFighterLightInformations
    {
        
        protected override int ProtocolId { get; set; } = 454;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_companionId;
        
        public virtual byte CompanionId
        {
            get
            {
                return m_companionId;
            }
            set
            {
                m_companionId = value;
            }
        }
        
        private double m_masterId;
        
        public virtual double MasterId
        {
            get
            {
                return m_masterId;
            }
            set
            {
                m_masterId = value;
            }
        }
        
        public GameFightFighterCompanionLightInformations(byte companionId, double masterId)
        {
            m_companionId = companionId;
            m_masterId = masterId;
        }
        
        public GameFightFighterCompanionLightInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_companionId);
            writer.WriteDouble(m_masterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_companionId = reader.ReadByte();
            m_masterId = reader.ReadDouble();
        }
    }
}
