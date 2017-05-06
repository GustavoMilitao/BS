//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Storage
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class StorageKamasUpdateMessage : Message 
    {
        
        public new const int ID = 5645;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private ulong m_kamasTotal;
        
        public virtual ulong KamasTotal
        {
            get
            {
                return m_kamasTotal;
            }
            set
            {
                m_kamasTotal = value;
            }
        }
        
        public StorageKamasUpdateMessage(ulong kamasTotal)
        {
            m_kamasTotal = kamasTotal;
        }
        
        public StorageKamasUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_kamasTotal);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_kamasTotal = reader.ReadVarUhLong();
        }
    }
}
