//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Chat
{


    public class ChatClientMultiMessage : ChatAbstractClientMessage
    {
        
        public const int ProtocolId = 861;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_channel;
        
        public virtual byte Channel
        {
            get
            {
                return m_channel;
            }
            set
            {
                m_channel = value;
            }
        }
        
        public ChatClientMultiMessage(byte channel)
        {
            m_channel = channel;
        }

        public ChatClientMultiMessage(string content, byte channel) : base(content)
        {
            m_channel = channel;
        }

        public ChatClientMultiMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_channel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_channel = reader.ReadByte();
        }
    }
}