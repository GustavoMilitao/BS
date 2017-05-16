//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context.Roleplay.Npc
{
    using System.Collections.Generic;


    public class NpcDialogQuestionMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 5617;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.String> m_dialogParams;
        
        public virtual List<System.String> DialogParams
        {
            get
            {
                return m_dialogParams;
            }
            set
            {
                m_dialogParams = value;
            }
        }
        
        private List<System.UInt32> m_visibleReplies;
        
        public virtual List<System.UInt32> VisibleReplies
        {
            get
            {
                return m_visibleReplies;
            }
            set
            {
                m_visibleReplies = value;
            }
        }
        
        private uint m_messageId;
        
        public virtual uint MessageId
        {
            get
            {
                return m_messageId;
            }
            set
            {
                m_messageId = value;
            }
        }
        
        public NpcDialogQuestionMessage(List<System.String> dialogParams, List<System.UInt32> visibleReplies, uint messageId)
        {
            m_dialogParams = dialogParams;
            m_visibleReplies = visibleReplies;
            m_messageId = messageId;
        }
        
        public NpcDialogQuestionMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_dialogParams.Count)));
            int dialogParamsIndex;
            for (dialogParamsIndex = 0; (dialogParamsIndex < m_dialogParams.Count); dialogParamsIndex = (dialogParamsIndex + 1))
            {
                writer.WriteUTF(m_dialogParams[dialogParamsIndex]);
            }
            writer.WriteShort(((short)(m_visibleReplies.Count)));
            int visibleRepliesIndex;
            for (visibleRepliesIndex = 0; (visibleRepliesIndex < m_visibleReplies.Count); visibleRepliesIndex = (visibleRepliesIndex + 1))
            {
                writer.WriteVarInt(m_visibleReplies[visibleRepliesIndex]);
            }
            writer.WriteVarInt(m_messageId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int dialogParamsCount = reader.ReadUShort();
            int dialogParamsIndex;
            m_dialogParams = new System.Collections.Generic.List<string>();
            for (dialogParamsIndex = 0; (dialogParamsIndex < dialogParamsCount); dialogParamsIndex = (dialogParamsIndex + 1))
            {
                m_dialogParams.Add(reader.ReadUTF());
            }
            int visibleRepliesCount = reader.ReadUShort();
            int visibleRepliesIndex;
            m_visibleReplies = new System.Collections.Generic.List<uint>();
            for (visibleRepliesIndex = 0; (visibleRepliesIndex < visibleRepliesCount); visibleRepliesIndex = (visibleRepliesIndex + 1))
            {
                m_visibleReplies.Add(reader.ReadVarUhInt());
            }
            m_messageId = reader.ReadVarUhInt();
        }
    }
}
