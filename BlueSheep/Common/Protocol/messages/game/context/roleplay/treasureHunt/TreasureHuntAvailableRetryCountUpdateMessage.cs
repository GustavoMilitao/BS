//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.TreasureHunt
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class TreasureHuntAvailableRetryCountUpdateMessage : Message
    {
        
        public const int ProtocolId = 6491;
        
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
        
        private int m_availableRetryCount;
        
        public virtual int AvailableRetryCount
        {
            get
            {
                return m_availableRetryCount;
            }
            set
            {
                m_availableRetryCount = value;
            }
        }
        
        public TreasureHuntAvailableRetryCountUpdateMessage(byte questType, int availableRetryCount)
        {
            m_questType = questType;
            m_availableRetryCount = availableRetryCount;
        }
        
        public TreasureHuntAvailableRetryCountUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_questType);
            writer.WriteInt(m_availableRetryCount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_questType = reader.ReadByte();
            m_availableRetryCount = reader.ReadInt();
        }
    }
}
