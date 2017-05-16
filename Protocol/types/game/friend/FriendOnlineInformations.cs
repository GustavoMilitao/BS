//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Friend
{
    using BlueSheep.Protocol.Types.Game.Character.Status;
    using BlueSheep.Protocol.Types.Game.Context.Roleplay;


    public class FriendOnlineInformations : FriendInformations
    {
        
        protected override int ProtocolId { get; set; } = 92;
        
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
        
        private GuildInformations m_guildInfo;
        
        public virtual GuildInformations GuildInfo
        {
            get
            {
                return m_guildInfo;
            }
            set
            {
                m_guildInfo = value;
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
        
        private ulong m_playerId;
        
        public virtual ulong PlayerId
        {
            get
            {
                return m_playerId;
            }
            set
            {
                m_playerId = value;
            }
        }
        
        private string m_playerName;
        
        public virtual string PlayerName
        {
            get
            {
                return m_playerName;
            }
            set
            {
                m_playerName = value;
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
        
        public FriendOnlineInformations(bool sex, bool havenBagShared, GuildInformations guildInfo, PlayerStatus status, ulong playerId, string playerName, sbyte level, byte alignmentSide, byte breed, ushort moodSmileyId)
        {
            m_sex = sex;
            m_havenBagShared = havenBagShared;
            m_guildInfo = guildInfo;
            m_status = status;
            m_playerId = playerId;
            m_playerName = playerName;
            m_level = level;
            m_alignmentSide = alignmentSide;
            m_breed = breed;
            m_moodSmileyId = moodSmileyId;
        }
        
        public FriendOnlineInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_sex);
            BooleanByteWrapper.SetFlag(1, flag, m_havenBagShared);
            writer.WriteByte(flag);
            m_guildInfo.Serialize(writer);
            writer.WriteUShort(((ushort)(m_status.TypeID)));
            m_status.Serialize(writer);
            writer.WriteVarLong(m_playerId);
            writer.WriteUTF(m_playerName);
            writer.WriteSByte(m_level);
            writer.WriteByte(m_alignmentSide);
            writer.WriteByte(m_breed);
            writer.WriteVarShort(m_moodSmileyId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            byte flag = reader.ReadByte();
            m_sex = BooleanByteWrapper.GetFlag(flag, 0);
            m_havenBagShared = BooleanByteWrapper.GetFlag(flag, 1);
            m_guildInfo = new GuildInformations();
            m_guildInfo.Deserialize(reader);
            m_status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
            m_status.Deserialize(reader);
            m_playerId = reader.ReadVarUhLong();
            m_playerName = reader.ReadUTF();
            m_level = reader.ReadSByte();
            m_alignmentSide = reader.ReadByte();
            m_breed = reader.ReadByte();
            m_moodSmileyId = reader.ReadVarUhShort();
        }
    }
}
