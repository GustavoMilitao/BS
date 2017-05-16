//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.Context.Roleplay
{
    using BlueSheep.Protocol.Types.Game.Character.Restriction;
    using System.Collections.Generic;
    using BlueSheep.Protocol.Types;


    public class HumanInformations : NetworkType
    {
        
        protected override int ProtocolId { get; set; } = 157;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ActorRestrictionsInformations m_restrictions;
        
        public virtual ActorRestrictionsInformations Restrictions
        {
            get
            {
                return m_restrictions;
            }
            set
            {
                m_restrictions = value;
            }
        }
        
        private List<HumanOption> m_options;
        
        public virtual List<HumanOption> Options
        {
            get
            {
                return m_options;
            }
            set
            {
                m_options = value;
            }
        }
        
        private bool m_sex;
        
        public virtual bool Sex
        {
            get
            {
                return m_sex;
            }
            set
            {
                m_sex = value;
            }
        }
        
        public HumanInformations(ActorRestrictionsInformations restrictions, List<HumanOption> options, bool sex)
        {
            m_restrictions = restrictions;
            m_options = options;
            m_sex = sex;
        }
        
        public HumanInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_restrictions.Serialize(writer);
            writer.WriteShort(((short)(m_options.Count)));
            int optionsIndex;
            for (optionsIndex = 0; (optionsIndex < m_options.Count); optionsIndex = (optionsIndex + 1))
            {
                HumanOption objectToSend = m_options[optionsIndex];
                writer.WriteUShort(((ushort)(objectToSend.TypeID)));
                objectToSend.Serialize(writer);
            }
            writer.WriteBoolean(m_sex);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_restrictions = new ActorRestrictionsInformations();
            m_restrictions.Deserialize(reader);
            m_sex = reader.ReadBoolean();
            int optionsCount = reader.ReadUShort();
            int optionsIndex;
            m_options = new System.Collections.Generic.List<HumanOption>();
            for (optionsIndex = 0; (optionsIndex < optionsCount); optionsIndex = (optionsIndex + 1))
            {
                HumanOption objectToAdd = ProtocolTypeManager.GetInstance<HumanOption>(reader.ReadUShort());
                objectToAdd.Deserialize(reader);
                m_options.Add(objectToAdd);
            }
        }
    }
}
