//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Alliance
{
    using BlueSheep.Protocol.Messages.Game.Social;


    public class AllianceMotdSetErrorMessage : SocialNoticeSetErrorMessage
    {
        
        protected override int ProtocolId { get; set; } = 6683;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public AllianceMotdSetErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
    }
}
