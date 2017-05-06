//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Dare
{
    using BlueSheep.Common.Protocol.Types.Game.Dare;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class DareVersatileListMessage : Message 
    {
        
        public new const int ID = 6657;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<DareVersatileInformations> m_dares;
        
        public virtual List<DareVersatileInformations> Dares
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
        
        public DareVersatileListMessage(List<DareVersatileInformations> dares)
        {
            m_dares = dares;
        }
        
        public DareVersatileListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_dares.Count)));
            int daresIndex;
            for (daresIndex = 0; (daresIndex < m_dares.Count); daresIndex = (daresIndex + 1))
            {
                DareVersatileInformations objectToSend = m_dares[daresIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int daresCount = reader.ReadUShort();
            int daresIndex;
            m_dares = new System.Collections.Generic.List<DareVersatileInformations>();
            for (daresIndex = 0; (daresIndex < daresCount); daresIndex = (daresIndex + 1))
            {
                DareVersatileInformations objectToAdd = new DareVersatileInformations();
                objectToAdd.Deserialize(reader);
                m_dares.Add(objectToAdd);
            }
        }
    }
}
