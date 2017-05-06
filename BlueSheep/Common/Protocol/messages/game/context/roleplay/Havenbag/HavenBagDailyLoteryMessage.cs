//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Havenbag
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class HavenBagDailyLoteryMessage : Message 
    {
        
        public new const int ID = 6644;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_returnType;
        
        public virtual byte ReturnType
        {
            get
            {
                return m_returnType;
            }
            set
            {
                m_returnType = value;
            }
        }
        
        private string m_tokenId;
        
        public virtual string TokenId
        {
            get
            {
                return m_tokenId;
            }
            set
            {
                m_tokenId = value;
            }
        }
        
        public HavenBagDailyLoteryMessage(byte returnType, string tokenId)
        {
            m_returnType = returnType;
            m_tokenId = tokenId;
        }
        
        public HavenBagDailyLoteryMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteByte(m_returnType);
            writer.WriteUTF(m_tokenId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_returnType = reader.ReadByte();
            m_tokenId = reader.ReadUTF();
        }
    }
}
