//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Prism
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class PrismModuleExchangeRequestMessage : Message
    {
        
        public const int ProtocolId = 6531;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public PrismModuleExchangeRequestMessage()
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
