//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Display
{


    public class DisplayNumericalValueWithAgeBonusMessage : DisplayNumericalValueMessage
    {
        
        public const int ProtocolId = 6361;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private int m_valueOfBonus;
        
        public virtual int ValueOfBonus
        {
            get
            {
                return m_valueOfBonus;
            }
            set
            {
                m_valueOfBonus = value;
            }
        }
        
        public DisplayNumericalValueWithAgeBonusMessage(int valueOfBonus)
        {
            m_valueOfBonus = valueOfBonus;
        }
        
        public DisplayNumericalValueWithAgeBonusMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteInt(m_valueOfBonus);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_valueOfBonus = reader.ReadInt();
        }
    }
}
