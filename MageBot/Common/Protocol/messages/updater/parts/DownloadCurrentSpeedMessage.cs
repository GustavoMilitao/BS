//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Updater.Parts
{
    using BlueSheep.Common;


    public class DownloadCurrentSpeedMessage : Message
    {
        
        public const int ProtocolId = 1511;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_downloadSpeed;
        
        public virtual byte DownloadSpeed
        {
            get
            {
                return m_downloadSpeed;
            }
            set
            {
                m_downloadSpeed = value;
            }
        }
        
        public DownloadCurrentSpeedMessage(byte downloadSpeed)
        {
            m_downloadSpeed = downloadSpeed;
        }
        
        public DownloadCurrentSpeedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_downloadSpeed);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_downloadSpeed = reader.ReadByte();
        }
    }
}
