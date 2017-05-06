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
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameRolePlayShowActorMessage : Message 
    {
        
        public new const int ID = 5632;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private GameRolePlayActorInformations m_informations;
        
        public virtual GameRolePlayActorInformations Informations
        {
            get
            {
                return m_informations;
            }
            set
            {
                m_informations = value;
            }
        }
        
        public GameRolePlayShowActorMessage(GameRolePlayActorInformations informations)
        {
            m_informations = informations;
        }
        
        public GameRolePlayShowActorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_informations.TypeID)));
            m_informations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_informations = ProtocolTypeManager.GetInstance<GameRolePlayActorInformations>(reader.ReadUShort());
            m_informations.Deserialize(reader);
        }
    }
}
