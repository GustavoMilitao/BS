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

 	 public class TaxCollectorMovementsOfflineMessage : Message 
    {
        
        public new const int ID = 6611;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<TaxCollectorMovement> m_movements;
        
        public virtual List<TaxCollectorMovement> Movements
        {
            get
            {
                return m_movements;
            }
            set
            {
                m_movements = value;
            }
        }
        
        public TaxCollectorMovementsOfflineMessage(List<TaxCollectorMovement> movements)
        {
            m_movements = movements;
        }
        
        public TaxCollectorMovementsOfflineMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_movements.Count)));
            int movementsIndex;
            for (movementsIndex = 0; (movementsIndex < m_movements.Count); movementsIndex = (movementsIndex + 1))
            {
                TaxCollectorMovement objectToSend = m_movements[movementsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int movementsCount = reader.ReadUShort();
            int movementsIndex;
            m_movements = new System.Collections.Generic.List<TaxCollectorMovement>();
            for (movementsIndex = 0; (movementsIndex < movementsCount); movementsIndex = (movementsIndex + 1))
            {
                TaxCollectorMovement objectToAdd = new TaxCollectorMovement();
                objectToAdd.Deserialize(reader);
                m_movements.Add(objectToAdd);
            }
        }
    }
}
