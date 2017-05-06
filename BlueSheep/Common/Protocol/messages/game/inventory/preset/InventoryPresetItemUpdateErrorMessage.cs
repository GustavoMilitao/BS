//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Preset
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class InventoryPresetItemUpdateErrorMessage : Message
    {
        
        public const int ProtocolId = 6211;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_code;
        
        public virtual byte Code
        {
            get
            {
                return m_code;
            }
            set
            {
                m_code = value;
            }
        }
        
        public InventoryPresetItemUpdateErrorMessage(byte code)
        {
            m_code = code;
        }
        
        public InventoryPresetItemUpdateErrorMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_code);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_code = reader.ReadByte();
        }
    }
}
