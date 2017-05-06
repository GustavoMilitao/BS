//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameFightHumanReadyStateMessage : Message
    {
        
        public const int ProtocolId = 740;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_characterId;
        
        public virtual ulong CharacterId
        {
            get
            {
                return m_characterId;
            }
            set
            {
                m_characterId = value;
            }
        }
        
        private bool m_isReady;
        
        public virtual bool IsReady
        {
            get
            {
                return m_isReady;
            }
            set
            {
                m_isReady = value;
            }
        }
        
        public GameFightHumanReadyStateMessage(ulong characterId, bool isReady)
        {
            m_characterId = characterId;
            m_isReady = isReady;
        }
        
        public GameFightHumanReadyStateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_characterId);
            writer.WriteBoolean(m_isReady);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_characterId = reader.ReadVarUhLong();
            m_isReady = reader.ReadBoolean();
        }
    }
}
