//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Mount
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class UpdateMountIntBoost : UpdateMountBoost
    {
        
        public new const int ID = 357;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private int m_value;
        
        public virtual int Value
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
        
        public UpdateMountIntBoost(int value)
        {
            m_value = value;
        }
        
        public UpdateMountIntBoost()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_value);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_value = reader.ReadInt();
        }
    }
}
