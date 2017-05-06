//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context
{
    using BlueSheep.Common.Protocol.Types.Game.Look;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    public class GameContextActorInformations 
    {
        
        public new const int ID = 150;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private EntityLook m_look;
        
        public virtual EntityLook Look
        {
            get
            {
                return m_look;
            }
            set
            {
                m_look = value;
            }
        }
        
        private EntityDispositionInformations m_disposition;
        
        public virtual EntityDispositionInformations Disposition
        {
            get
            {
                return m_disposition;
            }
            set
            {
                m_disposition = value;
            }
        }
        
        private double m_contextualId;
        
        public virtual double ContextualId
        {
            get
            {
                return m_contextualId;
            }
            set
            {
                m_contextualId = value;
            }
        }
        
        public GameContextActorInformations(EntityLook look, EntityDispositionInformations disposition, double contextualId)
        {
            m_look = look;
            m_disposition = disposition;
            m_contextualId = contextualId;
        }
        
        public GameContextActorInformations()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            m_look.Serialize(writer);
            writer.WriteUShort(((ushort)(m_disposition.TypeID)));
            m_disposition.Serialize(writer);
            writer.WriteDouble(m_contextualId);
        }
        
        public void Deserialize(IDataReader reader)
        {
            m_look = new EntityLook();
            m_look.Deserialize(reader);
            m_disposition = ProtocolTypeManager.GetInstance<EntityDispositionInformations>(reader.ReadUShort());
            m_disposition.Deserialize(reader);
            m_contextualId = reader.ReadDouble();
        }
    }
}
