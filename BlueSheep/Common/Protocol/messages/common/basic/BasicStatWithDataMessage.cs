//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Common.Basic
{
    using BlueSheep.Common.Protocol.Types.Common.Basic;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class BasicStatWithDataMessage : BasicStatMessage 
    {
        
        public new const int ID = 6573;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<StatisticData> m_datas;
        
        public virtual List<StatisticData> Datas
        {
            get
            {
                return m_datas;
            }
            set
            {
                m_datas = value;
            }
        }
        
        public BasicStatWithDataMessage(List<StatisticData> datas)
        {
            m_datas = datas;
        }
        
        public BasicStatWithDataMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_datas.Count)));
            int datasIndex;
            for (datasIndex = 0; (datasIndex < m_datas.Count); datasIndex = (datasIndex + 1))
            {
                StatisticData objectToSend = m_datas[datasIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int datasCount = reader.ReadUShort();
            int datasIndex;
            m_datas = new System.Collections.Generic.List<StatisticData>();
            for (datasIndex = 0; (datasIndex < datasCount); datasIndex = (datasIndex + 1))
            {
                StatisticData objectToAdd = ProtocolTypeManager.GetInstance<StatisticData>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_datas.Add(objectToAdd);
            }
        }
    }
}
