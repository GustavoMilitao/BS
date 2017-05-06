//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild
{
    using BlueSheep.Common.Protocol.Types.Game.Guild;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GuildModificationEmblemValidMessage : Message 
    {
        
        public new const int ID = 6328;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private GuildEmblem m_guildEmblem;
        
        public virtual GuildEmblem GuildEmblem
        {
            get
            {
                return m_guildEmblem;
            }
            set
            {
                m_guildEmblem = value;
            }
        }
        
        public GuildModificationEmblemValidMessage(GuildEmblem guildEmblem)
        {
            m_guildEmblem = guildEmblem;
        }
        
        public GuildModificationEmblemValidMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_guildEmblem.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildEmblem = new GuildEmblem();
            m_guildEmblem.Deserialize(reader);
        }
    }
}
