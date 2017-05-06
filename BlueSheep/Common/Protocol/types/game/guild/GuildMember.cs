//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Guild
{
    using BlueSheep.Common.Protocol.Types.Game.Character;
    using BlueSheep.Common.Protocol.Types.Game.Character.Status;
    using BlueSheep.Common.Protocol;


    public class GuildMember : CharacterMinimalInformations
    {
        
        public const int ProtocolId = 88;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_sex;
        
        public virtual bool Sex
        {
            get
            {
                return m_sex;
            }
            set
            {
                m_sex = value;
            }
        }
        
        private bool m_havenBagShared;
        
        public virtual bool HavenBagShared
        {
            get
            {
                return m_havenBagShared;
            }
            set
            {
                m_havenBagShared = value;
            }
        }
        
        private PlayerStatus m_status;
        
        public virtual PlayerStatus Status
        {
            get
            {
                return m_status;
            }
            set
            {
                m_status = value;
            }
        }
        
        private byte m_breed;
        
        public virtual byte Breed
        {
            get
            {
                return m_breed;
            }
            set
            {
                m_breed = value;
            }
        }
        
        private ushort m_rank;
        
        public virtual ushort Rank
        {
            get
            {
                return m_rank;
            }
            set
            {
                m_rank = value;
            }
        }
        
        private ulong m_givenExperience;
        
        public virtual ulong GivenExperience
        {
            get
            {
                return m_givenExperience;
            }
            set
            {
                m_givenExperience = value;
            }
        }
        
        private byte m_experienceGivenPercent;
        
        public virtual byte ExperienceGivenPercent
        {
            get
            {
                return m_experienceGivenPercent;
            }
            set
            {
                m_experienceGivenPercent = value;
            }
        }
        
        private uint m_rights;
        
        public virtual uint Rights
        {
            get
            {
                return m_rights;
            }
            set
            {
                m_rights = value;
            }
        }
        
        private byte m_connected;
        
        public virtual byte Connected
        {
            get
            {
                return m_connected;
            }
            set
            {
                m_connected = value;
            }
        }
        
        private byte m_alignmentSide;
        
        public virtual byte AlignmentSide
        {
            get
            {
                return m_alignmentSide;
            }
            set
            {
                m_alignmentSide = value;
            }
        }
        
        private ushort m_hoursSinceLastConnection;
        
        public virtual ushort HoursSinceLastConnection
        {
            get
            {
                return m_hoursSinceLastConnection;
            }
            set
            {
                m_hoursSinceLastConnection = value;
            }
        }
        
        private ushort m_moodSmileyId;
        
        public virtual ushort MoodSmileyId
        {
            get
            {
                return m_moodSmileyId;
            }
            set
            {
                m_moodSmileyId = value;
            }
        }
        
        private int m_accountId;
        
        public virtual int AccountId
        {
            get
            {
                return m_accountId;
            }
            set
            {
                m_accountId = value;
            }
        }
        
        private int m_achievementPoints;
        
        public virtual int AchievementPoints
        {
            get
            {
                return m_achievementPoints;
            }
            set
            {
                m_achievementPoints = value;
            }
        }
        
        public GuildMember(bool sex, bool havenBagShared, PlayerStatus status, byte breed, ushort rank, ulong givenExperience, byte experienceGivenPercent, uint rights, byte connected, byte alignmentSide, ushort hoursSinceLastConnection, ushort moodSmileyId, int accountId, int achievementPoints)
        {
            m_sex = sex;
            m_havenBagShared = havenBagShared;
            m_status = status;
            m_breed = breed;
            m_rank = rank;
            m_givenExperience = givenExperience;
            m_experienceGivenPercent = experienceGivenPercent;
            m_rights = rights;
            m_connected = connected;
            m_alignmentSide = alignmentSide;
            m_hoursSinceLastConnection = hoursSinceLastConnection;
            m_moodSmileyId = moodSmileyId;
            m_accountId = accountId;
            m_achievementPoints = achievementPoints;
        }
        
        public GuildMember()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_sex);
            BooleanByteWrapper.SetFlag(1, flag, m_havenBagShared);
            writer.WriteByte(flag);
            writer.WriteUShort(((ushort)(m_status.TypeID)));
            m_status.Serialize(writer);
            writer.WriteByte(m_breed);
            writer.WriteVarShort(m_rank);
            writer.WriteVarLong(m_givenExperience);
            writer.WriteByte(m_experienceGivenPercent);
            writer.WriteVarInt(m_rights);
            writer.WriteByte(m_connected);
            writer.WriteByte(m_alignmentSide);
            writer.WriteUShort(m_hoursSinceLastConnection);
            writer.WriteVarShort(m_moodSmileyId);
            writer.WriteInt(m_accountId);
            writer.WriteInt(m_achievementPoints);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            byte flag = reader.ReadByte();
            m_sex = BooleanByteWrapper.GetFlag(flag, 0);
            m_havenBagShared = BooleanByteWrapper.GetFlag(flag, 1);
            m_status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
            m_status.Deserialize(reader);
            m_breed = reader.ReadByte();
            m_rank = reader.ReadVarUhShort();
            m_givenExperience = reader.ReadVarUhLong();
            m_experienceGivenPercent = reader.ReadByte();
            m_rights = reader.ReadVarUhInt();
            m_connected = reader.ReadByte();
            m_alignmentSide = reader.ReadByte();
            m_hoursSinceLastConnection = reader.ReadUShort();
            m_moodSmileyId = reader.ReadVarUhShort();
            m_accountId = reader.ReadInt();
            m_achievementPoints = reader.ReadInt();
        }
    }
}
