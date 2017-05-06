//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Character.Status
{
    using BlueSheep.Common.Protocol.Types;


    public class PlayerStatus : NetworkType
    {
        
        public const int ProtocolId = 415;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_statusId;
        
        public virtual byte StatusId
        {
            get
            {
                return m_statusId;
            }
            set
            {
                m_statusId = value;
            }
        }
        
        public PlayerStatus(byte statusId)
        {
            m_statusId = statusId;
        }
        
        public PlayerStatus()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_statusId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_statusId = reader.ReadByte();
        }
    }
}
