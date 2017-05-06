//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Dialog
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class LeaveDialogMessage : Message 
    {
        
        public new const int ID = 5502;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_dialogType;
        
        public virtual byte DialogType
        {
            get
            {
                return m_dialogType;
            }
            set
            {
                m_dialogType = value;
            }
        }
        
        public LeaveDialogMessage(byte dialogType)
        {
            m_dialogType = dialogType;
        }
        
        public LeaveDialogMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_dialogType);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_dialogType = reader.ReadByte();
        }
    }
}
