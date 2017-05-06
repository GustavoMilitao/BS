//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Friend
{
    using BlueSheep.Common.Protocol.Types.Game.Friend;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class IgnoredListMessage : Message 
    {
        
        public new const int ID = 5674;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<IgnoredInformations> m_ignoredList;
        
        public virtual List<IgnoredInformations> IgnoredList
        {
            get
            {
                return m_ignoredList;
            }
            set
            {
                m_ignoredList = value;
            }
        }
        
        public IgnoredListMessage(List<IgnoredInformations> ignoredList)
        {
            m_ignoredList = ignoredList;
        }
        
        public IgnoredListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_ignoredList.Count)));
            int ignoredListIndex;
            for (ignoredListIndex = 0; (ignoredListIndex < m_ignoredList.Count); ignoredListIndex = (ignoredListIndex + 1))
            {
                IgnoredInformations objectToSend = m_ignoredList[ignoredListIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int ignoredListCount = reader.ReadUShort();
            int ignoredListIndex;
            m_ignoredList = new System.Collections.Generic.List<IgnoredInformations>();
            for (ignoredListIndex = 0; (ignoredListIndex < ignoredListCount); ignoredListIndex = (ignoredListIndex + 1))
            {
                IgnoredInformations objectToAdd = ProtocolTypeManager.GetInstance<IgnoredInformations>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_ignoredList.Add(objectToAdd);
            }
        }
    }
}
