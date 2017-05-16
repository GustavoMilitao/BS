//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Guild
{
    public class GuildInformationsGeneralMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5557;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_abandonnedPaddock;
        
        public virtual bool AbandonnedPaddock
        {
            get
            {
                return m_abandonnedPaddock;
            }
            set
            {
                m_abandonnedPaddock = value;
            }
        }
        
        private sbyte m_level;
        
        public virtual sbyte Level
        {
            get
            {
                return m_level;
            }
            set
            {
                m_level = value;
            }
        }
        
        private ulong m_expLevelFloor;
        
        public virtual ulong ExpLevelFloor
        {
            get
            {
                return m_expLevelFloor;
            }
            set
            {
                m_expLevelFloor = value;
            }
        }
        
        private ulong m_experience;
        
        public virtual ulong Experience
        {
            get
            {
                return m_experience;
            }
            set
            {
                m_experience = value;
            }
        }
        
        private ulong m_expNextLevelFloor;
        
        public virtual ulong ExpNextLevelFloor
        {
            get
            {
                return m_expNextLevelFloor;
            }
            set
            {
                m_expNextLevelFloor = value;
            }
        }
        
        private int m_creationDate;
        
        public virtual int CreationDate
        {
            get
            {
                return m_creationDate;
            }
            set
            {
                m_creationDate = value;
            }
        }
        
        private ushort m_nbTotalMembers;
        
        public virtual ushort NbTotalMembers
        {
            get
            {
                return m_nbTotalMembers;
            }
            set
            {
                m_nbTotalMembers = value;
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
        
        public GuildInformationsGeneralMessage(bool abandonnedPaddock, sbyte level, ulong expLevelFloor, ulong experience, ulong expNextLevelFloor, int creationDate, ushort nbTotalMembers, ushort nbConnectedMembers)
        {
            m_abandonnedPaddock = abandonnedPaddock;
            m_level = level;
            m_expLevelFloor = expLevelFloor;
            m_experience = experience;
            m_expNextLevelFloor = expNextLevelFloor;
            m_creationDate = creationDate;
            m_nbTotalMembers = nbTotalMembers;
            m_nbConnectedMembers = nbConnectedMembers;
        }
        
        public GuildInformationsGeneralMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_abandonnedPaddock);
            writer.WriteSByte(m_level);
            writer.WriteVarLong(m_expLevelFloor);
            writer.WriteVarLong(m_experience);
            writer.WriteVarLong(m_expNextLevelFloor);
            writer.WriteInt(m_creationDate);
            writer.WriteVarShort(m_nbTotalMembers);
            writer.WriteVarShort(m_nbConnectedMembers);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_abandonnedPaddock = reader.ReadBoolean();
            m_level = reader.ReadSByte();
            m_expLevelFloor = reader.ReadVarUhLong();
            m_experience = reader.ReadVarUhLong();
            m_expNextLevelFloor = reader.ReadVarUhLong();
            m_creationDate = reader.ReadInt();
            m_nbTotalMembers = reader.ReadVarUhShort();
            m_nbConnectedMembers = reader.ReadVarUhShort();
        }
    }
}
