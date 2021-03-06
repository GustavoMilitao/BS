//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Security
{
    using BlueSheep.Common;


    public class CheckFileRequestMessage : Message
    {
        
        public const int ProtocolId = 6154;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_filename;
        
        public virtual string Filename
        {
            get
            {
                return m_filename;
            }
            set
            {
                m_filename = value;
            }
        }
        
        private byte m_type;
        
        public virtual byte Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        
        public CheckFileRequestMessage(string filename, byte type)
        {
            m_filename = filename;
            m_type = type;
        }
        
        public CheckFileRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_filename);
            writer.WriteByte(m_type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_filename = reader.ReadUTF();
            m_type = reader.ReadByte();
        }
    }
}
