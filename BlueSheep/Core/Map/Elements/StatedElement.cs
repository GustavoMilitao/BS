﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSheep.Core.Map.Elements
{
    public class StatedElement
    {
        public StatedElement(uint cellId, int id, uint state)
        {
            CellId = cellId;
            Id = id;
            State = state;
        }

        public uint CellId { get; private set; }
        public int Id { get; private set; }
        public uint State { get; set; }
    }
}
