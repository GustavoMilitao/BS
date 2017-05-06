//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context
{


    public class GameContextRemoveElementWithEventMessage : GameContextRemoveElementMessage
    {
        
        public const int ProtocolId = 6412;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_elementEventId;
        
        public virtual byte ElementEventId
        {
            get
            {
                return m_elementEventId;
            }
            set
            {
                m_elementEventId = value;
            }
        }
        
        public GameContextRemoveElementWithEventMessage(byte elementEventId)
        {
            m_elementEventId = elementEventId;
        }
        
        public GameContextRemoveElementWithEventMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_elementEventId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_elementEventId = reader.ReadByte();
        }
    }
}
