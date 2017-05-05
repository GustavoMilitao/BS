﻿using BlueSheep.Common.Data;
using BlueSheep.Common.Data.D2o;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueSheep.Common.Types
{
    public class Spell
    {
        public Spell(int id, int level)
        {
            Id = id;
            Level = level;
        }

        public int Id { get; private set; }
        public int Level { get; internal set; }


        public string GetName()
        {
            DataClass spell = GameData.GetDataObject(D2oFileEnum.Spells, Id);
            return I18N.GetText((int)spell.Fields["nameId"]);
        }
    }
}
