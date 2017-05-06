//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Exchanges
{
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class ExchangeOnHumanVendorRequestMessage : Message
    {
        
        public const int ProtocolId = 5772;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_humanVendorId;
        
        public virtual ulong HumanVendorId
        {
            get
            {
                return m_humanVendorId;
            }
            set
            {
                m_humanVendorId = value;
            }
        }
        
        private ushort m_humanVendorCell;
        
        public virtual ushort HumanVendorCell
        {
            get
            {
                return m_humanVendorCell;
            }
            set
            {
                m_humanVendorCell = value;
            }
        }
        
        public ExchangeOnHumanVendorRequestMessage(ulong humanVendorId, ushort humanVendorCell)
        {
            m_humanVendorId = humanVendorId;
            m_humanVendorCell = humanVendorCell;
        }
        
        public ExchangeOnHumanVendorRequestMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_humanVendorId);
            writer.WriteVarShort(m_humanVendorCell);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_humanVendorId = reader.ReadVarUhLong();
            m_humanVendorCell = reader.ReadVarUhShort();
        }
    }
}
