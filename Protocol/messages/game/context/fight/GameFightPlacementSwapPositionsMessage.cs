//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Fight
{
    public class GameFightPlacementSwapPositionsMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6544;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public GameFightPlacementSwapPositionsMessage()
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
