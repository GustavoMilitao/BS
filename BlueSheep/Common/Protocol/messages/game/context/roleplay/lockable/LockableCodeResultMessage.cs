//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class LockableCodeResultMessage : Message 
    {
        
        public new const int ID = 5672;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_result;
        
        public virtual byte Result
        {
            get
            {
                return m_result;
            }
            set
            {
                m_result = value;
            }
        }
        
        public LockableCodeResultMessage(byte result)
        {
            m_result = result;
        }
        
        public LockableCodeResultMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_result);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_result = reader.ReadByte();
        }
    }
}
