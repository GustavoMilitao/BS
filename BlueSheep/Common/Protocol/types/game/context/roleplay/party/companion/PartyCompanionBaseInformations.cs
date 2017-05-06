//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.Party.Companion
{
    using BlueSheep.Common.Protocol.Types.Game.Look;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    public class PartyCompanionBaseInformations 
    {
        
        public new const int ID = 453;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private EntityLook m_entityLook;
        
        public virtual EntityLook EntityLook
        {
            get
            {
                return m_entityLook;
            }
            set
            {
                m_entityLook = value;
            }
        }
        
        private byte m_indexId;
        
        public virtual byte IndexId
        {
            get
            {
                return m_indexId;
            }
            set
            {
                m_indexId = value;
            }
        }
        
        private byte m_companionGenericId;
        
        public virtual byte CompanionGenericId
        {
            get
            {
                return m_companionGenericId;
            }
            set
            {
                m_companionGenericId = value;
            }
        }
        
        public PartyCompanionBaseInformations(EntityLook entityLook, byte indexId, byte companionGenericId)
        {
            m_entityLook = entityLook;
            m_indexId = indexId;
            m_companionGenericId = companionGenericId;
        }
        
        public PartyCompanionBaseInformations()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            m_entityLook.Serialize(writer);
            writer.WriteByte(m_indexId);
            writer.WriteByte(m_companionGenericId);
        }
        
        public void Deserialize(IDataReader reader)
        {
            m_entityLook = new EntityLook();
            m_entityLook.Deserialize(reader);
            m_indexId = reader.ReadByte();
            m_companionGenericId = reader.ReadByte();
        }
    }
}
