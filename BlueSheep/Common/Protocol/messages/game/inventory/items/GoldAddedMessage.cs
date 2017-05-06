//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Inventory.Items
{
    using BlueSheep.Common.Protocol.Types.Game.Data.Items;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GoldAddedMessage : Message 
    {
        
        public new const int ID = 6030;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private GoldItem m_gold;
        
        public virtual GoldItem Gold
        {
            get
            {
                return m_gold;
            }
            set
            {
                m_gold = value;
            }
        }
        
        public GoldAddedMessage(GoldItem gold)
        {
            m_gold = gold;
        }
        
        public GoldAddedMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_gold.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_gold = new GoldItem();
            m_gold.Deserialize(reader);
        }
    }
}
