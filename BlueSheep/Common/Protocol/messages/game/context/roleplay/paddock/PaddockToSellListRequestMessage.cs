//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Paddock
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class PaddockToSellListRequestMessage : Message 
    {
        
        public new const int ID = 6141;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private ushort m_pageIndex;
        
        public virtual ushort PageIndex
        {
            get
            {
                return m_pageIndex;
            }
            set
            {
                m_pageIndex = value;
            }
        }
        
        public PaddockToSellListRequestMessage(ushort pageIndex)
        {
            m_pageIndex = pageIndex;
        }
        
        public PaddockToSellListRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_pageIndex);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_pageIndex = reader.ReadVarUhShort();
        }
    }
}
