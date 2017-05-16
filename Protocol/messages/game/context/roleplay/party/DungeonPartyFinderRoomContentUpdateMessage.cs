//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Party
{
    using BlueSheep.Protocol.Types.Game.Context.Roleplay.Party;
    using System.Collections.Generic;


    public class DungeonPartyFinderRoomContentUpdateMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6250;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<DungeonPartyFinderPlayer> m_addedPlayers;
        
        public virtual List<DungeonPartyFinderPlayer> AddedPlayers
        {
            get
            {
                return m_addedPlayers;
            }
            set
            {
                m_addedPlayers = value;
            }
        }
        
        private List<System.UInt64> m_removedPlayersIds;
        
        public virtual List<System.UInt64> RemovedPlayersIds
        {
            get
            {
                return m_removedPlayersIds;
            }
            set
            {
                m_removedPlayersIds = value;
            }
        }
        
        private ushort m_dungeonId;
        
        public virtual ushort DungeonId
        {
            get
            {
                return m_dungeonId;
            }
            set
            {
                m_dungeonId = value;
            }
        }
        
        public DungeonPartyFinderRoomContentUpdateMessage(List<DungeonPartyFinderPlayer> addedPlayers, List<System.UInt64> removedPlayersIds, ushort dungeonId)
        {
            m_addedPlayers = addedPlayers;
            m_removedPlayersIds = removedPlayersIds;
            m_dungeonId = dungeonId;
        }
        
        public DungeonPartyFinderRoomContentUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_addedPlayers.Count)));
            int addedPlayersIndex;
            for (addedPlayersIndex = 0; (addedPlayersIndex < m_addedPlayers.Count); addedPlayersIndex = (addedPlayersIndex + 1))
            {
                DungeonPartyFinderPlayer objectToSend = m_addedPlayers[addedPlayersIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_removedPlayersIds.Count)));
            int removedPlayersIdsIndex;
            for (removedPlayersIdsIndex = 0; (removedPlayersIdsIndex < m_removedPlayersIds.Count); removedPlayersIdsIndex = (removedPlayersIdsIndex + 1))
            {
                writer.WriteVarLong(m_removedPlayersIds[removedPlayersIdsIndex]);
            }
            writer.WriteVarShort(m_dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int addedPlayersCount = reader.ReadUShort();
            int addedPlayersIndex;
            m_addedPlayers = new System.Collections.Generic.List<DungeonPartyFinderPlayer>();
            for (addedPlayersIndex = 0; (addedPlayersIndex < addedPlayersCount); addedPlayersIndex = (addedPlayersIndex + 1))
            {
                DungeonPartyFinderPlayer objectToAdd = new DungeonPartyFinderPlayer();
                objectToAdd.Deserialize(reader);
                m_addedPlayers.Add(objectToAdd);
            }
            int removedPlayersIdsCount = reader.ReadUShort();
            int removedPlayersIdsIndex;
            m_removedPlayersIds = new System.Collections.Generic.List<ulong>();
            for (removedPlayersIdsIndex = 0; (removedPlayersIdsIndex < removedPlayersIdsCount); removedPlayersIdsIndex = (removedPlayersIdsIndex + 1))
            {
                m_removedPlayersIds.Add(reader.ReadVarUhLong());
            }
            m_dungeonId = reader.ReadVarUhShort();
        }
    }
}
