//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Roleplay.Fight
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;


    using BlueSheep.Protocol;
    using System;


    using BlueSheep.Engine.Types;

    public class GameRolePlayPlayerFightRequestMessage : Message
    {

        public new const int ID = 5731;

        public override int MessageID
        {
            get
            {
                return ID;
            }
        }

        private ulong m_targetId;

        public virtual ulong TargetId
        {
            get
            {
                return m_targetId;
            }
            set
            {
                m_targetId = value;
            }
        }

        private short m_targetCellId;

        public virtual short TargetCellId
        {
            get
            {
                return m_targetCellId;
            }
            set
            {
                m_targetCellId = value;
            }
        }

        private bool m_friendly;

        public virtual bool Friendly
        {
            get
            {
                return m_friendly;
            }
            set
            {
                m_friendly = value;
            }
        }

        public GameRolePlayPlayerFightRequestMessage(ulong targetId, short targetCellId, bool friendly)
        {
            m_targetId = targetId;
            m_targetCellId = targetCellId;
            m_friendly = friendly;
        }

        public GameRolePlayPlayerFightRequestMessage()
        {
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarLong(m_targetId);
            writer.WriteShort(m_targetCellId);
            writer.WriteBoolean(m_friendly);
        }

        public override void Deserialize(IDataReader reader)
        {
            m_targetId = reader.ReadVarUhLong();
            m_targetCellId = reader.ReadShort();
            m_friendly = reader.ReadBoolean();
        }
    }
}
