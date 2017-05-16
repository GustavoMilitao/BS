//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Friend
{
    using BlueSheep.Protocol.Types.Game.Friend;
    using BlueSheep.Protocol.Types;


    public class SpouseInformationsMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6356;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private FriendSpouseInformations m_spouse;
        
        public virtual FriendSpouseInformations Spouse
        {
            get
            {
                return m_spouse;
            }
            set
            {
                m_spouse = value;
            }
        }
        
        public SpouseInformationsMessage(FriendSpouseInformations spouse)
        {
            m_spouse = spouse;
        }
        
        public SpouseInformationsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_spouse.TypeID)));
            m_spouse.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_spouse = ProtocolTypeManager.GetInstance<FriendSpouseInformations>(reader.ReadUShort());
            m_spouse.Deserialize(reader);
        }
    }
}
