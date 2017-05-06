//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlueSheep.Common.Protocol.Messages.Game.Context.Fight
{
    using BlueSheep.Common.Protocol.Types.Game.Action.Fight;
    using BlueSheep.Common.Protocol.Types.Game.Actions.Fight;
    using BlueSheep.Common.Protocol.Types.Game.Idol;
    using System.Collections.Generic;
    using BlueSheep.Common.Protocol.Messages;
    using BlueSheep.Common.Protocol.Types;
    using BlueSheep.Protocol;
    
    
    using BlueSheep.Engine.Types;

 	 public class GameFightSpectateMessage : Message 
    {
        
        public new const int ID = 6069;
        
        public override int MessageID
        {
            get
            {
                return ID;
            }
        }
        
        private List<FightDispellableEffectExtendedInformations> m_effects;
        
        public virtual List<FightDispellableEffectExtendedInformations> Effects
        {
            get
            {
                return m_effects;
            }
            set
            {
                m_effects = value;
            }
        }
        
        private List<GameActionMark> m_marks;
        
        public virtual List<GameActionMark> Marks
        {
            get
            {
                return m_marks;
            }
            set
            {
                m_marks = value;
            }
        }
        
        private List<Idol> m_idols;
        
        public virtual List<Idol> Idols
        {
            get
            {
                return m_idols;
            }
            set
            {
                m_idols = value;
            }
        }
        
        private ushort m_gameTurn;
        
        public virtual ushort GameTurn
        {
            get
            {
                return m_gameTurn;
            }
            set
            {
                m_gameTurn = value;
            }
        }
        
        private int m_fightStart;
        
        public virtual int FightStart
        {
            get
            {
                return m_fightStart;
            }
            set
            {
                m_fightStart = value;
            }
        }
        
        public GameFightSpectateMessage(List<FightDispellableEffectExtendedInformations> effects, List<GameActionMark> marks, List<Idol> idols, ushort gameTurn, int fightStart)
        {
            m_effects = effects;
            m_marks = marks;
            m_idols = idols;
            m_gameTurn = gameTurn;
            m_fightStart = fightStart;
        }
        
        public GameFightSpectateMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteShort(((short)(m_effects.Count)));
            int effectsIndex;
            for (effectsIndex = 0; (effectsIndex < m_effects.Count); effectsIndex = (effectsIndex + 1))
            {
                FightDispellableEffectExtendedInformations objectToSend = m_effects[effectsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_marks.Count)));
            int marksIndex;
            for (marksIndex = 0; (marksIndex < m_marks.Count); marksIndex = (marksIndex + 1))
            {
                GameActionMark objectToSend = m_marks[marksIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteShort(((short)(m_idols.Count)));
            int idolsIndex;
            for (idolsIndex = 0; (idolsIndex < m_idols.Count); idolsIndex = (idolsIndex + 1))
            {
                Idol objectToSend = m_idols[idolsIndex];
                objectToSend.Serialize(writer);
            }
            writer.WriteVarShort(m_gameTurn);
            writer.WriteInt(m_fightStart);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            int effectsCount = reader.ReadUShort();
            int effectsIndex;
            m_effects = new System.Collections.Generic.List<FightDispellableEffectExtendedInformations>();
            for (effectsIndex = 0; (effectsIndex < effectsCount); effectsIndex = (effectsIndex + 1))
            {
                FightDispellableEffectExtendedInformations objectToAdd = new FightDispellableEffectExtendedInformations();
                objectToAdd.Deserialize(reader);
                m_effects.Add(objectToAdd);
            }
            int marksCount = reader.ReadUShort();
            int marksIndex;
            m_marks = new System.Collections.Generic.List<GameActionMark>();
            for (marksIndex = 0; (marksIndex < marksCount); marksIndex = (marksIndex + 1))
            {
                GameActionMark objectToAdd = new GameActionMark();
                objectToAdd.Deserialize(reader);
                m_marks.Add(objectToAdd);
            }
            int idolsCount = reader.ReadUShort();
            int idolsIndex;
            m_idols = new System.Collections.Generic.List<Idol>();
            for (idolsIndex = 0; (idolsIndex < idolsCount); idolsIndex = (idolsIndex + 1))
            {
                Idol objectToAdd = new Idol();
                objectToAdd.Deserialize(reader);
                m_idols.Add(objectToAdd);
            }
            m_gameTurn = reader.ReadVarUhShort();
            m_fightStart = reader.ReadInt();
        }
    }
}
