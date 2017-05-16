﻿using DataFiles.Data.D2o;
using BlueSheep.Core.Inventory;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BlueSheep.Core.Job
{
    public class Job
    {
        public int Id;
        public List<int> Skills;
        public int Level;
        public int XP;
        public int XpLevelFloor;
        public int XpNextLevelFloor;
        private Account.Account account;
        public string Name
        {
            get { return DataFiles.Data.I18n.I18N.GetText((int)GameData.GetDataObject(D2oFileEnum.Jobs, Id).Fields["nameId"]); }
        }

        public Job(int id, List<int> skills, Account.Account Account)
        {
            Id = id;
            Skills = skills;
            account = Account;
        }

        public bool HasRightTool()
        {
            ArrayList possible_tools = (ArrayList)GameData.GetDataObject(D2oFileEnum.Jobs, Id).Fields["toolIds"];
            Item weapon = account.Inventory.Items.FirstOrDefault(i => i.Position == (int)InventoryPositionEnum.Weapon);
            if (weapon == null)
                return false;
            foreach (int i in possible_tools)
            {
                if (weapon.GID == i)
                    return true;
            }
            return false;
        }

        public bool CanGatherThis(string ressourceName)
        {
            foreach (int skill in Skills)
            {
                DataClass d = GameData.GetDataObject(D2oFileEnum.Skills, skill);
                if ((int)d.Fields["gatheredRessourceItem"] != -1 && DataFiles.Data.I18n.I18N.GetText((int)GameData.GetDataObject(D2oFileEnum.Items, (int)d.Fields["gatheredRessourceItem"]).Fields["nameId"]) == ressourceName)
                    return true;
            }
            return false;
        }
    }
}
