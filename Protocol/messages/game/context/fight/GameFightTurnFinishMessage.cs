//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Fight
{
    public class GameFightTurnFinishMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 718;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_isAfk;
        
        public virtual bool IsAfk
        {
            get
            {
                return m_isAfk;
            }
            set
            {
                m_isAfk = value;
            }
        }
        
        public GameFightTurnFinishMessage(bool isAfk)
        {
            m_isAfk = isAfk;
        }
        
        public GameFightTurnFinishMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_isAfk);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_isAfk = reader.ReadBoolean();
        }
    }
}
