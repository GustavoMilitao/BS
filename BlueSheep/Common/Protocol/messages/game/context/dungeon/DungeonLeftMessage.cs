//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Dungeon
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class DungeonLeftMessage : Message
    {
        
        public const int ProtocolId = 6149;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_dungeonId;
        
        public virtual int DungeonId
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
        
        public DungeonLeftMessage(int dungeonId)
        {
            m_dungeonId = dungeonId;
        }
        
        public DungeonLeftMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_dungeonId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dungeonId = reader.ReadInt();
        }
    }
}
