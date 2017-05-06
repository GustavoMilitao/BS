//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Basic
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class BasicSetAwayModeRequestMessage : Message
    {
        
        public const int ProtocolId = 5665;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private bool m_enable;
        
        public virtual bool Enable
        {
            get
            {
                return m_enable;
            }
            set
            {
                m_enable = value;
            }
        }
        
        private bool m_invisible;
        
        public virtual bool Invisible
        {
            get
            {
                return m_invisible;
            }
            set
            {
                m_invisible = value;
            }
        }
        
        public BasicSetAwayModeRequestMessage(bool enable, bool invisible)
        {
            m_enable = enable;
            m_invisible = invisible;
        }
        
        public BasicSetAwayModeRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            byte flag = new byte();
            BooleanByteWrapper.SetFlag(0, flag, m_enable);
            BooleanByteWrapper.SetFlag(1, flag, m_invisible);
            writer.WriteByte(flag);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            byte flag = reader.ReadByte();
            m_enable = BooleanByteWrapper.GetFlag(flag, 0);
            m_invisible = BooleanByteWrapper.GetFlag(flag, 1);
        }
    }
}
