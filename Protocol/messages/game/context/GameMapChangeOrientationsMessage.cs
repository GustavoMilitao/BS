//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Messages.Game.Context
{
    using BlueSheep.Protocol.Types.Game.Context;
    using System.Collections.Generic;


    public class GameMapChangeOrientationsMessage : Message
    {
        
        protected override int ProtocolId { get; set; } = 6155;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<ActorOrientation> m_orientations;
        
        public virtual List<ActorOrientation> Orientations
        {
            get
            {
                return m_orientations;
            }
            set
            {
                m_orientations = value;
            }
        }
        
        public GameMapChangeOrientationsMessage(List<ActorOrientation> orientations)
        {
            m_orientations = orientations;
        }
        
        public GameMapChangeOrientationsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_orientations.Count)));
            int orientationsIndex;
            for (orientationsIndex = 0; (orientationsIndex < m_orientations.Count); orientationsIndex = (orientationsIndex + 1))
            {
                ActorOrientation objectToSend = m_orientations[orientationsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int orientationsCount = reader.ReadUShort();
            int orientationsIndex;
            m_orientations = new System.Collections.Generic.List<ActorOrientation>();
            for (orientationsIndex = 0; (orientationsIndex < orientationsCount); orientationsIndex = (orientationsIndex + 1))
            {
                ActorOrientation objectToAdd = new ActorOrientation();
                objectToAdd.Deserialize(reader);
                m_orientations.Add(objectToAdd);
            }
        }
    }
}
