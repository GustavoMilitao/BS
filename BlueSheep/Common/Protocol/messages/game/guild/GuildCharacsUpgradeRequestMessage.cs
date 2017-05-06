//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GuildCharacsUpgradeRequestMessage : Message
    {
        
        public const int ProtocolId = 5706;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_charaTypeTarget;
        
        public virtual byte CharaTypeTarget
        {
            get
            {
                return m_charaTypeTarget;
            }
            set
            {
                m_charaTypeTarget = value;
            }
        }
        
        public GuildCharacsUpgradeRequestMessage(byte charaTypeTarget)
        {
            m_charaTypeTarget = charaTypeTarget;
        }
        
        public GuildCharacsUpgradeRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_charaTypeTarget);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_charaTypeTarget = reader.ReadByte();
        }
    }
}
