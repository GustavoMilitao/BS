//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Alliance
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class AllianceCreationStartedMessage : Message
    {
        
        public const int ProtocolId = 6394;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public AllianceCreationStartedMessage()
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
