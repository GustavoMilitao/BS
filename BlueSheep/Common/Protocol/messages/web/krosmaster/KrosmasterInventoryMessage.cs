//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Web.Krosmaster
{
    using BlueSheep.Common.Protocol.Types.Web.Krosmaster;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class KrosmasterInventoryMessage : Message 
    {
        
        public new const int ID = 6350;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<KrosmasterFigure> m_figures;
        
        public virtual List<KrosmasterFigure> Figures
        {
            get
            {
                return m_figures;
            }
            set
            {
                m_figures = value;
            }
        }
        
        public KrosmasterInventoryMessage(List<KrosmasterFigure> figures)
        {
            m_figures = figures;
        }
        
        public KrosmasterInventoryMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_figures.Count)));
            int figuresIndex;
            for (figuresIndex = 0; (figuresIndex < m_figures.Count); figuresIndex = (figuresIndex + 1))
            {
                KrosmasterFigure objectToSend = m_figures[figuresIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int figuresCount = reader.ReadUShort();
            int figuresIndex;
            m_figures = new System.Collections.Generic.List<KrosmasterFigure>();
            for (figuresIndex = 0; (figuresIndex < figuresCount); figuresIndex = (figuresIndex + 1))
            {
                KrosmasterFigure objectToAdd = new KrosmasterFigure();
                objectToAdd.Deserialize(reader);
                m_figures.Add(objectToAdd);
            }
        }
    }
}
