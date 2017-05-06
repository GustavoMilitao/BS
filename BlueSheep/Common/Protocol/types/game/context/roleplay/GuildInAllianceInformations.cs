//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Roleplay
{
    using BlueSheep.Common.Protocol.Types.Game.Guild;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class GuildInAllianceInformations : GuildInformations
    {
        
        public new const int ID = 420;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private sbyte m_nbMembers;
        
        public virtual sbyte NbMembers
        {
            get
            {
                return m_nbMembers;
            }
            set
            {
                m_nbMembers = value;
            }
        }
        
        public GuildInAllianceInformations(sbyte nbMembers)
        {
            m_nbMembers = nbMembers;
        }
        
        public GuildInAllianceInformations()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteSByte(m_nbMembers);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_nbMembers = reader.ReadSByte();
        }
    }
}
