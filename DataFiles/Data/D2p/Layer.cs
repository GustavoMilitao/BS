﻿using System.Collections.Generic;
using MageBot.Util.IO;

namespace MageBot.DataFiles.Data.D2p
{
    public class Layer
    {
        // Methods
        internal void Init(BigEndianReader Reader, int MapVersion)
        {
            if (MapVersion >= 9)
                LayerId = Reader.ReadByte();
            else
                LayerId = Reader.ReadInt();
            CellsCount = Reader.ReadShort();
            int cellsCount = CellsCount;
            int i = 1;
            while ((i <= cellsCount))
            {
                Cell item = new Cell();
                item.Init(Reader, MapVersion);
                Cells.Add(item);
                i += 1;
            }
        }

        // Fields
        public List<Cell> Cells = new List<Cell>();
        public int CellsCount;
        public int LayerId;
    }
}
