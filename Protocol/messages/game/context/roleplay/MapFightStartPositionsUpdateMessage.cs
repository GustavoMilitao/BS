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
    using BlueSheep.Protocol.Types.Game.Context.Fight;


    public class MapFightStartPositionsUpdateMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6716;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private FightStartingPositions m_fightStartPositions;
        
        public virtual FightStartingPositions FightStartPositions
        {
            get
            {
                return m_fightStartPositions;
            }
            set
            {
                m_fightStartPositions = value;
            }
        }
        
        private int m_mapId;
        
        public virtual int MapId
        {
            get
            {
                return m_mapId;
            }
            set
            {
                m_mapId = value;
            }
        }
        
        public MapFightStartPositionsUpdateMessage(FightStartingPositions fightStartPositions, int mapId)
        {
            m_fightStartPositions = fightStartPositions;
            m_mapId = mapId;
        }
        
        public MapFightStartPositionsUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_fightStartPositions.Serialize(writer);
            writer.WriteInt(m_mapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_fightStartPositions = new FightStartingPositions();
            m_fightStartPositions.Deserialize(reader);
            m_mapId = reader.ReadInt();
        }
    }
}
