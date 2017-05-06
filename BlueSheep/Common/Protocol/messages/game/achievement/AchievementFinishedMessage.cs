//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Achievement
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class AchievementFinishedMessage : Message
    {
        
        public const int ProtocolId = 6208;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
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
        
        private sbyte m_finishedlevel;
        
        public virtual sbyte Finishedlevel
        {
            get
            {
                return m_finishedlevel;
            }
            set
            {
                m_finishedlevel = value;
            }
        }
        
        public AchievementFinishedMessage(ushort objectId, sbyte finishedlevel)
        {
            m_ObjectId = objectId;
            m_finishedlevel = finishedlevel;
        }
        
        public AchievementFinishedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(m_ObjectId);
            writer.WriteSByte(m_finishedlevel);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ObjectId = reader.ReadVarUhShort();
            m_finishedlevel = reader.ReadSByte();
        }
    }
}
