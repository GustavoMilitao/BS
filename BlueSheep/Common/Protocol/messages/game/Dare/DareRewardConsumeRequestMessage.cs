//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Dare
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class DareRewardConsumeRequestMessage : Message 
    {
        
        public new const int ID = 6676;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private double m_dareId;
        
        public virtual double DareId
        {
            get
            {
                return m_dareId;
            }
            set
            {
                m_dareId = value;
            }
        }
        
        private byte m_type;
        
        public virtual byte Type
        {
            get
            {
                return m_type;
            }
            set
            {
                m_type = value;
            }
        }
        
        public DareRewardConsumeRequestMessage(double dareId, byte type)
        {
            m_dareId = dareId;
            m_type = type;
        }
        
        public DareRewardConsumeRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(m_dareId);
            writer.WriteByte(m_type);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dareId = reader.ReadDouble();
            m_type = reader.ReadByte();
        }
    }
}
