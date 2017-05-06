//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Chat.Community
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class ChatCommunityChannelCommunityMessage : Message 
    {
        
        public new const int ID = 6730;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private short m_communityId;
        
        public virtual short CommunityId
        {
            get
            {
                return m_communityId;
            }
            set
            {
                m_communityId = value;
            }
        }
        
        public ChatCommunityChannelCommunityMessage(short communityId)
        {
            m_communityId = communityId;
        }
        
        public ChatCommunityChannelCommunityMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(m_communityId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_communityId = reader.ReadShort();
        }
    }
}
