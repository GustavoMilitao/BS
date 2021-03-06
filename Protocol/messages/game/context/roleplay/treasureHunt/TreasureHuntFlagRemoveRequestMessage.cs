//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    public class TreasureHuntFlagRemoveRequestMessage : Message
    {
        
        public override int ProtocolId { get; } = 6510;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_questType;
        
        public virtual byte QuestType
        {
            get
            {
                return m_questType;
            }
            set
            {
                m_questType = value;
            }
        }
        
        private byte m_index;
        
        public virtual byte Index
        {
            get
            {
                return m_index;
            }
            set
            {
                m_index = value;
            }
        }
        
        public TreasureHuntFlagRemoveRequestMessage(byte questType, byte index)
        {
            m_questType = questType;
            m_index = index;
        }
        
        public TreasureHuntFlagRemoveRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_questType);
            writer.WriteByte(m_index);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_questType = reader.ReadByte();
            m_index = reader.ReadByte();
        }
    }
}
