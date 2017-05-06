//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.Party
{
    using BlueSheep.Protocol;


    public class DungeonPartyFinderPlayer 
    {
        
        public new const int ID = 373;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
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
        
        public DungeonPartyFinderPlayer(ulong playerId, string playerName, byte breed, bool sex, sbyte level)
        {
            m_playerId = playerId;
            m_playerName = playerName;
            m_breed = breed;
            m_sex = sex;
            m_level = level;
        }
        
        public DungeonPartyFinderPlayer()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_playerId);
            writer.WriteUTF(m_playerName);
            writer.WriteByte(m_breed);
            writer.WriteBoolean(m_sex);
            writer.WriteSByte(m_level);
        }
        
        public void Deserialize(IDataReader reader)
        {
            m_playerId = reader.ReadVarUhLong();
            m_playerName = reader.ReadUTF();
            m_breed = reader.ReadByte();
            m_sex = reader.ReadBoolean();
            m_level = reader.ReadSByte();
        }
    }
}
