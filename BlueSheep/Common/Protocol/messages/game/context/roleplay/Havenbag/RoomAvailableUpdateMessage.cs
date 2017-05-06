//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class RoomAvailableUpdateMessage : Message
    {
        
        public const int ProtocolId = 6630;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private sbyte m_nbRoom;
        
        public virtual sbyte NbRoom
        {
            get
            {
                return m_nbRoom;
            }
            set
            {
                m_nbRoom = value;
            }
        }
        
        public RoomAvailableUpdateMessage(sbyte nbRoom)
        {
            m_nbRoom = nbRoom;
        }
        
        public RoomAvailableUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSByte(m_nbRoom);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_nbRoom = reader.ReadSByte();
        }
    }
}
