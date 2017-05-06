//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Character.Replay
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class CharacterReplayRequestMessage : Message 
    {
        
        public new const int ID = 167;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private ulong m_characterId;
        
        public virtual ulong CharacterId
        {
            get
            {
                return m_characterId;
            }
            set
            {
                m_characterId = value;
            }
        }
        
        public CharacterReplayRequestMessage(ulong characterId)
        {
            m_characterId = characterId;
        }
        
        public CharacterReplayRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_characterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_characterId = reader.ReadVarUhLong();
        }
    }
}
