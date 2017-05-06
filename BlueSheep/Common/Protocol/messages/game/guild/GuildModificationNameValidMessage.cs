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
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GuildModificationNameValidMessage : Message 
    {
        
        public new const int ID = 6327;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private string m_guildName;
        
        public virtual string GuildName
        {
            get
            {
                return m_guildName;
            }
            set
            {
                m_guildName = value;
            }
        }
        
        public GuildModificationNameValidMessage(string guildName)
        {
            m_guildName = guildName;
        }
        
        public GuildModificationNameValidMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_guildName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_guildName = reader.ReadUTF();
        }
    }
}
