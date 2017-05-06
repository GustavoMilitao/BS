//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Startup
{
    using BlueSheep.Common.Protocol.Types.Game.Startup;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class StartupActionAddMessage : Message
    {
        
        public const int ProtocolId = 6538;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private StartupActionAddObject m_newAction;
        
        public virtual StartupActionAddObject NewAction
        {
            get
            {
                return m_newAction;
            }
            set
            {
                m_newAction = value;
            }
        }
        
        public StartupActionAddMessage(StartupActionAddObject newAction)
        {
            m_newAction = newAction;
        }
        
        public StartupActionAddMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            m_newAction.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_newAction = new StartupActionAddObject();
            m_newAction.Deserialize(reader);
        }
    }
}
