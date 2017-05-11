//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Alliance
{
    using BlueSheep.Protocol.Types.Game.Context.Roleplay;
    using BlueSheep.Protocol;


    public class AllianceInvitedMessage : Message
    {
        
        public const int ProtocolId = 6397;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private BasicNamedAllianceInformations m_allianceInfo;
        
        public virtual BasicNamedAllianceInformations AllianceInfo
        {
            get
            {
                return m_allianceInfo;
            }
            set
            {
                m_allianceInfo = value;
            }
        }
        
        private ulong m_recruterId;
        
        public virtual ulong RecruterId
        {
            get
            {
                return m_recruterId;
            }
            set
            {
                m_recruterId = value;
            }
        }
        
        private string m_recruterName;
        
        public virtual string RecruterName
        {
            get
            {
                return m_recruterName;
            }
            set
            {
                m_recruterName = value;
            }
        }
        
        public AllianceInvitedMessage(BasicNamedAllianceInformations allianceInfo, ulong recruterId, string recruterName)
        {
            m_allianceInfo = allianceInfo;
            m_recruterId = recruterId;
            m_recruterName = recruterName;
        }
        
        public AllianceInvitedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_allianceInfo.Serialize(writer);
            writer.WriteVarLong(m_recruterId);
            writer.WriteUTF(m_recruterName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_allianceInfo = new BasicNamedAllianceInformations();
            m_allianceInfo.Deserialize(reader);
            m_recruterId = reader.ReadVarUhLong();
            m_recruterName = reader.ReadUTF();
        }
    }
}