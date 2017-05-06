﻿namespace BlueSheep.Common.Types
{
    public class BEntity
    {
        public BEntity(double id, int cellId)
        {
            Id = id;
            CellId = cellId;
        }

        public int CellId { get; internal set; }
        public double Id { get; protected set; }
    }
}
