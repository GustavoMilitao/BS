//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Dare
{
    using BlueSheep.Protocol.Types.Game.Dare;
    using System.Collections.Generic;


    public class DareListMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6661;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<DareInformations> m_dares;
        
        public virtual List<DareInformations> Dares
        {
            get
            {
                return m_dares;
            }
            set
            {
                m_dares = value;
            }
        }
        
        public DareListMessage(List<DareInformations> dares)
        {
            m_dares = dares;
        }
        
        public DareListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_dares.Count)));
            int daresIndex;
            for (daresIndex = 0; (daresIndex < m_dares.Count); daresIndex = (daresIndex + 1))
            {
                DareInformations objectToSend = m_dares[daresIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int daresCount = reader.ReadUShort();
            int daresIndex;
            m_dares = new System.Collections.Generic.List<DareInformations>();
            for (daresIndex = 0; (daresIndex < daresCount); daresIndex = (daresIndex + 1))
            {
                DareInformations objectToAdd = new DareInformations();
                objectToAdd.Deserialize(reader);
                m_dares.Add(objectToAdd);
            }
        }
    }
}
