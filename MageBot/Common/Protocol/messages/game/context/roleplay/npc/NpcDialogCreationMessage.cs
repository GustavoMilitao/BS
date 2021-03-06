//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Npc
{
    using BlueSheep.Common;


    public class NpcDialogCreationMessage : Message
    {
        
        public const int ProtocolId = 5618;
        
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
        
        private int m_npcId;
        
        public virtual int NpcId
        {
            get
            {
                return m_npcId;
            }
            set
            {
                m_npcId = value;
            }
        }
        
        public NpcDialogCreationMessage(int mapId, int npcId)
        {
            m_mapId = mapId;
            m_npcId = npcId;
        }
        
        public NpcDialogCreationMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_mapId);
            writer.WriteInt(m_npcId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_mapId = reader.ReadInt();
            m_npcId = reader.ReadInt();
        }
    }
}
