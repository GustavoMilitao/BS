//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    public class ExitHavenBagRequestMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6631;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public ExitHavenBagRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
        }
        
        public override void Deserialize(IDataReader reader)
        {
        }
    }
}
