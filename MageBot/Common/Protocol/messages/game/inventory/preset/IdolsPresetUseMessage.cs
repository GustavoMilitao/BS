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


    public class IdolsPresetUseMessage : Message
    {
        
        public const int ProtocolId = 6615;
        
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
        
        private bool m_party;
        
        public virtual bool Party
        {
            get
            {
                return m_party;
            }
            set
            {
                m_party = value;
            }
        }
        
        public IdolsPresetUseMessage(byte presetId, bool party)
        {
            m_presetId = presetId;
            m_party = party;
        }
        
        public IdolsPresetUseMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_presetId);
            writer.WriteBoolean(m_party);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_presetId = reader.ReadByte();
            m_party = reader.ReadBoolean();
        }
    }
}