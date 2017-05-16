//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay
{
    using BlueSheep.Protocol.Types.Game.Character;


    public class MapComplementaryInformationsDataInHavenBagMessage : MapComplementaryInformationsDataMessage
    {
        
        protected override int ProtocolId { get; set; } = 6622;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private CharacterMinimalInformations m_ownerInformations;
        
        public virtual CharacterMinimalInformations OwnerInformations
        {
            get
            {
                return m_ownerInformations;
            }
            set
            {
                m_ownerInformations = value;
            }
        }
        
        private byte m_theme;
        
        public virtual byte Theme
        {
            get
            {
                return m_theme;
            }
            set
            {
                m_theme = value;
            }
        }
        
        private byte m_roomId;
        
        public virtual byte RoomId
        {
            get
            {
                return m_roomId;
            }
            set
            {
                m_roomId = value;
            }
        }
        
        private byte m_maxRoomId;
        
        public virtual byte MaxRoomId
        {
            get
            {
                return m_maxRoomId;
            }
            set
            {
                m_maxRoomId = value;
            }
        }
        
        public MapComplementaryInformationsDataInHavenBagMessage(CharacterMinimalInformations ownerInformations, byte theme, byte roomId, byte maxRoomId)
        {
            m_ownerInformations = ownerInformations;
            m_theme = theme;
            m_roomId = roomId;
            m_maxRoomId = maxRoomId;
        }
        
        public MapComplementaryInformationsDataInHavenBagMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_ownerInformations.Serialize(writer);
            writer.WriteByte(m_theme);
            writer.WriteByte(m_roomId);
            writer.WriteByte(m_maxRoomId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_ownerInformations = new CharacterMinimalInformations();
            m_ownerInformations.Deserialize(reader);
            m_theme = reader.ReadByte();
            m_roomId = reader.ReadByte();
            m_maxRoomId = reader.ReadByte();
        }
    }
}
