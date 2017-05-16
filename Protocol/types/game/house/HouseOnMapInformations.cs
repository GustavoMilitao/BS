//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Protocol.Types.Game.House
{
    using System.Collections.Generic;


    public class HouseOnMapInformations : HouseInformations
    {
        
        protected override int ProtocolId { get; set; } = 510;
        
        public override int TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.Int32> m_doorsOnMap;
        
        public virtual List<System.Int32> DoorsOnMap
        {
            get
            {
                return m_doorsOnMap;
            }
            set
            {
                m_doorsOnMap = value;
            }
        }
        
        private List<HouseInstanceInformations> m_houseInstances;
        
        public virtual List<HouseInstanceInformations> HouseInstances
        {
            get
            {
                return m_houseInstances;
            }
            set
            {
                m_houseInstances = value;
            }
        }
        
        public HouseOnMapInformations(List<System.Int32> doorsOnMap, List<HouseInstanceInformations> houseInstances)
        {
            m_doorsOnMap = doorsOnMap;
            m_houseInstances = houseInstances;
        }
        
        public HouseOnMapInformations()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort(((short)(m_doorsOnMap.Count)));
            int doorsOnMapIndex;
            for (doorsOnMapIndex = 0; (doorsOnMapIndex < m_doorsOnMap.Count); doorsOnMapIndex = (doorsOnMapIndex + 1))
            {
                writer.WriteInt(m_doorsOnMap[doorsOnMapIndex]);
            }
            writer.WriteShort(((short)(m_houseInstances.Count)));
            int houseInstancesIndex;
            for (houseInstancesIndex = 0; (houseInstancesIndex < m_houseInstances.Count); houseInstancesIndex = (houseInstancesIndex + 1))
            {
                HouseInstanceInformations objectToSend = m_houseInstances[houseInstancesIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            int doorsOnMapCount = reader.ReadUShort();
            int doorsOnMapIndex;
            m_doorsOnMap = new System.Collections.Generic.List<int>();
            for (doorsOnMapIndex = 0; (doorsOnMapIndex < doorsOnMapCount); doorsOnMapIndex = (doorsOnMapIndex + 1))
            {
                m_doorsOnMap.Add(reader.ReadInt());
            }
            int houseInstancesCount = reader.ReadUShort();
            int houseInstancesIndex;
            m_houseInstances = new System.Collections.Generic.List<HouseInstanceInformations>();
            for (houseInstancesIndex = 0; (houseInstancesIndex < houseInstancesCount); houseInstancesIndex = (houseInstancesIndex + 1))
            {
                HouseInstanceInformations objectToAdd = new HouseInstanceInformations();
                objectToAdd.Deserialize(reader);
                m_houseInstances.Add(objectToAdd);
            }
        }
    }
}
