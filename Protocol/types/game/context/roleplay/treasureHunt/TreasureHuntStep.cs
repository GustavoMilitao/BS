//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    using BlueSheep.Protocol.Types;


    public class TreasureHuntStep : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 463;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public TreasureHuntStep()
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
