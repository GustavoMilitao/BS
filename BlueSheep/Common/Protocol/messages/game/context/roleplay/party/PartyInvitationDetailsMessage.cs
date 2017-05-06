//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Party
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.Party;
    using System.Collections.Generic;


    public class PartyInvitationDetailsMessage : AbstractPartyMessage
    {
        
        public const int ProtocolId = 6263;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<PartyInvitationMemberInformations> m_members;
        
        public virtual List<PartyInvitationMemberInformations> Members
        {
            get
            {
                return m_members;
            }
            set
            {
                m_members = value;
            }
        }
        
        private List<PartyGuestInformations> m_guests;
        
        public virtual List<PartyGuestInformations> Guests
        {
            get
            {
                return m_guests;
            }
            set
            {
                m_guests = value;
            }
        }
        
        private byte m_partyType;
        
        public virtual byte PartyType
        {
            get
            {
                return m_partyType;
            }
            set
            {
                m_partyType = value;
            }
        }
        
        private string m_partyName;
        
        public virtual string PartyName
        {
            get
            {
                return m_partyName;
            }
            set
            {
                m_partyName = value;
            }
        }
        
        private ulong m_fromId;
        
        public virtual ulong FromId
        {
            get
            {
                return m_fromId;
            }
            set
            {
                m_fromId = value;
            }
        }
        
        private string m_fromName;
        
        public virtual string FromName
        {
            get
            {
                return m_fromName;
            }
            set
            {
                m_fromName = value;
            }
        }
        
        private ulong m_leaderId;
        
        public virtual ulong LeaderId
        {
            get
            {
                return m_leaderId;
            }
            set
            {
                m_leaderId = value;
            }
        }
        
        public PartyInvitationDetailsMessage(List<PartyInvitationMemberInformations> members, List<PartyGuestInformations> guests, byte partyType, string partyName, ulong fromId, string fromName, ulong leaderId)
        {
            m_members = members;
            m_guests = guests;
            m_partyType = partyType;
            m_partyName = partyName;
            m_fromId = fromId;
            m_fromName = fromName;
            m_leaderId = leaderId;
        }
        
        public PartyInvitationDetailsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_members.Count)));
            int membersIndex;
            for (membersIndex = 0; (membersIndex < m_members.Count); membersIndex = (membersIndex + 1))
            {
                PartyInvitationMemberInformations objectToSend = m_members[membersIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_guests.Count)));
            int guestsIndex;
            for (guestsIndex = 0; (guestsIndex < m_guests.Count); guestsIndex = (guestsIndex + 1))
            {
                PartyGuestInformations objectToSend = m_guests[guestsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteByte(m_partyType);
            writer.WriteUTF(m_partyName);
            writer.WriteVarLong(m_fromId);
            writer.WriteUTF(m_fromName);
            writer.WriteVarLong(m_leaderId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int membersCount = reader.ReadUShort();
            int membersIndex;
            m_members = new System.Collections.Generic.List<PartyInvitationMemberInformations>();
            for (membersIndex = 0; (membersIndex < membersCount); membersIndex = (membersIndex + 1))
            {
                PartyInvitationMemberInformations objectToAdd = new PartyInvitationMemberInformations();
                objectToAdd.Deserialize(reader);
                m_members.Add(objectToAdd);
            }
            int guestsCount = reader.ReadUShort();
            int guestsIndex;
            m_guests = new System.Collections.Generic.List<PartyGuestInformations>();
            for (guestsIndex = 0; (guestsIndex < guestsCount); guestsIndex = (guestsIndex + 1))
            {
                PartyGuestInformations objectToAdd = new PartyGuestInformations();
                objectToAdd.Deserialize(reader);
                m_guests.Add(objectToAdd);
            }
            m_partyType = reader.ReadByte();
            m_partyName = reader.ReadUTF();
            m_fromId = reader.ReadVarUhLong();
            m_fromName = reader.ReadUTF();
            m_leaderId = reader.ReadVarUhLong();
        }
    }
}
