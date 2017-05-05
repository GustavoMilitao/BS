﻿using System;

namespace BlueSheep.Interface.Text
{
    class DofInfoCanal : TextInformation
    {
        #region Fields
        private string m_Text;
        #endregion

        #region Properties
        public override string Text
        {
            get { return m_Text; }
            set { m_Text = value; }
        }

        public override Color Color
        {
            get { return ColorTranslator.FromHtml("#008E1C"); }
        }

        public override string Category
        {
            get { return "Dofus"; }
            set { throw new NotImplementedException(); }
        }

        public override string Account
        {
            get { return "Général"; }
            set { throw new NotImplementedException(); }
        }
        #endregion

        #region Constructeurs
        public DofInfoCanal(string text)
        {
            m_Text = text;
        }
        #endregion
    }
}
