//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Common.Basic
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class StatisticDataString : StatisticData
    {
        
        public new const int ID = 487;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private string m_value;
        
        public virtual string Value
        {
            get
            {
                return m_value;
            }
            set
            {
                m_value = value;
            }
        }
        
        public StatisticDataString(string value)
        {
            m_value = value;
        }
        
        public StatisticDataString()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUTF(m_value);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_value = reader.ReadUTF();
        }
    }
}
