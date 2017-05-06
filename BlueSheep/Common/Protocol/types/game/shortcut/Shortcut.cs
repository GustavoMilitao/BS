//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Shortcut
{
    using BlueSheep.Common.Protocol.Types;


    public class Shortcut : NetworkType
    {
        
        public const int ProtocolId = 369;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_slot;
        
        public virtual byte Slot
        {
            get
            {
                return m_slot;
            }
            set
            {
                m_slot = value;
            }
        }
        
        public Shortcut(byte slot)
        {
            m_slot = slot;
        }
        
        public Shortcut()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_slot);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_slot = reader.ReadByte();
        }
    }
}
