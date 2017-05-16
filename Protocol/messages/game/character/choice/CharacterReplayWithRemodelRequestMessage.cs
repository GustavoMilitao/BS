//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Character.Choice
{
    using BlueSheep.Protocol.Messages.Game.Character.Replay;
    using BlueSheep.Protocol.Types.Game.Character.Choice;


    public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
    {
        
        protected override int ProtocolId { get; set; } = 6551;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private RemodelingInformation m_remodel;
        
        public virtual RemodelingInformation Remodel
        {
            get
            {
                return m_remodel;
            }
            set
            {
                m_remodel = value;
            }
        }
        
        public CharacterReplayWithRemodelRequestMessage(RemodelingInformation remodel)
        {
            m_remodel = remodel;
        }
        
        public CharacterReplayWithRemodelRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            m_remodel.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_remodel = new RemodelingInformation();
            m_remodel.Deserialize(reader);
        }
    }
}
