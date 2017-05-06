//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Character.Choice
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class CharacterSelectedForceMessage : Message 
    {
        
        public new const int ID = 6068;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private int m_ObjectId;
        
        public virtual int ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        public CharacterSelectedForceMessage(int objectId)
        {
            m_ObjectId = objectId;
        }
        
        public CharacterSelectedForceMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_ObjectId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ObjectId = reader.ReadInt();
        }
    }
}
