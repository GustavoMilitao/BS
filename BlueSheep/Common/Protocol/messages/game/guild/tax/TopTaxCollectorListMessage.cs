//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Guild.Tax
{
    using BlueSheep.Common.Protocol.Types.Game.Guild.Tax;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class TopTaxCollectorListMessage : AbstractTaxCollectorListMessage 
    {
        
        public new const int ID = 6565;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private bool m_isDungeon;
        
        public virtual bool IsDungeon
        {
            get
            {
                return m_isDungeon;
            }
            set
            {
                m_isDungeon = value;
            }
        }
        
        public TopTaxCollectorListMessage(bool isDungeon)
        {
            m_isDungeon = isDungeon;
        }
        
        public TopTaxCollectorListMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteBoolean(m_isDungeon);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_isDungeon = reader.ReadBoolean();
        }
    }
}
