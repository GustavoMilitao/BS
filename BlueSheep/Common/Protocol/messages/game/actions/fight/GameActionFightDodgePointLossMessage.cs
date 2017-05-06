//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Actions.Fight
{
    using BlueSheep.Common.Protocol.Messages.Game.Actions;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameActionFightDodgePointLossMessage : AbstractGameActionMessage 
    {
        
        public new const int ID = 5828;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private double m_targetId;
        
        public virtual double TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }
        
        private ushort m_amount;
        
        public virtual ushort Amount
        {
            get
            {
                return m_amount;
            }
            set
            {
                m_amount = value;
            }
        }
        
        public GameActionFightDodgePointLossMessage(double targetId, ushort amount)
        {
            m_targetId = targetId;
            m_amount = amount;
        }
        
        public GameActionFightDodgePointLossMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteDouble(m_targetId);
            writer.WriteVarShort(m_amount);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_targetId = reader.ReadDouble();
            m_amount = reader.ReadVarUhShort();
        }
    }
}
