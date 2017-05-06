//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameFightPlacementSwapPositionsOfferMessage : Message
    {
        
        public const int ProtocolId = 6542;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_requestId;
        
        public virtual int RequestId
        {
            get
            {
                return m_requestId;
            }
            set
            {
                m_requestId = value;
            }
        }
        
        private double m_requesterId;
        
        public virtual double RequesterId
        {
            get
            {
                return m_requesterId;
            }
            set
            {
                m_requesterId = value;
            }
        }
        
        private ushort m_requesterCellId;
        
        public virtual ushort RequesterCellId
        {
            get
            {
                return m_requesterCellId;
            }
            set
            {
                m_requesterCellId = value;
            }
        }
        
        private double m_requestedId;
        
        public virtual double RequestedId
        {
            get
            {
                return m_requestedId;
            }
            set
            {
                m_requestedId = value;
            }
        }
        
        private ushort m_requestedCellId;
        
        public virtual ushort RequestedCellId
        {
            get
            {
                return m_requestedCellId;
            }
            set
            {
                m_requestedCellId = value;
            }
        }
        
        public GameFightPlacementSwapPositionsOfferMessage(int requestId, double requesterId, ushort requesterCellId, double requestedId, ushort requestedCellId)
        {
            m_requestId = requestId;
            m_requesterId = requesterId;
            m_requesterCellId = requesterCellId;
            m_requestedId = requestedId;
            m_requestedCellId = requestedCellId;
        }
        
        public GameFightPlacementSwapPositionsOfferMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteInt(m_requestId);
            writer.WriteDouble(m_requesterId);
            writer.WriteVarShort(m_requesterCellId);
            writer.WriteDouble(m_requestedId);
            writer.WriteVarShort(m_requestedCellId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_requestId = reader.ReadInt();
            m_requesterId = reader.ReadDouble();
            m_requesterCellId = reader.ReadVarUhShort();
            m_requestedId = reader.ReadDouble();
            m_requestedCellId = reader.ReadVarUhShort();
        }
    }
}
