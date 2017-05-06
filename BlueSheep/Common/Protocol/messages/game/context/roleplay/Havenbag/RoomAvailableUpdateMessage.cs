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
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class RoomAvailableUpdateMessage : Message 
    {
        
        public new const int ID = 6630;
        
        public override int MessageID
        {
            get
            {
                return ID;
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
