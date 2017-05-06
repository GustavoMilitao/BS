//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Job
{
    using BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.Job;
    using System.Collections.Generic;
    using BlueSheep.Common;
	using BlueSheep.Common.Protocol.Types;


    public class JobCrafterDirectorySettingsMessage : Message
    {
        
        public const int ProtocolId = 5652;
        
        public override int MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<JobCrafterDirectorySettings> m_craftersSettings;
        
        public virtual List<JobCrafterDirectorySettings> CraftersSettings
        {
            get
            {
                return m_craftersSettings;
            }
            set
            {
                m_craftersSettings = value;
            }
        }
        
        public JobCrafterDirectorySettingsMessage(List<JobCrafterDirectorySettings> craftersSettings)
        {
            m_craftersSettings = craftersSettings;
        }
        
        public JobCrafterDirectorySettingsMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_craftersSettings.Count)));
            int craftersSettingsIndex;
            for (craftersSettingsIndex = 0; (craftersSettingsIndex < m_craftersSettings.Count); craftersSettingsIndex = (craftersSettingsIndex + 1))
            {
                JobCrafterDirectorySettings objectToSend = m_craftersSettings[craftersSettingsIndex];
                objectToSend.Serialize(writer);
            }
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int craftersSettingsCount = reader.ReadUShort();
            int craftersSettingsIndex;
            m_craftersSettings = new System.Collections.Generic.List<JobCrafterDirectorySettings>();
            for (craftersSettingsIndex = 0; (craftersSettingsIndex < craftersSettingsCount); craftersSettingsIndex = (craftersSettingsIndex + 1))
            {
                JobCrafterDirectorySettings objectToAdd = new JobCrafterDirectorySettings();
                objectToAdd.Deserialize(reader);
                m_craftersSettings.Add(objectToAdd);
            }
        }
    }
}
