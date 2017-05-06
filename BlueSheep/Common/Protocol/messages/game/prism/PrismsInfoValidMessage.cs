//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Prism
{
    using BlueSheep.Common.Protocol.Types.Game.Prism;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class PrismsInfoValidMessage : Message 
    {
        
        public new const int ID = 6451;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<PrismFightersInformation> m_fights;
        
        public virtual List<PrismFightersInformation> Fights
        {
            get
            {
                return m_fights;
            }
            set
            {
                m_fights = value;
            }
        }
        
        public PrismsInfoValidMessage(List<PrismFightersInformation> fights)
        {
            m_fights = fights;
        }
        
        public PrismsInfoValidMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_fights.Count)));
            int fightsIndex;
            for (fightsIndex = 0; (fightsIndex < m_fights.Count); fightsIndex = (fightsIndex + 1))
            {
                PrismFightersInformation objectToSend = m_fights[fightsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int fightsCount = reader.ReadUShort();
            int fightsIndex;
            m_fights = new System.Collections.Generic.List<PrismFightersInformation>();
            for (fightsIndex = 0; (fightsIndex < fightsCount); fightsIndex = (fightsIndex + 1))
            {
                PrismFightersInformation objectToAdd = new PrismFightersInformation();
                objectToAdd.Deserialize(reader);
                m_fights.Add(objectToAdd);
            }
        }
    }
}
