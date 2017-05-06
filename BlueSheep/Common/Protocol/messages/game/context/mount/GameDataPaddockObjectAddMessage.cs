//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Mount
{
    using BlueSheep.Common.Protocol.Types.Game.Paddock;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class GameDataPaddockObjectAddMessage : Message
    {
        
        public const int ProtocolId = 5990;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private PaddockItem m_paddockItemDescription;
        
        public virtual PaddockItem PaddockItemDescription
        {
            get
            {
                return m_paddockItemDescription;
            }
            set
            {
                m_paddockItemDescription = value;
            }
        }
        
        public GameDataPaddockObjectAddMessage(PaddockItem paddockItemDescription)
        {
            m_paddockItemDescription = paddockItemDescription;
        }
        
        public GameDataPaddockObjectAddMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_paddockItemDescription.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_paddockItemDescription = new PaddockItem();
            m_paddockItemDescription.Deserialize(reader);
        }
    }
}
