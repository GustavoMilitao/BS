//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Web.Krosmaster
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class KrosmasterTransferRequestMessage : Message 
    {
        
        public new const int ID = 6349;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private string m_uid;
        
        public virtual string Uid
        {
            get
            {
                return m_uid;
            }
            set
            {
                m_uid = value;
            }
        }
        
        public KrosmasterTransferRequestMessage(string uid)
        {
            m_uid = uid;
        }
        
        public KrosmasterTransferRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_uid);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_uid = reader.ReadUTF();
        }
    }
}
