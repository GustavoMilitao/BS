﻿using Util.Util.I18n.Strings;
using System;
using System.Drawing;

namespace Util.Util.Text.Log
{
    public class ConnectionTextInformation : TextInformation
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
            get { return Color.Green; }
        }

        public override string Category
        {
            get { return Strings.Connection; }
            set { throw new NotImplementedException(); }
        }

        public override string Account { get; set; }
        #endregion

        #region Constructeurs
        public ConnectionTextInformation(string text)
        {
            m_Text = text;
        }
        #endregion
    }
}
