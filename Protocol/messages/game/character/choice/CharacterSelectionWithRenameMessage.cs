//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageBot.Protocol.Messages.Game.Character.Choice
{


    public class CharacterSelectionWithRenameMessage : CharacterSelectionMessage
    {
        
        public override int ProtocolId { get; } = 6121;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_name;
        
        public virtual string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }
        
        public CharacterSelectionWithRenameMessage(string name)
        {
            m_name = name;
        }
        
        public CharacterSelectionWithRenameMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_name);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_name = reader.ReadUTF();
        }
    }
}
