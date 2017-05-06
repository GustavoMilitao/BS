//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Fight;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class RefreshCharacterStatsMessage : Message 
    {
        
        public new const int ID = 6699;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private GameFightMinimalStats m_stats;
        
        public virtual GameFightMinimalStats Stats
        {
            get
            {
                return m_stats;
            }
            set
            {
                m_stats = value;
            }
        }
        
        private double m_fighterId;
        
        public virtual double FighterId
        {
            get
            {
                return m_fighterId;
            }
            set
            {
                m_fighterId = value;
            }
        }
        
        public RefreshCharacterStatsMessage(GameFightMinimalStats stats, double fighterId)
        {
            m_stats = stats;
            m_fighterId = fighterId;
        }
        
        public RefreshCharacterStatsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_stats.Serialize(writer);
            writer.WriteDouble(m_fighterId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_stats = new GameFightMinimalStats();
            m_stats.Deserialize(reader);
            m_fighterId = reader.ReadDouble();
        }
    }
}
