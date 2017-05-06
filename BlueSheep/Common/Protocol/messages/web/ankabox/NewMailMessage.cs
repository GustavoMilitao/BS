//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Web.Ankabox
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class NewMailMessage : MailStatusMessage 
    {
        
        public new const int ID = 6292;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<System.Int32> m_sendersAccountId;
        
        public virtual List<System.Int32> SendersAccountId
        {
            get
            {
                return m_sendersAccountId;
            }
            set
            {
                m_sendersAccountId = value;
            }
        }
        
        public NewMailMessage(List<System.Int32> sendersAccountId)
        {
            m_sendersAccountId = sendersAccountId;
        }
        
        public NewMailMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_sendersAccountId.Count)));
            int sendersAccountIdIndex;
            for (sendersAccountIdIndex = 0; (sendersAccountIdIndex < m_sendersAccountId.Count); sendersAccountIdIndex = (sendersAccountIdIndex + 1))
            {
                writer.WriteInt(m_sendersAccountId[sendersAccountIdIndex]);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int sendersAccountIdCount = reader.ReadUShort();
            int sendersAccountIdIndex;
            m_sendersAccountId = new System.Collections.Generic.List<int>();
            for (sendersAccountIdIndex = 0; (sendersAccountIdIndex < sendersAccountIdCount); sendersAccountIdIndex = (sendersAccountIdIndex + 1))
            {
                m_sendersAccountId.Add(reader.ReadInt());
            }
        }
    }
}
