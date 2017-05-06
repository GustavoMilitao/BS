//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Actions.Sequence
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class SequenceStartMessage : Message
    {
        
        public const int ProtocolId = 955;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_sequenceType;
        
        public virtual byte SequenceType
        {
            get
            {
                return m_sequenceType;
            }
            set
            {
                m_sequenceType = value;
            }
        }
        
        private double m_authorId;
        
        public virtual double AuthorId
        {
            get
            {
                return m_authorId;
            }
            set
            {
                m_authorId = value;
            }
        }
        
        public SequenceStartMessage(byte sequenceType, double authorId)
        {
            m_sequenceType = sequenceType;
            m_authorId = authorId;
        }
        
        public SequenceStartMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_sequenceType);
            writer.WriteDouble(m_authorId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_sequenceType = reader.ReadByte();
            m_authorId = reader.ReadDouble();
        }
    }
}
