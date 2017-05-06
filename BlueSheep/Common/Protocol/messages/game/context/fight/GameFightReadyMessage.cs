//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameFightReadyMessage : Message 
    {
        
        public new const int ID = 708;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private bool m_isReady;
        
        public virtual bool IsReady
        {
            get
            {
                return m_isReady;
            }
            set
            {
                m_isReady = value;
            }
        }
        
        public GameFightReadyMessage(bool isReady)
        {
            m_isReady = isReady;
        }
        
        public GameFightReadyMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(m_isReady);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_isReady = reader.ReadBoolean();
        }
    }
}
