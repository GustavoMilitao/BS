//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Social
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Roleplay;


    public class AllianceFactSheetInformations : AllianceInformations
    {
        
        public const int ProtocolId = 421;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_creationDate;
        
        public virtual int CreationDate
        {
            get
            {
                return m_creationDate;
            }
            set
            {
                m_creationDate = value;
            }
        }
        
        public AllianceFactSheetInformations(int creationDate)
        {
            m_creationDate = creationDate;
        }
        
        public AllianceFactSheetInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_creationDate);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_creationDate = reader.ReadInt();
        }
    }
}
