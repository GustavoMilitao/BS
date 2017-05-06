//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Notification
{
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class NotificationByServerMessage : Message
    {
        
        public const int ProtocolId = 6103;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.String> m_parameters;
        
        public virtual List<System.String> Parameters
        {
            get
            {
                return m_parameters;
            }
            set
            {
                m_parameters = value;
            }
        }
        
        private ushort m_ObjectId;
        
        public virtual ushort ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        private bool m_forceOpen;
        
        public virtual bool ForceOpen
        {
            get
            {
                return m_forceOpen;
            }
            set
            {
                m_forceOpen = value;
            }
        }
        
        public NotificationByServerMessage(List<System.String> parameters, ushort objectId, bool forceOpen)
        {
            m_parameters = parameters;
            m_ObjectId = objectId;
            m_forceOpen = forceOpen;
        }
        
        public NotificationByServerMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_parameters.Count)));
            int parametersIndex;
            for (parametersIndex = 0; (parametersIndex < m_parameters.Count); parametersIndex = (parametersIndex + 1))
            {
                writer.WriteUTF(m_parameters[parametersIndex]);
            }
            writer.WriteVarShort(m_ObjectId);
            writer.WriteBoolean(m_forceOpen);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int parametersCount = reader.ReadUShort();
            int parametersIndex;
            m_parameters = new System.Collections.Generic.List<string>();
            for (parametersIndex = 0; (parametersIndex < parametersCount); parametersIndex = (parametersIndex + 1))
            {
                m_parameters.Add(reader.ReadUTF());
            }
            m_ObjectId = reader.ReadVarUhShort();
            m_forceOpen = reader.ReadBoolean();
        }
    }
}
