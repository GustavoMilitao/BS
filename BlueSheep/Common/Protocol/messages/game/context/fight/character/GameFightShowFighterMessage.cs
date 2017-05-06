//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight.Character
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Fight;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameFightShowFighterMessage : Message
    {
        
        public const int ProtocolId = 5864;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private GameFightFighterInformations m_informations;
        
        public virtual GameFightFighterInformations Informations
        {
            get
            {
                return m_informations;
            }
            set
            {
                m_informations = value;
            }
        }
        
        public GameFightShowFighterMessage(GameFightFighterInformations informations)
        {
            m_informations = informations;
        }
        
        public GameFightShowFighterMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_informations.TypeID)));
            m_informations.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_informations = ProtocolTypeManager.GetInstance<GameFightFighterInformations>(reader.ReadUShort());
            m_informations.Deserialize(reader);
        }
    }
}
