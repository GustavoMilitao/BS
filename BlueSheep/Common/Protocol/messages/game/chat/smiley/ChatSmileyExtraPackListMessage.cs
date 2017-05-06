//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Chat.Smiley
{
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class ChatSmileyExtraPackListMessage : Message
    {
        
        public const int ProtocolId = 6596;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Byte> m_packIds;
        
        public virtual List<System.Byte> PackIds
        {
            get
            {
                return m_packIds;
            }
            set
            {
                m_packIds = value;
            }
        }
        
        public ChatSmileyExtraPackListMessage(List<System.Byte> packIds)
        {
            m_packIds = packIds;
        }
        
        public ChatSmileyExtraPackListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_packIds.Count)));
            int packIdsIndex;
            for (packIdsIndex = 0; (packIdsIndex < m_packIds.Count); packIdsIndex = (packIdsIndex + 1))
            {
                writer.WriteByte(m_packIds[packIdsIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int packIdsCount = reader.ReadUShort();
            int packIdsIndex;
            m_packIds = new System.Collections.Generic.List<byte>();
            for (packIdsIndex = 0; (packIdsIndex < packIdsCount); packIdsIndex = (packIdsIndex + 1))
            {
                m_packIds.Add(reader.ReadByte());
            }
        }
    }
}
