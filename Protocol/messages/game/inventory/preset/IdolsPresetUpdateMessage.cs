//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Inventory.Preset
{
    using BlueSheep.Protocol.Types.Game.Inventory.Preset;


    public class IdolsPresetUpdateMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6606;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private IdolsPreset m_idolsPreset;
        
        public virtual IdolsPreset IdolsPreset
        {
            get
            {
                return m_idolsPreset;
            }
            set
            {
                m_idolsPreset = value;
            }
        }
        
        public IdolsPresetUpdateMessage(IdolsPreset idolsPreset)
        {
            m_idolsPreset = idolsPreset;
        }
        
        public IdolsPresetUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_idolsPreset.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_idolsPreset = new IdolsPreset();
            m_idolsPreset.Deserialize(reader);
        }
    }
}
