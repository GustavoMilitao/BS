//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Lockable
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class LockableUseCodeMessage : Message
    {
        
        public const int ProtocolId = 5667;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_code;
        
        public virtual string Code
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
        
        public LockableUseCodeMessage(string code)
        {
            m_code = code;
        }
        
        public LockableUseCodeMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_code);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_code = reader.ReadUTF();
        }
    }
}
