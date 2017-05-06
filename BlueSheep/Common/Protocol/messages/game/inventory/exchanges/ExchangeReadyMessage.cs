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

 	 public class ExchangeReadyMessage : Message 
    {
        
        public new const int ID = 5511;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private bool m_ready;
        
        public virtual bool Ready
        {
            get
            {
                return m_ready;
            }
            set
            {
                m_ready = value;
            }
        }
        
        private ushort m_step;
        
        public virtual ushort Step
        {
            get
            {
                return m_step;
            }
            set
            {
                m_step = value;
            }
        }
        
        public ExchangeReadyMessage(bool ready, ushort step)
        {
            m_ready = ready;
            m_step = step;
        }
        
        public ExchangeReadyMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_ready);
            writer.WriteVarShort(m_step);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ready = reader.ReadBoolean();
            m_step = reader.ReadVarUhShort();
        }
    }
}
