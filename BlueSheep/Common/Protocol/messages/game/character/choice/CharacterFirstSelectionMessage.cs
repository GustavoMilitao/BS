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

 	 public class CharacterFirstSelectionMessage : CharacterSelectionMessage 
    {
        
        public new const int ID = 6084;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private bool m_doTutorial;
        
        public virtual bool DoTutorial
        {
            get
            {
                return m_doTutorial;
            }
            set
            {
                m_doTutorial = value;
            }
        }
        
        public CharacterFirstSelectionMessage(bool doTutorial)
        {
            m_doTutorial = doTutorial;
        }
        
        public CharacterFirstSelectionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(m_doTutorial);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_doTutorial = reader.ReadBoolean();
        }
    }
}
