//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Interactive
{
    using BlueSheep.Common.Protocol.Types.Game.Interactive;
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class InteractiveMapUpdateMessage : Message
    {
        
        public const int ProtocolId = 5002;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<InteractiveElement> m_interactiveElements;
        
        public virtual List<InteractiveElement> InteractiveElements
        {
            get
            {
                return m_interactiveElements;
            }
            set
            {
                m_interactiveElements = value;
            }
        }
        
        public InteractiveMapUpdateMessage(List<InteractiveElement> interactiveElements)
        {
            m_interactiveElements = interactiveElements;
        }
        
        public InteractiveMapUpdateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_interactiveElements.Count)));
            int interactiveElementsIndex;
            for (interactiveElementsIndex = 0; (interactiveElementsIndex < m_interactiveElements.Count); interactiveElementsIndex = (interactiveElementsIndex + 1))
            {
                InteractiveElement objectToSend = m_interactiveElements[interactiveElementsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int interactiveElementsCount = reader.ReadUShort();
            int interactiveElementsIndex;
            m_interactiveElements = new System.Collections.Generic.List<InteractiveElement>();
            for (interactiveElementsIndex = 0; (interactiveElementsIndex < interactiveElementsCount); interactiveElementsIndex = (interactiveElementsIndex + 1))
            {
                InteractiveElement objectToAdd = ProtocolTypeManager.GetInstance<InteractiveElement>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_interactiveElements.Add(objectToAdd);
            }
        }
    }
}
