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
    using BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.Party;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameFightSpectatorJoinMessage : GameFightJoinMessage 
    {
        
        public new const int ID = 6504;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<NamedPartyTeam> m_namedPartyTeams;
        
        public virtual List<NamedPartyTeam> NamedPartyTeams
        {
            get
            {
                return m_namedPartyTeams;
            }
            set
            {
                m_namedPartyTeams = value;
            }
        }
        
        public GameFightSpectatorJoinMessage(List<NamedPartyTeam> namedPartyTeams)
        {
            m_namedPartyTeams = namedPartyTeams;
        }
        
        public GameFightSpectatorJoinMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_namedPartyTeams.Count)));
            int namedPartyTeamsIndex;
            for (namedPartyTeamsIndex = 0; (namedPartyTeamsIndex < m_namedPartyTeams.Count); namedPartyTeamsIndex = (namedPartyTeamsIndex + 1))
            {
                NamedPartyTeam objectToSend = m_namedPartyTeams[namedPartyTeamsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int namedPartyTeamsCount = reader.ReadUShort();
            int namedPartyTeamsIndex;
            m_namedPartyTeams = new System.Collections.Generic.List<NamedPartyTeam>();
            for (namedPartyTeamsIndex = 0; (namedPartyTeamsIndex < namedPartyTeamsCount); namedPartyTeamsIndex = (namedPartyTeamsIndex + 1))
            {
                NamedPartyTeam objectToAdd = new NamedPartyTeam();
                objectToAdd.Deserialize(reader);
                m_namedPartyTeams.Add(objectToAdd);
            }
        }
    }
}
