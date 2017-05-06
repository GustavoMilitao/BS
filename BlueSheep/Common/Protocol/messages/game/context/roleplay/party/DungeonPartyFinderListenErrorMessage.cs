//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Party
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class DungeonPartyFinderListenErrorMessage : Message
    {
        
        public const int ProtocolId = 6248;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        public DungeonPartyFinderListenErrorMessage(ushort dungeonId)
        {
            m_dungeonId = dungeonId;
        }
        
        public DungeonPartyFinderListenErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dungeonId = reader.ReadVarUhShort();
        }
    }
}
