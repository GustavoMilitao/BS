//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Social
{


    public class GuildInsiderFactSheetInformations : GuildFactSheetInformations
    {
        
        public const int ProtocolId = 423;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_leaderName;
        
        public virtual string LeaderName
        {
            get
            {
                return m_leaderName;
            }
            set
            {
                m_leaderName = value;
            }
        }
        
        private ushort m_nbConnectedMembers;
        
        public virtual ushort NbConnectedMembers
        {
            get
            {
                return m_nbConnectedMembers;
            }
            set
            {
                m_nbConnectedMembers = value;
            }
        }
        
        private byte m_nbTaxCollectors;
        
        public virtual byte NbTaxCollectors
        {
            get
            {
                return m_nbTaxCollectors;
            }
            set
            {
                m_nbTaxCollectors = value;
            }
        }
        
        private int m_lastActivity;
        
        public virtual int LastActivity
        {
            get
            {
                return m_lastActivity;
            }
            set
            {
                m_lastActivity = value;
            }
        }
        
        public GuildInsiderFactSheetInformations(string leaderName, ushort nbConnectedMembers, byte nbTaxCollectors, int lastActivity)
        {
            m_leaderName = leaderName;
            m_nbConnectedMembers = nbConnectedMembers;
            m_nbTaxCollectors = nbTaxCollectors;
            m_lastActivity = lastActivity;
        }
        
        public GuildInsiderFactSheetInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_leaderName);
            writer.WriteVarShort(m_nbConnectedMembers);
            writer.WriteByte(m_nbTaxCollectors);
            writer.WriteInt(m_lastActivity);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_leaderName = reader.ReadUTF();
            m_nbConnectedMembers = reader.ReadVarUhShort();
            m_nbTaxCollectors = reader.ReadByte();
            m_lastActivity = reader.ReadInt();
        }
    }
}
