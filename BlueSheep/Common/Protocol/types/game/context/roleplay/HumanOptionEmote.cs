//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Roleplay
{


    public class HumanOptionEmote : HumanOption
    {
        
        public const int ProtocolId = 407;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_emoteId;
        
        public virtual sbyte EmoteId
        {
            get
            {
                return m_emoteId;
            }
            set
            {
                m_emoteId = value;
            }
        }
        
        private double m_emoteStartTime;
        
        public virtual double EmoteStartTime
        {
            get
            {
                return m_emoteStartTime;
            }
            set
            {
                m_emoteStartTime = value;
            }
        }
        
        public HumanOptionEmote(sbyte emoteId, double emoteStartTime)
        {
            m_emoteId = emoteId;
            m_emoteStartTime = emoteStartTime;
        }
        
        public HumanOptionEmote()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(m_emoteId);
            writer.WriteDouble(m_emoteStartTime);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_emoteId = reader.ReadSByte();
            m_emoteStartTime = reader.ReadDouble();
        }
    }
}
