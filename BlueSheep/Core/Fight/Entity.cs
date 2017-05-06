﻿namespace BlueSheep.Core.Fight
{
    public class Entity
        {
            public Entity(int id, int cellId)
            {
                Id = id;
                CellId = cellId;
            }

            public int CellId { get; internal set; }
            public int Id { get; protected set; }
        }
}
