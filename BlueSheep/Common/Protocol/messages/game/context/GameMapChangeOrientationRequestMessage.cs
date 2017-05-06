//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameMapChangeOrientationRequestMessage : Message
    {
        
        public const int ProtocolId = 945;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_direction;
        
        public virtual byte Direction
        {
            get
            {
                return m_direction;
            }
            set
            {
                m_direction = value;
            }
        }
        
        public GameMapChangeOrientationRequestMessage(byte direction)
        {
            m_direction = direction;
        }
        
        public GameMapChangeOrientationRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_direction);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_direction = reader.ReadByte();
        }
    }
}
