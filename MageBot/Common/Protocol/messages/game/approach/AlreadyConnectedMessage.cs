//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Approach
{
    using BlueSheep.Common;


    public class AlreadyConnectedMessage : Message
    {
        
        public const int ProtocolId = 109;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public AlreadyConnectedMessage()
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