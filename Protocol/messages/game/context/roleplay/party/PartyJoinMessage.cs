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
    using BlueSheep.Protocol.Types;
    using BlueSheep.Protocol.Types.Game.Context.Roleplay.Party;
    using System.Collections.Generic;


    public class PartyJoinMessage : AbstractPartyMessage
    {
        
        protected override int ProtocolId { get; set; } = 5576;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<PartyMemberInformations> m_members;
        
        public virtual List<PartyMemberInformations> Members
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
        
        private ulong m_partyLeaderId;
        
        public virtual ulong PartyLeaderId
        {
            get
            {
                return m_partyLeaderId;
            }
            set
            {
                m_partyLeaderId = value;
            }
        }
        
        private byte m_maxParticipants;
        
        public virtual byte MaxParticipants
        {
            get
            {
                return m_maxParticipants;
            }
            set
            {
                m_maxParticipants = value;
            }
        }
        
        private bool m_restricted;
        
        public virtual bool Restricted
        {
            get
            {
                return m_restricted;
            }
            set
            {
                m_restricted = value;
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
        
        public PartyJoinMessage(List<PartyMemberInformations> members, List<PartyGuestInformations> guests, byte partyType, ulong partyLeaderId, byte maxParticipants, bool restricted, string partyName)
        {
            m_members = members;
            m_guests = guests;
            m_partyType = partyType;
            m_partyLeaderId = partyLeaderId;
            m_maxParticipants = maxParticipants;
            m_restricted = restricted;
            m_partyName = partyName;
        }
        
        public PartyJoinMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_members.Count)));
            int membersIndex;
            for (membersIndex = 0; (membersIndex < m_members.Count); membersIndex = (membersIndex + 1))
            {
                PartyMemberInformations objectToSend = m_members[membersIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
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
            writer.WriteVarLong(m_partyLeaderId);
            writer.WriteByte(m_maxParticipants);
            writer.WriteBoolean(m_restricted);
            writer.WriteUTF(m_partyName);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int membersCount = reader.ReadUShort();
            int membersIndex;
            m_members = new System.Collections.Generic.List<PartyMemberInformations>();
            for (membersIndex = 0; (membersIndex < membersCount); membersIndex = (membersIndex + 1))
            {
                PartyMemberInformations objectToAdd = ProtocolTypeManager.GetInstance<PartyMemberInformations>(reader.ReadUShort());
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
            m_partyLeaderId = reader.ReadVarUhLong();
            m_maxParticipants = reader.ReadByte();
            m_restricted = reader.ReadBoolean();
            m_partyName = reader.ReadUTF();
        }
    }
}
