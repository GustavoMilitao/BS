//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class ChangeMapMessage : Message
    {
        
        public const int ProtocolId = 221;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        public ChangeMapMessage(int mapId)
        {
            m_mapId = mapId;
        }
        
        public ChangeMapMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_mapId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mapId = reader.ReadInt();
        }
    }
}
