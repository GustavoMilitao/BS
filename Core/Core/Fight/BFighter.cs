﻿using MageBot.DataFiles.Data.D2o;
using MageBot.Protocol.Types.Game.Context.Fight;
using MageBot.Core.Base;

namespace MageBot.Core.Fight
{
    public class BFighter : BEntity
    {
        public BFighter(double id, int cellId, int actionPoints, GameFightMinimalStats gameFightMinimalStats, bool isAlive, int lifePoints, int maxLifePoints, int movementPoints, uint teamId, int creatureId) : base(id, cellId)
        {
            ActionPoints = actionPoints;
            GameFightMinimalStats = gameFightMinimalStats;
            IsAlive = isAlive;
            LifePoints = lifePoints;
            MaxLifePoints = maxLifePoints;
            MovementPoints = movementPoints;
            TeamId = teamId;
            CreatureGenericId = creatureId;
        }

        public int ActionPoints { get; set; }
        public GameFightMinimalStats GameFightMinimalStats { get;  set; }
        public bool IsAlive { get;  set; }
        public int LifePoints { get;  set; }
        public int MaxLifePoints { get;  set; }
        public int MovementPoints { get; set; }
        public uint TeamId { get; private set; }
        public int CreatureGenericId { get;  set; }
        private string m_Name = "";

        public string Name
        {
            get
            {
                if (m_Name != "")
                    return m_Name;
                if (CreatureGenericId != 0)
                {
                    DataClass data = GameData.GetDataObject(D2oFileEnum.Monsters, CreatureGenericId);
                    return MageBot.DataFiles.Data.I18n.I18N.GetText((int)data.Fields["nameId"]);
                }
                else
                    return "Unknown";
            }
            set { m_Name = value; }
        }
    }
}
