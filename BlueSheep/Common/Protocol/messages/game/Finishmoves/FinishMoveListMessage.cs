//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Finishmoves
{
    using BlueSheep.Common.Protocol.Types.Game.Finishmoves;
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class FinishMoveListMessage : Message
    {
        
        public const int ProtocolId = 6704;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<FinishMoveInformations> m_finishMoves;
        
        public virtual List<FinishMoveInformations> FinishMoves
        {
            get
            {
                return m_finishMoves;
            }
            set
            {
                m_finishMoves = value;
            }
        }
        
        public FinishMoveListMessage(List<FinishMoveInformations> finishMoves)
        {
            m_finishMoves = finishMoves;
        }
        
        public FinishMoveListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_finishMoves.Count)));
            int finishMovesIndex;
            for (finishMovesIndex = 0; (finishMovesIndex < m_finishMoves.Count); finishMovesIndex = (finishMovesIndex + 1))
            {
                FinishMoveInformations objectToSend = m_finishMoves[finishMovesIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int finishMovesCount = reader.ReadUShort();
            int finishMovesIndex;
            m_finishMoves = new System.Collections.Generic.List<FinishMoveInformations>();
            for (finishMovesIndex = 0; (finishMovesIndex < finishMovesCount); finishMovesIndex = (finishMovesIndex + 1))
            {
                FinishMoveInformations objectToAdd = new FinishMoveInformations();
                objectToAdd.Deserialize(reader);
                m_finishMoves.Add(objectToAdd);
            }
        }
    }
}
