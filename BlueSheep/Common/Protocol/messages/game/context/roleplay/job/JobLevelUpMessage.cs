//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Job
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class JobLevelUpMessage : Message 
    {
        
        public new const int ID = 5656;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private JobDescription m_jobsDescription;
        
        public virtual JobDescription JobsDescription
        {
            get
            {
                return m_jobsDescription;
            }
            set
            {
                m_jobsDescription = value;
            }
        }
        
        private sbyte m_newLevel;
        
        public virtual sbyte NewLevel
        {
            get
            {
                return m_newLevel;
            }
            set
            {
                m_newLevel = value;
            }
        }
        
        public JobLevelUpMessage(JobDescription jobsDescription, sbyte newLevel)
        {
            m_jobsDescription = jobsDescription;
            m_newLevel = newLevel;
        }
        
        public JobLevelUpMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_jobsDescription.Serialize(writer);
            writer.WriteSByte(m_newLevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_jobsDescription = new JobDescription();
            m_jobsDescription.Deserialize(reader);
            m_newLevel = reader.ReadSByte();
        }
    }
}
