//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Types.Game.Context.Roleplay.TreasureHunt
{
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    
    
    using BlueSheep.Protocol;
    
    
    public class TreasureHuntStepFollowDirectionToHint : TreasureHuntStep
    {
        
        public new const int ID = 472;
        
        public virtual int TypeID
        {
            get
            {
                return ID;
            }
        }
        
        private byte m_direction;
        
        public virtual byte Direction
        {
            get
            {
                return m_direction;
            }
            set
            {
                m_direction = value;
            }
        }
        
        private ushort m_npcId;
        
        public virtual ushort NpcId
        {
            get
            {
                return m_npcId;
            }
            set
            {
                m_npcId = value;
            }
        }
        
        public TreasureHuntStepFollowDirectionToHint(byte direction, ushort npcId)
        {
            m_direction = direction;
            m_npcId = npcId;
        }
        
        public TreasureHuntStepFollowDirectionToHint()
        {
        }
        
        public void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_direction);
            writer.WriteVarShort(m_npcId);
        }
        
        public void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_direction = reader.ReadByte();
            m_npcId = reader.ReadVarUhShort();
        }
    }
}
