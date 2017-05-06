//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Actions.Fight
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class FightTriggeredEffect : AbstractFightDispellableEffect
    {
        
        public new const int ID = 210;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private int m_param1;
        
        public virtual int Param1
        {
            get
            {
                return m_param1;
            }
            set
            {
                m_param1 = value;
            }
        }
        
        private int m_param2;
        
        public virtual int Param2
        {
            get
            {
                return m_param2;
            }
            set
            {
                m_param2 = value;
            }
        }
        
        private int m_param3;
        
        public virtual int Param3
        {
            get
            {
                return m_param3;
            }
            set
            {
                m_param3 = value;
            }
        }
        
        private short m_delay;
        
        public virtual short Delay
        {
            get
            {
                return m_delay;
            }
            set
            {
                m_delay = value;
            }
        }
        
        public FightTriggeredEffect(int param1, int param2, int param3, short delay)
        {
            m_param1 = param1;
            m_param2 = param2;
            m_param3 = param3;
            m_delay = delay;
        }
        
        public FightTriggeredEffect()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_param1);
            writer.WriteInt(m_param2);
            writer.WriteInt(m_param3);
            writer.WriteShort(m_delay);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_param1 = reader.ReadInt();
            m_param2 = reader.ReadInt();
            m_param3 = reader.ReadInt();
            m_delay = reader.ReadShort();
        }
    }
}
