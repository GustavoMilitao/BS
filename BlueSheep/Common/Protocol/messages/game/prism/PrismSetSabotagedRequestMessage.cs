//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Prism
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class PrismSetSabotagedRequestMessage : Message 
    {
        
        public new const int ID = 6468;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private ushort m_subAreaId;
        
        public virtual ushort SubAreaId
        {
            get
            {
                return m_subAreaId;
            }
            set
            {
                m_subAreaId = value;
            }
        }
        
        public PrismSetSabotagedRequestMessage(ushort subAreaId)
        {
            m_subAreaId = subAreaId;
        }
        
        public PrismSetSabotagedRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_subAreaId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_subAreaId = reader.ReadVarUhShort();
        }
    }
}
