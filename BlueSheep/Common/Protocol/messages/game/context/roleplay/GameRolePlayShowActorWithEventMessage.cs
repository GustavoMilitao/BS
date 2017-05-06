//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Roleplay;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameRolePlayShowActorWithEventMessage : GameRolePlayShowActorMessage 
    {
        
        public new const int ID = 6407;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_actorEventId;
        
        public virtual byte ActorEventId
        {
            get
            {
                return m_actorEventId;
            }
            set
            {
                m_actorEventId = value;
            }
        }
        
        public GameRolePlayShowActorWithEventMessage(byte actorEventId)
        {
            m_actorEventId = actorEventId;
        }
        
        public GameRolePlayShowActorWithEventMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_actorEventId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_actorEventId = reader.ReadByte();
        }
    }
}
