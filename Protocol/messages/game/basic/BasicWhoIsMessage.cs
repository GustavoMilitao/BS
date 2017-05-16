//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Basic
{
    using BlueSheep.Protocol.Types.Game.Social;
    using BlueSheep.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Protocol.Types;


    public class BasicWhoIsMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 180;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_self;
        
        public virtual bool Self
        {
            get
            {
                return m_self;
            }
            set
            {
                m_self = value;
            }
        }
        
        private bool m_verbose;
        
        public virtual bool Verbose
        {
            get
            {
                return m_verbose;
            }
            set
            {
                m_verbose = value;
            }
        }
        
        private List<AbstractSocialGroupInfos> m_socialGroups;
        
        public virtual List<AbstractSocialGroupInfos> SocialGroups
        {
            get
            {
                return m_socialGroups;
            }
            set
            {
                m_socialGroups = value;
            }
        }
        
        private byte m_position;
        
        public virtual byte Position
        {
            get
            {
                return m_position;
            }
            set
            {
                m_position = value;
            }
        }
        
        private string m_accountNickname;
        
        public virtual string AccountNickname
        {
            get
            {
                return m_accountNickname;
            }
            set
            {
                m_accountNickname = value;
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
        
        private short m_areaId;
        
        public virtual short AreaId
        {
            get
            {
                return m_areaId;
            }
            set
            {
                m_areaId = value;
            }
        }
        
        private short m_serverId;
        
        public virtual short ServerId
        {
            get
            {
                return m_serverId;
            }
            set
            {
                m_serverId = value;
            }
        }
        
        private short m_originServerId;
        
        public virtual short OriginServerId
        {
            get
            {
                return m_originServerId;
            }
            set
            {
                m_originServerId = value;
            }
        }
        
        private byte m_playerState;
        
        public virtual byte PlayerState
        {
            get
            {
                return m_playerState;
            }
            set
            {
                m_playerState = value;
            }
        }
        
        public BasicWhoIsMessage(bool self, bool verbose, List<AbstractSocialGroupInfos> socialGroups, byte position, string accountNickname, int accountId, string playerName, ulong playerId, short areaId, short serverId, short originServerId, byte playerState)
        {
            m_self = self;
            m_verbose = verbose;
            m_socialGroups = socialGroups;
            m_position = position;
            m_accountNickname = accountNickname;
            m_accountId = accountId;
            m_playerName = playerName;
            m_playerId = playerId;
            m_areaId = areaId;
            m_serverId = serverId;
            m_originServerId = originServerId;
            m_playerState = playerState;
        }
        
        public BasicWhoIsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_self);
            BooleanByteWrapper.SetFlag(1, flag, m_verbose);
            writer.WriteByte(flag);
            writer.WriteShort(((short)(m_socialGroups.Count)));
            int socialGroupsIndex;
            for (socialGroupsIndex = 0; (socialGroupsIndex < m_socialGroups.Count); socialGroupsIndex = (socialGroupsIndex + 1))
            {
                AbstractSocialGroupInfos objectToSend = m_socialGroups[socialGroupsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_position);
            writer.WriteUTF(m_accountNickname);
            writer.WriteInt(m_accountId);
            writer.WriteUTF(m_playerName);
            writer.WriteVarLong(m_playerId);
            writer.WriteShort(m_areaId);
            writer.WriteShort(m_serverId);
            writer.WriteShort(m_originServerId);
            writer.WriteByte(m_playerState);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag = reader.ReadByte();
            m_self = BooleanByteWrapper.GetFlag(flag, 0);
            m_verbose = BooleanByteWrapper.GetFlag(flag, 1);
            int socialGroupsCount = reader.ReadUShort();
            int socialGroupsIndex;
            m_socialGroups = new System.Collections.Generic.List<AbstractSocialGroupInfos>();
            for (socialGroupsIndex = 0; (socialGroupsIndex < socialGroupsCount); socialGroupsIndex = (socialGroupsIndex + 1))
            {
                AbstractSocialGroupInfos objectToAdd = ProtocolTypeManager.GetInstance<AbstractSocialGroupInfos>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_socialGroups.Add(objectToAdd);
            }
            m_position = reader.ReadByte();
            m_accountNickname = reader.ReadUTF();
            m_accountId = reader.ReadInt();
            m_playerName = reader.ReadUTF();
            m_playerId = reader.ReadVarUhLong();
            m_areaId = reader.ReadShort();
            m_serverId = reader.ReadShort();
            m_originServerId = reader.ReadShort();
            m_playerState = reader.ReadByte();
        }
    }
}
