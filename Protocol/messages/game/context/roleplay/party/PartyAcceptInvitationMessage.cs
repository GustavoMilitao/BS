//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Party
{


    public class PartyAcceptInvitationMessage : AbstractPartyMessage
    {
        
        public const int ProtocolId = 5580;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public PartyAcceptInvitationMessage()
        {
        }

        public PartyAcceptInvitationMessage(uint partyId) : base(partyId)
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