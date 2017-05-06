//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Roleplay;
    using BlueSheep.Common.Protocol.Types.Game.Look;
    using BlueSheep.Common.Protocol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class GameRolePlayTaxCollectorInformations : GameRolePlayActorInformations
    {
        
        public new const int ID = 148;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private TaxCollectorStaticInformations m_identification;
        
        public virtual TaxCollectorStaticInformations Identification
        {
            get
            {
                return m_identification;
            }
            set
            {
                m_identification = value;
            }
        }
        
        private sbyte m_guildLevel;
        
        public virtual sbyte GuildLevel
        {
            get
            {
                return m_guildLevel;
            }
            set
            {
                m_guildLevel = value;
            }
        }
        
        private int m_taxCollectorAttack;
        
        public virtual int TaxCollectorAttack
        {
            get
            {
                return m_taxCollectorAttack;
            }
            set
            {
                m_taxCollectorAttack = value;
            }
        }
        
        public GameRolePlayTaxCollectorInformations(TaxCollectorStaticInformations identification, sbyte guildLevel, int taxCollectorAttack)
        {
            m_identification = identification;
            m_guildLevel = guildLevel;
            m_taxCollectorAttack = taxCollectorAttack;
        }
        
        public GameRolePlayTaxCollectorInformations()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteUShort(((ushort)(m_identification.TypeID)));
            m_identification.Serialize(writer);
            writer.WriteSByte(m_guildLevel);
            writer.WriteInt(m_taxCollectorAttack);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_identification = ProtocolTypeManager.GetInstance<TaxCollectorStaticInformations>(reader.ReadUShort());
            m_identification.Deserialize(reader);
            m_guildLevel = reader.ReadSByte();
            m_taxCollectorAttack = reader.ReadInt();
        }
    }
}
