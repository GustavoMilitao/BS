//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class ExchangeObjectMessage : Message 
    {
        
        public new const int ID = 5515;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private bool m_remote;
        
        public virtual bool Remote
        {
            get
            {
                return m_remote;
            }
            set
            {
                m_remote = value;
            }
        }
        
        public ExchangeObjectMessage(bool remote)
        {
            m_remote = remote;
        }
        
        public ExchangeObjectMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_remote);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_remote = reader.ReadBoolean();
        }
    }
}
