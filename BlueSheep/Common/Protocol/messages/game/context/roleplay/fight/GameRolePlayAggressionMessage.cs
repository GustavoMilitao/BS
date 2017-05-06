//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Fight
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameRolePlayAggressionMessage : Message 
    {
        
        public new const int ID = 6073;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private ulong m_attackerId;
        
        public virtual ulong AttackerId
        {
            get
            {
                return m_attackerId;
            }
            set
            {
                m_attackerId = value;
            }
        }
        
        private ulong m_defenderId;
        
        public virtual ulong DefenderId
        {
            get
            {
                return m_defenderId;
            }
            set
            {
                m_defenderId = value;
            }
        }
        
        public GameRolePlayAggressionMessage(ulong attackerId, ulong defenderId)
        {
            m_attackerId = attackerId;
            m_defenderId = defenderId;
        }
        
        public GameRolePlayAggressionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_attackerId);
            writer.WriteVarLong(m_defenderId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_attackerId = reader.ReadVarUhLong();
            m_defenderId = reader.ReadVarUhLong();
        }
    }
}
