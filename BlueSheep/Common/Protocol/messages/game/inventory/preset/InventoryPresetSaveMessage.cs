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


    public class InventoryPresetSaveMessage : Message
    {
        
        public const int ProtocolId = 6165;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_presetId;
        
        public virtual byte PresetId
        {
            get
            {
                return m_presetId;
            }
            set
            {
                m_presetId = value;
            }
        }
        
        private byte m_symbolId;
        
        public virtual byte SymbolId
        {
            get
            {
                return m_symbolId;
            }
            set
            {
                m_symbolId = value;
            }
        }
        
        private bool m_saveEquipment;
        
        public virtual bool SaveEquipment
        {
            get
            {
                return m_saveEquipment;
            }
            set
            {
                m_saveEquipment = value;
            }
        }
        
        public InventoryPresetSaveMessage(byte presetId, byte symbolId, bool saveEquipment)
        {
            m_presetId = presetId;
            m_symbolId = symbolId;
            m_saveEquipment = saveEquipment;
        }
        
        public InventoryPresetSaveMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_presetId);
            writer.WriteByte(m_symbolId);
            writer.WriteBoolean(m_saveEquipment);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_presetId = reader.ReadByte();
            m_symbolId = reader.ReadByte();
            m_saveEquipment = reader.ReadBoolean();
        }
    }
}
