﻿using Util.Util.I18n.Strings;

namespace MageBot.Interface
{
    partial class AccountUC
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountUC));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.PosLabel = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.PathDownBt = new System.Windows.Forms.ToolStripDropDownButton();
            this.LoadPathBt = new System.Windows.Forms.ToolStripMenuItem();
            this.LaunchPathBt = new System.Windows.Forms.ToolStripMenuItem();
            this.StopPathBt = new System.Windows.Forms.ToolStripMenuItem();
            this.RelaunchPath = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LevelLb = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SubcribeLb = new System.Windows.Forms.ToolStripLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.VitaBar = new MetroFramework.Controls.MetroProgressBar();
            this.PodsBar = new MetroFramework.Controls.MetroProgressBar();
            this.XpBar = new MetroFramework.Controls.MetroProgressBar();
            this.PlaceTimer = new System.Windows.Forms.Timer(this.components);
            this.KamasLabel = new MageBot.Interface.SadikLabel();
            this.StatusLb = new MageBot.Interface.SadikLabel();
            this.VTabAccount = new MageBot.Interface.SadikVerticalTabControl();
            this.ConsolePage = new System.Windows.Forms.TabPage();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.CommandeBox = new System.Windows.Forms.TextBox();
            this.LogConsole = new System.Windows.Forms.RichTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.sadikGroupBox2 = new MageBot.Interface.SadikGroupBox();
            this.sadikLabel13 = new MageBot.Interface.SadikLabel();
            this.NUDVerbose = new System.Windows.Forms.NumericUpDown();
            this.sadikGroupBox1 = new MageBot.Interface.SadikGroupBox();
            this.DeleteConfigBt = new MageBot.Interface.SadikButton();
            this.SaveConfig = new MageBot.Interface.SadikButton();
            this.LogCb = new MageBot.Interface.SadikCheckbox();
            this.DebugMode = new MageBot.Interface.SadikCheckbox();
            this.FightPage = new System.Windows.Forms.TabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.LockSpectator = new MageBot.Interface.SadikCheckbox();
            this.AskForHelp = new MageBot.Interface.SadikCheckbox();
            this.LockForParty = new MageBot.Interface.SadikCheckbox();
            this.IsLockingFight = new MageBot.Interface.SadikCheckbox();
            this.NUDTimeoutFight = new System.Windows.Forms.NumericUpDown();
            this.sadikLabel11 = new MageBot.Interface.SadikLabel();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.sadikCheckbox2 = new MageBot.Interface.SadikCheckbox();
            this.NomIA = new MetroFramework.Controls.MetroLabel();
            this.ChoiceIABt = new MageBot.Interface.SadikButton();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.sadikLabel2 = new MageBot.Interface.SadikLabel();
            this.sadikLabel1 = new MageBot.Interface.SadikLabel();
            this.RegenChoice = new System.Windows.Forms.NumericUpDown();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.WithItemSetBox = new MageBot.Interface.SadikCheckbox();
            this.sadikLabel4 = new MageBot.Interface.SadikLabel();
            this.sadikLabel3 = new MageBot.Interface.SadikLabel();
            this.PresetEndUpD = new System.Windows.Forms.NumericUpDown();
            this.PresetStartUpD = new System.Windows.Forms.NumericUpDown();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.lstPopup = new System.Windows.Forms.ListBox();
            this.ForceMonstersBt = new MageBot.Interface.SadikButton();
            this.ForbidMonsterBt = new MageBot.Interface.SadikButton();
            this.MonstersRestrictionsView = new System.Windows.Forms.ListView();
            this.NUDRestrictions = new System.Windows.Forms.NumericUpDown();
            this.ComparateurBox = new MageBot.Interface.SadikCombo();
            this.MonsterTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.sadikLabel6 = new MageBot.Interface.SadikLabel();
            this.sadikLabel5 = new MageBot.Interface.SadikLabel();
            this.lbReplaceMonstersLevel = new System.Windows.Forms.Label();
            this.nudMaxMonstersLevel = new System.Windows.Forms.NumericUpDown();
            this.nudMinMonstersLevel = new System.Windows.Forms.NumericUpDown();
            this.lbReplaceMonstersNumber = new System.Windows.Forms.Label();
            this.nudMaxMonstersNumber = new System.Windows.Forms.NumericUpDown();
            this.nudMinMonstersNumber = new System.Windows.Forms.NumericUpDown();
            this.JobPage = new System.Windows.Forms.TabPage();
            this.JobsTabP = new MageBot.Interface.SadikTabControl();
            this.FamiPage = new System.Windows.Forms.TabPage();
            this.panelAccountInformations = new System.Windows.Forms.Panel();
            this.labelSafe = new MageBot.Interface.SadikLabel();
            this.labelNextMeal = new MageBot.Interface.SadikLabel();
            this.checkBoxBegin = new MageBot.Interface.SadikCheckbox();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.InventairePage = new System.Windows.Forms.TabPage();
            this.sadikTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.RegenAddBt = new MageBot.Interface.SadikButton();
            this.AutoDelAddBt = new MageBot.Interface.SadikButton();
            this.sadikButton2 = new MageBot.Interface.SadikButton();
            this.sadikButton1 = new MageBot.Interface.SadikButton();
            this.DropItems = new MageBot.Interface.SadikButton();
            this.DeleteItem = new MageBot.Interface.SadikButton();
            this.LVItems = new System.Windows.Forms.ListView();
            this.tabPage9 = new MetroFramework.Controls.MetroTabPage();
            this.RegenPage = new MetroFramework.Controls.MetroTabPage();
            this.DiversPage = new System.Windows.Forms.TabPage();
            this.MiscPage = new MetroFramework.Controls.MetroTabControl();
            this.MaisonsPage = new MetroFramework.Controls.MetroTabPage();
            this.sadikLabel9 = new MageBot.Interface.SadikLabel();
            this.ParcourirBt = new MageBot.Interface.SadikButton();
            this.SearcherLogBox = new System.Windows.Forms.TextBox();
            this.HouseSearcherBox = new MageBot.Interface.SadikCheckbox();
            this.sadikLabel8 = new MageBot.Interface.SadikLabel();
            this.sadikLabel7 = new MageBot.Interface.SadikLabel();
            this.StartWaitingBt = new MageBot.Interface.SadikButton();
            this.MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.PhraseADire = new System.Windows.Forms.TextBox();
            this.metroTabPage9 = new MetroFramework.Controls.MetroTabPage();
            this.MapView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContextName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CellId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatsPage = new MetroFramework.Controls.MetroTabPage();
            this.tabPage8 = new MetroFramework.Controls.MetroTabPage();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.marchandPage = new MetroFramework.Controls.MetroTabPage();
            this.BtnActualize = new MageBot.Interface.SadikButton();
            this.sadikButton3 = new MageBot.Interface.SadikButton();
            this.sadikLabel10 = new MageBot.Interface.SadikLabel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LVItemShop = new System.Windows.Forms.ListView();
            this.LVItemBag = new System.Windows.Forms.ListView();
            this.sadikCheckbox1 = new MageBot.Interface.SadikCheckbox();
            this.toolStrip1.SuspendLayout();
            this.VTabAccount.SuspendLayout();
            this.ConsolePage.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.sadikGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDVerbose)).BeginInit();
            this.sadikGroupBox1.SuspendLayout();
            this.FightPage.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTimeoutFight)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegenChoice)).BeginInit();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresetEndUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresetStartUpD)).BeginInit();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRestrictions)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMonstersLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMonstersLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMonstersNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMonstersNumber)).BeginInit();
            this.JobPage.SuspendLayout();
            this.FamiPage.SuspendLayout();
            this.panelAccountInformations.SuspendLayout();
            this.InventairePage.SuspendLayout();
            this.sadikTabControl2.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            this.DiversPage.SuspendLayout();
            this.MiscPage.SuspendLayout();
            this.MaisonsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).BeginInit();
            this.metroTabPage9.SuspendLayout();
            this.marchandPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PosLabel,
            this.ToolStripSeparator3,
            this.PathDownBt,
            this.toolStripSeparator1,
            this.LevelLb,
            this.ToolStripSeparator5,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.SubcribeLb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(613, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Disposed += new System.EventHandler(this.Form_Closed);
            // 
            // PosLabel
            // 
            this.PosLabel.Name = "PosLabel";
            this.PosLabel.Size = new System.Drawing.Size(32, 22);
            this.PosLabel.Text = "[X;Y]";
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // PathDownBt
            // 
            this.PathDownBt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadPathBt,
            this.LaunchPathBt,
            this.StopPathBt,
            this.RelaunchPath});
            this.PathDownBt.Image = ((System.Drawing.Image)(resources.GetObject("PathDownBt.Image")));
            this.PathDownBt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PathDownBt.Name = "PathDownBt";
            this.PathDownBt.Size = new System.Drawing.Size(60, 22);
            this.PathDownBt.Text = "Path";
            // 
            // LoadPathBt
            // 
            this.LoadPathBt.Name = "LoadPathBt";
            this.LoadPathBt.Size = new System.Drawing.Size(240, 22);
            this.LoadPathBt.Text = "Load a path";
            this.LoadPathBt.Click += new System.EventHandler(this.LoadPathBt_Click);
            // 
            // LaunchPathBt
            // 
            this.LaunchPathBt.Name = "LaunchPathBt";
            this.LaunchPathBt.Size = new System.Drawing.Size(240, 22);
            this.LaunchPathBt.Text = "Launch the path";
            this.LaunchPathBt.Click += new System.EventHandler(this.LaunchPathBt_Click);
            // 
            // StopPathBt
            // 
            this.StopPathBt.Name = "StopPathBt";
            this.StopPathBt.Size = new System.Drawing.Size(240, 22);
            this.StopPathBt.Text = "Stop the path";
            this.StopPathBt.Click += new System.EventHandler(this.StopPathBt_Click);
            // 
            // RelaunchPath
            // 
            this.RelaunchPath.CheckOnClick = true;
            this.RelaunchPath.Name = "RelaunchPath";
            this.RelaunchPath.Size = new System.Drawing.Size(240, 22);
            this.RelaunchPath.Text = "✘ Restart the path to reconnect";
            this.RelaunchPath.CheckedChanged += new System.EventHandler(this.RelaunchPath_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LevelLb
            // 
            this.LevelLb.Image = ((System.Drawing.Image)(resources.GetObject("LevelLb.Image")));
            this.LevelLb.Name = "LevelLb";
            this.LevelLb.Size = new System.Drawing.Size(44, 22);
            this.LevelLb.Text = "XXX";
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(170, 22);
            this.toolStripButton1.Text = "Connection/Disconnection";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SubcribeLb
            // 
            this.SubcribeLb.Name = "SubcribeLb";
            this.SubcribeLb.Size = new System.Drawing.Size(87, 22);
            this.SubcribeLb.Text = "Not subscribed";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "patte.png");
            this.imageList1.Images.SetKeyName(1, "logo_combat.PNG");
            this.imageList1.Images.SetKeyName(2, "logo_inventaire.png");
            this.imageList1.Images.SetKeyName(3, "logo_maison.PNG");
            this.imageList1.Images.SetKeyName(4, "logo_recolte.PNG");
            this.imageList1.Images.SetKeyName(5, "settings.png");
            // 
            // VitaBar
            // 
            this.VitaBar.HideProgressText = false;
            this.VitaBar.Location = new System.Drawing.Point(112, 434);
            this.VitaBar.Name = "VitaBar";
            this.VitaBar.Size = new System.Drawing.Size(115, 23);
            this.VitaBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.VitaBar.TabIndex = 9;
            this.VitaBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VitaBar.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // PodsBar
            // 
            this.PodsBar.HideProgressText = false;
            this.PodsBar.Location = new System.Drawing.Point(233, 434);
            this.PodsBar.Name = "PodsBar";
            this.PodsBar.Size = new System.Drawing.Size(122, 23);
            this.PodsBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.PodsBar.TabIndex = 20;
            this.PodsBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PodsBar.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // XpBar
            // 
            this.XpBar.HideProgressText = false;
            this.XpBar.Location = new System.Drawing.Point(361, 434);
            this.XpBar.Name = "XpBar";
            this.XpBar.Size = new System.Drawing.Size(115, 23);
            this.XpBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.XpBar.TabIndex = 10;
            this.XpBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.XpBar.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // PlaceTimer
            // 
            this.PlaceTimer.Interval = 10000;
            this.PlaceTimer.Tick += new System.EventHandler(this.PlaceTimer_Tick);
            // 
            // KamasLabel
            // 
            this.KamasLabel.AutoSize = true;
            this.KamasLabel.BackColor = System.Drawing.Color.Transparent;
            this.KamasLabel.Font = new System.Drawing.Font("Verdana", 8F);
            this.KamasLabel.ForeColor = System.Drawing.Color.Black;
            this.KamasLabel.Location = new System.Drawing.Point(492, 438);
            this.KamasLabel.Name = "KamasLabel";
            this.KamasLabel.Size = new System.Drawing.Size(57, 13);
            this.KamasLabel.TabIndex = 13;
            this.KamasLabel.Text = "0 Kamas";
            // 
            // StatusLb
            // 
            this.StatusLb.AutoSize = true;
            this.StatusLb.BackColor = System.Drawing.Color.Transparent;
            this.StatusLb.Font = new System.Drawing.Font("Verdana", 8F);
            this.StatusLb.ForeColor = System.Drawing.Color.Black;
            this.StatusLb.Location = new System.Drawing.Point(15, 438);
            this.StatusLb.Name = "StatusLb";
            this.StatusLb.Size = new System.Drawing.Size(83, 13);
            this.StatusLb.TabIndex = 10;
            this.StatusLb.Text = "Disconnected";
            // 
            // VTabAccount
            // 
            this.VTabAccount.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.VTabAccount.Controls.Add(this.ConsolePage);
            this.VTabAccount.Controls.Add(this.FightPage);
            this.VTabAccount.Controls.Add(this.JobPage);
            this.VTabAccount.Controls.Add(this.FamiPage);
            this.VTabAccount.Controls.Add(this.InventairePage);
            this.VTabAccount.Controls.Add(this.DiversPage);
            this.VTabAccount.ImageList = this.imageList1;
            this.VTabAccount.ItemSize = new System.Drawing.Size(30, 100);
            this.VTabAccount.Location = new System.Drawing.Point(0, 28);
            this.VTabAccount.Multiline = true;
            this.VTabAccount.Name = "VTabAccount";
            this.VTabAccount.SelectedIndex = 0;
            this.VTabAccount.Size = new System.Drawing.Size(603, 400);
            this.VTabAccount.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.VTabAccount.TabIndex = 7;
            // 
            // ConsolePage
            // 
            this.ConsolePage.Controls.Add(this.metroTabControl1);
            this.ConsolePage.Location = new System.Drawing.Point(104, 4);
            this.ConsolePage.Name = "ConsolePage";
            this.ConsolePage.Padding = new System.Windows.Forms.Padding(3);
            this.ConsolePage.Size = new System.Drawing.Size(495, 392);
            this.ConsolePage.TabIndex = 0;
            this.ConsolePage.Text = "Console";
            this.ConsolePage.UseVisualStyleBackColor = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(489, 386);
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.CommandeBox);
            this.metroTabPage1.Controls.Add(this.LogConsole);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(481, 344);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Console";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // CommandeBox
            // 
            this.CommandeBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CommandeBox.Location = new System.Drawing.Point(0, 324);
            this.CommandeBox.Name = "CommandeBox";
            this.CommandeBox.Size = new System.Drawing.Size(481, 20);
            this.CommandeBox.TabIndex = 8;
            this.CommandeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandeBox_KeyDown);
            // 
            // LogConsole
            // 
            this.LogConsole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogConsole.BackColor = System.Drawing.Color.White;
            this.LogConsole.Location = new System.Drawing.Point(-2, 8);
            this.LogConsole.Name = "LogConsole";
            this.LogConsole.ReadOnly = true;
            this.LogConsole.Size = new System.Drawing.Size(484, 315);
            this.LogConsole.TabIndex = 7;
            this.LogConsole.Text = "";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.sadikGroupBox2);
            this.metroTabPage2.Controls.Add(this.sadikGroupBox1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(481, 344);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Configuration";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // sadikGroupBox2
            // 
            this.sadikGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.sadikGroupBox2.Controls.Add(this.sadikLabel13);
            this.sadikGroupBox2.Controls.Add(this.NUDVerbose);
            this.sadikGroupBox2.Location = new System.Drawing.Point(3, 16);
            this.sadikGroupBox2.Name = "sadikGroupBox2";
            this.sadikGroupBox2.Size = new System.Drawing.Size(299, 55);
            this.sadikGroupBox2.TabIndex = 8;
            this.sadikGroupBox2.Text = "sadikGroupBox2";
            // 
            // sadikLabel13
            // 
            this.sadikLabel13.AutoSize = true;
            this.sadikLabel13.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel13.Location = new System.Drawing.Point(15, 20);
            this.sadikLabel13.Name = "sadikLabel13";
            this.sadikLabel13.Size = new System.Drawing.Size(104, 13);
            this.sadikLabel13.TabIndex = 3;
            this.sadikLabel13.Text = "Verbosity level : ";
            // 
            // NUDVerbose
            // 
            this.NUDVerbose.Location = new System.Drawing.Point(155, 18);
            this.NUDVerbose.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NUDVerbose.Name = "NUDVerbose";
            this.NUDVerbose.Size = new System.Drawing.Size(46, 20);
            this.NUDVerbose.TabIndex = 2;
            this.NUDVerbose.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NUDVerbose.ValueChanged += new System.EventHandler(this.NUDVerbose_ValueChanged);
            // 
            // sadikGroupBox1
            // 
            this.sadikGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.sadikGroupBox1.Controls.Add(this.DeleteConfigBt);
            this.sadikGroupBox1.Controls.Add(this.SaveConfig);
            this.sadikGroupBox1.Controls.Add(this.LogCb);
            this.sadikGroupBox1.Controls.Add(this.DebugMode);
            this.sadikGroupBox1.Location = new System.Drawing.Point(3, 77);
            this.sadikGroupBox1.Name = "sadikGroupBox1";
            this.sadikGroupBox1.Size = new System.Drawing.Size(299, 194);
            this.sadikGroupBox1.TabIndex = 7;
            this.sadikGroupBox1.Text = "sadikGroupBox1";
            // 
            // DeleteConfigBt
            // 
            this.DeleteConfigBt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.DeleteConfigBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteConfigBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.DeleteConfigBt.Image = null;
            this.DeleteConfigBt.Location = new System.Drawing.Point(18, 126);
            this.DeleteConfigBt.Name = "DeleteConfigBt";
            this.DeleteConfigBt.RoundedCorners = false;
            this.DeleteConfigBt.Size = new System.Drawing.Size(183, 48);
            this.DeleteConfigBt.TabIndex = 10;
            this.DeleteConfigBt.Text = "Remove configuration";
            this.DeleteConfigBt.Click += new System.EventHandler(this.DeleteConfigBt_Click_1);
            // 
            // SaveConfig
            // 
            this.SaveConfig.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.SaveConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveConfig.Font = new System.Drawing.Font("Verdana", 8F);
            this.SaveConfig.Image = null;
            this.SaveConfig.Location = new System.Drawing.Point(18, 69);
            this.SaveConfig.Name = "SaveConfig";
            this.SaveConfig.RoundedCorners = false;
            this.SaveConfig.Size = new System.Drawing.Size(183, 51);
            this.SaveConfig.TabIndex = 9;
            this.SaveConfig.Text = "Save configuration";
            this.SaveConfig.Click += new System.EventHandler(this.SaveConfig_Click_1);
            // 
            // LogCb
            // 
            this.LogCb.Checked = false;
            this.LogCb.Font = new System.Drawing.Font("Verdana", 8F);
            this.LogCb.Location = new System.Drawing.Point(25, 43);
            this.LogCb.Name = "LogCb";
            this.LogCb.Size = new System.Drawing.Size(140, 20);
            this.LogCb.TabIndex = 8;
            this.LogCb.Text = "Log the console";
            this.LogCb.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.LogCb_CheckedChanged);
            // 
            // DebugMode
            // 
            this.DebugMode.Checked = false;
            this.DebugMode.Font = new System.Drawing.Font("Verdana", 8F);
            this.DebugMode.Location = new System.Drawing.Point(25, 17);
            this.DebugMode.Name = "DebugMode";
            this.DebugMode.Size = new System.Drawing.Size(140, 20);
            this.DebugMode.TabIndex = 7;
            this.DebugMode.Text = "Debug mode";
            this.DebugMode.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.DebugMode_CheckedChanged);
            // 
            // FightPage
            // 
            this.FightPage.Controls.Add(this.metroTabControl2);
            this.FightPage.ImageIndex = 1;
            this.FightPage.Location = new System.Drawing.Point(104, 4);
            this.FightPage.Name = "FightPage";
            this.FightPage.Padding = new System.Windows.Forms.Padding(3);
            this.FightPage.Size = new System.Drawing.Size(495, 392);
            this.FightPage.TabIndex = 1;
            this.FightPage.Text = "Combat";
            this.FightPage.UseVisualStyleBackColor = true;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage4);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(489, 386);
            this.metroTabControl2.TabIndex = 1;
            this.metroTabControl2.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.groupBox8);
            this.metroTabPage3.Controls.Add(this.GroupBox2);
            this.metroTabPage3.Controls.Add(this.GroupBox3);
            this.metroTabPage3.Controls.Add(this.GroupBox4);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(481, 344);
            this.metroTabPage3.TabIndex = 0;
            this.metroTabPage3.Text = "Configuration";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.LockSpectator);
            this.groupBox8.Controls.Add(this.AskForHelp);
            this.groupBox8.Controls.Add(this.LockForParty);
            this.groupBox8.Controls.Add(this.IsLockingFight);
            this.groupBox8.Controls.Add(this.NUDTimeoutFight);
            this.groupBox8.Controls.Add(this.sadikLabel11);
            this.groupBox8.Location = new System.Drawing.Point(3, 203);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(478, 138);
            this.groupBox8.TabIndex = 19;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Miscellaneous";
            // 
            // LockSpectator
            // 
            this.LockSpectator.Checked = false;
            this.LockSpectator.Font = new System.Drawing.Font("Verdana", 8F);
            this.LockSpectator.Location = new System.Drawing.Point(162, 71);
            this.LockSpectator.Name = "LockSpectator";
            this.LockSpectator.Size = new System.Drawing.Size(117, 18);
            this.LockSpectator.TabIndex = 9;
            this.LockSpectator.Text = "Lock Spectator";
            this.LockSpectator.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.LockSpectator_CheckedChanged);
            // 
            // AskForHelp
            // 
            this.AskForHelp.Checked = false;
            this.AskForHelp.Font = new System.Drawing.Font("Verdana", 8F);
            this.AskForHelp.Location = new System.Drawing.Point(162, 95);
            this.AskForHelp.Name = "AskForHelp";
            this.AskForHelp.Size = new System.Drawing.Size(105, 18);
            this.AskForHelp.TabIndex = 8;
            this.AskForHelp.Text = "Ask for help";
            this.AskForHelp.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.AskForHelp_CheckedChanged);
            // 
            // LockForParty
            // 
            this.LockForParty.Checked = false;
            this.LockForParty.Font = new System.Drawing.Font("Verdana", 8F);
            this.LockForParty.Location = new System.Drawing.Point(9, 95);
            this.LockForParty.Name = "LockForParty";
            this.LockForParty.Size = new System.Drawing.Size(138, 18);
            this.LockForParty.TabIndex = 7;
            this.LockForParty.Text = "Party Only Combat";
            this.LockForParty.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.LockForParty_CheckedChanged);
            // 
            // IsLockingFight
            // 
            this.IsLockingFight.Checked = false;
            this.IsLockingFight.Font = new System.Drawing.Font("Verdana", 8F);
            this.IsLockingFight.Location = new System.Drawing.Point(9, 71);
            this.IsLockingFight.Name = "IsLockingFight";
            this.IsLockingFight.Size = new System.Drawing.Size(204, 18);
            this.IsLockingFight.TabIndex = 6;
            this.IsLockingFight.Text = "Close combat";
            this.IsLockingFight.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.IsLockingFight_CheckedChanged);
            // 
            // NUDTimeoutFight
            // 
            this.NUDTimeoutFight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDTimeoutFight.Location = new System.Drawing.Point(162, 24);
            this.NUDTimeoutFight.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NUDTimeoutFight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NUDTimeoutFight.Name = "NUDTimeoutFight";
            this.NUDTimeoutFight.Size = new System.Drawing.Size(30, 20);
            this.NUDTimeoutFight.TabIndex = 1;
            this.NUDTimeoutFight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDTimeoutFight.ValueChanged += new System.EventHandler(this.NUDTimeoutFight_ValueChanged);
            // 
            // sadikLabel11
            // 
            this.sadikLabel11.AutoSize = true;
            this.sadikLabel11.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel11.Location = new System.Drawing.Point(6, 26);
            this.sadikLabel11.Name = "sadikLabel11";
            this.sadikLabel11.Size = new System.Drawing.Size(141, 13);
            this.sadikLabel11.TabIndex = 0;
            this.sadikLabel11.Text = "Speed setting: Speed x";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.sadikCheckbox2);
            this.GroupBox2.Controls.Add(this.NomIA);
            this.GroupBox2.Controls.Add(this.ChoiceIABt);
            this.GroupBox2.Location = new System.Drawing.Point(3, 3);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(478, 61);
            this.GroupBox2.TabIndex = 16;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "AI and Path";
            // 
            // sadikCheckbox2
            // 
            this.sadikCheckbox2.Checked = false;
            this.sadikCheckbox2.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikCheckbox2.Location = new System.Drawing.Point(303, 33);
            this.sadikCheckbox2.Name = "sadikCheckbox2";
            this.sadikCheckbox2.Size = new System.Drawing.Size(106, 18);
            this.sadikCheckbox2.TabIndex = 6;
            this.sadikCheckbox2.Text = "Relaunch path";
            this.sadikCheckbox2.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.sadikCheckbox2_CheckedChanged);
            // 
            // NomIA
            // 
            this.NomIA.AutoSize = true;
            this.NomIA.Location = new System.Drawing.Point(22, 22);
            this.NomIA.Name = "NomIA";
            this.NomIA.Size = new System.Drawing.Size(43, 19);
            this.NomIA.TabIndex = 2;
            this.NomIA.Text = "No IA";
            // 
            // ChoiceIABt
            // 
            this.ChoiceIABt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.ChoiceIABt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoiceIABt.Font = new System.Drawing.Font("Verdana", 8F);
            this.ChoiceIABt.Image = null;
            this.ChoiceIABt.Location = new System.Drawing.Point(177, 13);
            this.ChoiceIABt.Name = "ChoiceIABt";
            this.ChoiceIABt.RoundedCorners = false;
            this.ChoiceIABt.Size = new System.Drawing.Size(106, 38);
            this.ChoiceIABt.TabIndex = 1;
            this.ChoiceIABt.Text = "Choose an IA";
            this.ChoiceIABt.Click += new System.EventHandler(this.ChoiceIABt_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.sadikLabel2);
            this.GroupBox3.Controls.Add(this.sadikLabel1);
            this.GroupBox3.Controls.Add(this.RegenChoice);
            this.GroupBox3.Location = new System.Drawing.Point(3, 82);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(478, 44);
            this.GroupBox3.TabIndex = 17;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Regeneration";
            // 
            // sadikLabel2
            // 
            this.sadikLabel2.AutoSize = true;
            this.sadikLabel2.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel2.Location = new System.Drawing.Point(208, 18);
            this.sadikLabel2.Name = "sadikLabel2";
            this.sadikLabel2.Size = new System.Drawing.Size(59, 13);
            this.sadikLabel2.TabIndex = 3;
            this.sadikLabel2.Text = "% of life.";
            // 
            // sadikLabel1
            // 
            this.sadikLabel1.AutoSize = true;
            this.sadikLabel1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel1.Location = new System.Drawing.Point(6, 18);
            this.sadikLabel1.Name = "sadikLabel1";
            this.sadikLabel1.Size = new System.Drawing.Size(109, 13);
            this.sadikLabel1.TabIndex = 2;
            this.sadikLabel1.Text = "Regenerate from:";
            // 
            // RegenChoice
            // 
            this.RegenChoice.Location = new System.Drawing.Point(162, 16);
            this.RegenChoice.Name = "RegenChoice";
            this.RegenChoice.Size = new System.Drawing.Size(40, 20);
            this.RegenChoice.TabIndex = 1;
            this.RegenChoice.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.RegenChoice.ValueChanged += new System.EventHandler(this.RegenChoice_ValueChanged);
            // 
            // GroupBox4
            // 
            this.GroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox4.Controls.Add(this.WithItemSetBox);
            this.GroupBox4.Controls.Add(this.sadikLabel4);
            this.GroupBox4.Controls.Add(this.sadikLabel3);
            this.GroupBox4.Controls.Add(this.PresetEndUpD);
            this.GroupBox4.Controls.Add(this.PresetStartUpD);
            this.GroupBox4.Location = new System.Drawing.Point(3, 132);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(478, 65);
            this.GroupBox4.TabIndex = 18;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Equipment";
            // 
            // WithItemSetBox
            // 
            this.WithItemSetBox.Checked = false;
            this.WithItemSetBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.WithItemSetBox.Location = new System.Drawing.Point(6, 22);
            this.WithItemSetBox.Name = "WithItemSetBox";
            this.WithItemSetBox.Size = new System.Drawing.Size(204, 18);
            this.WithItemSetBox.TabIndex = 5;
            this.WithItemSetBox.Text = "Use the fast equipment number";
            this.WithItemSetBox.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.WithItemSetBox_CheckedChanged);
            // 
            // sadikLabel4
            // 
            this.sadikLabel4.AutoSize = true;
            this.sadikLabel4.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel4.Location = new System.Drawing.Point(273, 41);
            this.sadikLabel4.Name = "sadikLabel4";
            this.sadikLabel4.Size = new System.Drawing.Size(136, 13);
            this.sadikLabel4.TabIndex = 4;
            this.sadikLabel4.Text = "At the end of the fight.";
            // 
            // sadikLabel3
            // 
            this.sadikLabel3.AutoSize = true;
            this.sadikLabel3.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel3.Location = new System.Drawing.Point(273, 22);
            this.sadikLabel3.Name = "sadikLabel3";
            this.sadikLabel3.Size = new System.Drawing.Size(159, 13);
            this.sadikLabel3.TabIndex = 3;
            this.sadikLabel3.Text = "At the entrance in combat.";
            // 
            // PresetEndUpD
            // 
            this.PresetEndUpD.Location = new System.Drawing.Point(241, 39);
            this.PresetEndUpD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PresetEndUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PresetEndUpD.Name = "PresetEndUpD";
            this.PresetEndUpD.Size = new System.Drawing.Size(26, 20);
            this.PresetEndUpD.TabIndex = 2;
            this.PresetEndUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PresetEndUpD.ValueChanged += new System.EventHandler(this.PresetEndUpD_ValueChanged);
            // 
            // PresetStartUpD
            // 
            this.PresetStartUpD.Location = new System.Drawing.Point(241, 20);
            this.PresetStartUpD.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.PresetStartUpD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PresetStartUpD.Name = "PresetStartUpD";
            this.PresetStartUpD.Size = new System.Drawing.Size(26, 20);
            this.PresetStartUpD.TabIndex = 1;
            this.PresetStartUpD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PresetStartUpD.ValueChanged += new System.EventHandler(this.PresetStartUpD_ValueChanged);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.lstPopup);
            this.metroTabPage4.Controls.Add(this.ForceMonstersBt);
            this.metroTabPage4.Controls.Add(this.ForbidMonsterBt);
            this.metroTabPage4.Controls.Add(this.MonstersRestrictionsView);
            this.metroTabPage4.Controls.Add(this.NUDRestrictions);
            this.metroTabPage4.Controls.Add(this.ComparateurBox);
            this.metroTabPage4.Controls.Add(this.MonsterTextBox);
            this.metroTabPage4.Controls.Add(this.GroupBox1);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(481, 344);
            this.metroTabPage4.TabIndex = 1;
            this.metroTabPage4.Text = "Restrictions";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // lstPopup
            // 
            this.lstPopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPopup.FormattingEnabled = true;
            this.lstPopup.ItemHeight = 15;
            this.lstPopup.Location = new System.Drawing.Point(147, 135);
            this.lstPopup.Name = "lstPopup";
            this.lstPopup.Size = new System.Drawing.Size(124, 79);
            this.lstPopup.TabIndex = 34;
            this.lstPopup.Visible = false;
            // 
            // ForceMonstersBt
            // 
            this.ForceMonstersBt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.ForceMonstersBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForceMonstersBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.ForceMonstersBt.Image = null;
            this.ForceMonstersBt.Location = new System.Drawing.Point(397, 89);
            this.ForceMonstersBt.Name = "ForceMonstersBt";
            this.ForceMonstersBt.RoundedCorners = false;
            this.ForceMonstersBt.Size = new System.Drawing.Size(84, 26);
            this.ForceMonstersBt.TabIndex = 31;
            this.ForceMonstersBt.Text = "Force";
            this.ForceMonstersBt.Click += new System.EventHandler(this.ForceMonstersBt_Click);
            // 
            // ForbidMonsterBt
            // 
            this.ForbidMonsterBt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.ForbidMonsterBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForbidMonsterBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.ForbidMonsterBt.Image = null;
            this.ForbidMonsterBt.Location = new System.Drawing.Point(326, 89);
            this.ForbidMonsterBt.Name = "ForbidMonsterBt";
            this.ForbidMonsterBt.RoundedCorners = false;
            this.ForbidMonsterBt.Size = new System.Drawing.Size(65, 26);
            this.ForbidMonsterBt.TabIndex = 30;
            this.ForbidMonsterBt.Text = "Forbidden";
            this.ForbidMonsterBt.Click += new System.EventHandler(this.ForbidMonsterBt_Click);
            // 
            // MonstersRestrictionsView
            // 
            this.MonstersRestrictionsView.Location = new System.Drawing.Point(4, 121);
            this.MonstersRestrictionsView.Name = "MonstersRestrictionsView";
            this.MonstersRestrictionsView.Size = new System.Drawing.Size(477, 163);
            this.MonstersRestrictionsView.TabIndex = 33;
            this.MonstersRestrictionsView.UseCompatibleStateImageBehavior = false;
            this.MonstersRestrictionsView.View = System.Windows.Forms.View.Details;
            // 
            // NUDRestrictions
            // 
            this.NUDRestrictions.Location = new System.Drawing.Point(287, 91);
            this.NUDRestrictions.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.NUDRestrictions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDRestrictions.Name = "NUDRestrictions";
            this.NUDRestrictions.Size = new System.Drawing.Size(32, 20);
            this.NUDRestrictions.TabIndex = 29;
            this.NUDRestrictions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComparateurBox
            // 
            this.ComparateurBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComparateurBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComparateurBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.ComparateurBox.FormattingEnabled = true;
            this.ComparateurBox.ItemHeight = 20;
            this.ComparateurBox.Items.AddRange(new object[] {
            ">",
            "<",
            ">=",
            "<=",
            "=",
            "<>"});
            this.ComparateurBox.Location = new System.Drawing.Point(223, 89);
            this.ComparateurBox.Name = "ComparateurBox";
            this.ComparateurBox.Size = new System.Drawing.Size(58, 26);
            this.ComparateurBox.TabIndex = 28;
            // 
            // MonsterTextBox
            // 
            this.MonsterTextBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.MonsterTextBox.Location = new System.Drawing.Point(4, 90);
            this.MonsterTextBox.Name = "MonsterTextBox";
            this.MonsterTextBox.Size = new System.Drawing.Size(213, 20);
            this.MonsterTextBox.TabIndex = 27;
            this.MonsterTextBox.Text = "Enter the name of the monster...";
            this.MonsterTextBox.GotFocus += new System.EventHandler(this.MonsterTextBox_GetFocus);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.sadikLabel6);
            this.GroupBox1.Controls.Add(this.sadikLabel5);
            this.GroupBox1.Controls.Add(this.lbReplaceMonstersLevel);
            this.GroupBox1.Controls.Add(this.nudMaxMonstersLevel);
            this.GroupBox1.Controls.Add(this.nudMinMonstersLevel);
            this.GroupBox1.Controls.Add(this.lbReplaceMonstersNumber);
            this.GroupBox1.Controls.Add(this.nudMaxMonstersNumber);
            this.GroupBox1.Controls.Add(this.nudMinMonstersNumber);
            this.GroupBox1.Location = new System.Drawing.Point(4, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(477, 71);
            this.GroupBox1.TabIndex = 32;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Monsters restrictions";
            // 
            // sadikLabel6
            // 
            this.sadikLabel6.AutoSize = true;
            this.sadikLabel6.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel6.Location = new System.Drawing.Point(6, 39);
            this.sadikLabel6.Name = "sadikLabel6";
            this.sadikLabel6.Size = new System.Drawing.Size(95, 13);
            this.sadikLabel6.TabIndex = 25;
            this.sadikLabel6.Text = "Monsters levels";
            // 
            // sadikLabel5
            // 
            this.sadikLabel5.AutoSize = true;
            this.sadikLabel5.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel5.Location = new System.Drawing.Point(6, 18);
            this.sadikLabel5.Name = "sadikLabel5";
            this.sadikLabel5.Size = new System.Drawing.Size(93, 13);
            this.sadikLabel5.TabIndex = 24;
            this.sadikLabel5.Text = "Monsters count";
            // 
            // lbReplaceMonstersLevel
            // 
            this.lbReplaceMonstersLevel.AutoSize = true;
            this.lbReplaceMonstersLevel.Location = new System.Drawing.Point(199, 42);
            this.lbReplaceMonstersLevel.Name = "lbReplaceMonstersLevel";
            this.lbReplaceMonstersLevel.Size = new System.Drawing.Size(20, 13);
            this.lbReplaceMonstersLevel.TabIndex = 21;
            this.lbReplaceMonstersLevel.Text = "To";
            // 
            // nudMaxMonstersLevel
            // 
            this.nudMaxMonstersLevel.Location = new System.Drawing.Point(219, 37);
            this.nudMaxMonstersLevel.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMaxMonstersLevel.Name = "nudMaxMonstersLevel";
            this.nudMaxMonstersLevel.Size = new System.Drawing.Size(48, 20);
            this.nudMaxMonstersLevel.TabIndex = 23;
            this.nudMaxMonstersLevel.ThousandsSeparator = true;
            this.nudMaxMonstersLevel.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxMonstersLevel.ValueChanged += new System.EventHandler(this.nudMaxMonstersLevel_ValueChanged);
            // 
            // nudMinMonstersLevel
            // 
            this.nudMinMonstersLevel.Location = new System.Drawing.Point(145, 37);
            this.nudMinMonstersLevel.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudMinMonstersLevel.Name = "nudMinMonstersLevel";
            this.nudMinMonstersLevel.Size = new System.Drawing.Size(48, 20);
            this.nudMinMonstersLevel.TabIndex = 22;
            this.nudMinMonstersLevel.ValueChanged += new System.EventHandler(this.nudMinMonstersLevel_ValueChanged);
            // 
            // lbReplaceMonstersNumber
            // 
            this.lbReplaceMonstersNumber.AutoSize = true;
            this.lbReplaceMonstersNumber.Location = new System.Drawing.Point(199, 18);
            this.lbReplaceMonstersNumber.Name = "lbReplaceMonstersNumber";
            this.lbReplaceMonstersNumber.Size = new System.Drawing.Size(20, 13);
            this.lbReplaceMonstersNumber.TabIndex = 18;
            this.lbReplaceMonstersNumber.Text = "To";
            // 
            // nudMaxMonstersNumber
            // 
            this.nudMaxMonstersNumber.Location = new System.Drawing.Point(219, 16);
            this.nudMaxMonstersNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudMaxMonstersNumber.Name = "nudMaxMonstersNumber";
            this.nudMaxMonstersNumber.Size = new System.Drawing.Size(48, 20);
            this.nudMaxMonstersNumber.TabIndex = 20;
            this.nudMaxMonstersNumber.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudMaxMonstersNumber.ValueChanged += new System.EventHandler(this.nudMaxMonstersNumber_ValueChanged);
            // 
            // nudMinMonstersNumber
            // 
            this.nudMinMonstersNumber.Location = new System.Drawing.Point(145, 16);
            this.nudMinMonstersNumber.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudMinMonstersNumber.Name = "nudMinMonstersNumber";
            this.nudMinMonstersNumber.Size = new System.Drawing.Size(48, 20);
            this.nudMinMonstersNumber.TabIndex = 19;
            this.nudMinMonstersNumber.ValueChanged += new System.EventHandler(this.nudMinMonstersNumber_ValueChanged);
            // 
            // JobPage
            // 
            this.JobPage.Controls.Add(this.JobsTabP);
            this.JobPage.Location = new System.Drawing.Point(104, 4);
            this.JobPage.Name = "JobPage";
            this.JobPage.Padding = new System.Windows.Forms.Padding(3);
            this.JobPage.Size = new System.Drawing.Size(495, 392);
            this.JobPage.TabIndex = 6;
            this.JobPage.Text = "Jobs";
            this.JobPage.UseVisualStyleBackColor = true;
            // 
            // JobsTabP
            // 
            this.JobsTabP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobsTabP.Font = new System.Drawing.Font("Verdana", 8F);
            this.JobsTabP.ItemSize = new System.Drawing.Size(0, 30);
            this.JobsTabP.Location = new System.Drawing.Point(3, 3);
            this.JobsTabP.Name = "JobsTabP";
            this.JobsTabP.SelectedIndex = 0;
            this.JobsTabP.Size = new System.Drawing.Size(489, 386);
            this.JobsTabP.TabIndex = 0;
            // 
            // FamiPage
            // 
            this.FamiPage.Controls.Add(this.panelAccountInformations);
            this.FamiPage.Location = new System.Drawing.Point(104, 4);
            this.FamiPage.Name = "FamiPage";
            this.FamiPage.Padding = new System.Windows.Forms.Padding(3);
            this.FamiPage.Size = new System.Drawing.Size(495, 392);
            this.FamiPage.TabIndex = 2;
            this.FamiPage.Text = "Pets";
            this.FamiPage.UseVisualStyleBackColor = true;
            // 
            // panelAccountInformations
            // 
            this.panelAccountInformations.AutoScroll = true;
            this.panelAccountInformations.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelAccountInformations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAccountInformations.Controls.Add(this.labelSafe);
            this.panelAccountInformations.Controls.Add(this.labelNextMeal);
            this.panelAccountInformations.Controls.Add(this.checkBoxBegin);
            this.panelAccountInformations.Controls.Add(this.listViewPets);
            this.panelAccountInformations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAccountInformations.Location = new System.Drawing.Point(3, 3);
            this.panelAccountInformations.Name = "panelAccountInformations";
            this.panelAccountInformations.Size = new System.Drawing.Size(489, 386);
            this.panelAccountInformations.TabIndex = 3;
            // 
            // labelSafe
            // 
            this.labelSafe.AutoSize = true;
            this.labelSafe.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelSafe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.labelSafe.Location = new System.Drawing.Point(341, 302);
            this.labelSafe.Name = "labelSafe";
            this.labelSafe.Size = new System.Drawing.Size(71, 13);
            this.labelSafe.TabIndex = 12;
            this.labelSafe.Text = "Safe box : ";
            // 
            // labelNextMeal
            // 
            this.labelNextMeal.AutoSize = true;
            this.labelNextMeal.Font = new System.Drawing.Font("Verdana", 8F);
            this.labelNextMeal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.labelNextMeal.Location = new System.Drawing.Point(162, 302);
            this.labelNextMeal.Name = "labelNextMeal";
            this.labelNextMeal.Size = new System.Drawing.Size(134, 13);
            this.labelNextMeal.TabIndex = 11;
            this.labelNextMeal.Text = "Next meal : Unknown.";
            // 
            // checkBoxBegin
            // 
            this.checkBoxBegin.Checked = false;
            this.checkBoxBegin.Font = new System.Drawing.Font("Verdana", 8F);
            this.checkBoxBegin.Location = new System.Drawing.Point(16, 299);
            this.checkBoxBegin.Name = "checkBoxBegin";
            this.checkBoxBegin.Size = new System.Drawing.Size(140, 20);
            this.checkBoxBegin.TabIndex = 10;
            this.checkBoxBegin.Text = "Starting procreation";
            this.checkBoxBegin.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.checkBoxBegin_CheckedChanged);
            // 
            // listViewPets
            // 
            this.listViewPets.Location = new System.Drawing.Point(1, 1);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(482, 290);
            this.listViewPets.TabIndex = 4;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.View = System.Windows.Forms.View.Details;
            // 
            // InventairePage
            // 
            this.InventairePage.Controls.Add(this.sadikTabControl2);
            this.InventairePage.Location = new System.Drawing.Point(104, 4);
            this.InventairePage.Name = "InventairePage";
            this.InventairePage.Padding = new System.Windows.Forms.Padding(3);
            this.InventairePage.Size = new System.Drawing.Size(495, 392);
            this.InventairePage.TabIndex = 4;
            this.InventairePage.Text = "Inventory";
            this.InventairePage.UseVisualStyleBackColor = true;
            // 
            // sadikTabControl2
            // 
            this.sadikTabControl2.Controls.Add(this.metroTabPage6);
            this.sadikTabControl2.Controls.Add(this.tabPage9);
            this.sadikTabControl2.Controls.Add(this.RegenPage);
            this.sadikTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sadikTabControl2.Location = new System.Drawing.Point(3, 3);
            this.sadikTabControl2.Name = "sadikTabControl2";
            this.sadikTabControl2.SelectedIndex = 0;
            this.sadikTabControl2.Size = new System.Drawing.Size(489, 386);
            this.sadikTabControl2.TabIndex = 1;
            this.sadikTabControl2.UseSelectable = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.RegenAddBt);
            this.metroTabPage6.Controls.Add(this.AutoDelAddBt);
            this.metroTabPage6.Controls.Add(this.sadikButton2);
            this.metroTabPage6.Controls.Add(this.sadikButton1);
            this.metroTabPage6.Controls.Add(this.DropItems);
            this.metroTabPage6.Controls.Add(this.DeleteItem);
            this.metroTabPage6.Controls.Add(this.LVItems);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(481, 344);
            this.metroTabPage6.TabIndex = 0;
            this.metroTabPage6.Text = "Inventory";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // RegenAddBt
            // 
            this.RegenAddBt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.RegenAddBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegenAddBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.RegenAddBt.Image = null;
            this.RegenAddBt.Location = new System.Drawing.Point(387, 8);
            this.RegenAddBt.Name = "RegenAddBt";
            this.RegenAddBt.RoundedCorners = false;
            this.RegenAddBt.Size = new System.Drawing.Size(92, 26);
            this.RegenAddBt.TabIndex = 13;
            this.RegenAddBt.Text = "Regeneration";
            this.RegenAddBt.Click += new System.EventHandler(this.RegenAddBt_Click);
            // 
            // AutoDelAddBt
            // 
            this.AutoDelAddBt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.AutoDelAddBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoDelAddBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.AutoDelAddBt.Image = null;
            this.AutoDelAddBt.Location = new System.Drawing.Point(269, 8);
            this.AutoDelAddBt.Name = "AutoDelAddBt";
            this.AutoDelAddBt.RoundedCorners = false;
            this.AutoDelAddBt.Size = new System.Drawing.Size(112, 26);
            this.AutoDelAddBt.TabIndex = 12;
            this.AutoDelAddBt.Text = "Auto delete.";
            this.AutoDelAddBt.Click += new System.EventHandler(this.AutoDelAddBt_Click);
            // 
            // sadikButton2
            // 
            this.sadikButton2.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.sadikButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sadikButton2.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikButton2.Image = null;
            this.sadikButton2.Location = new System.Drawing.Point(207, 8);
            this.sadikButton2.Name = "sadikButton2";
            this.sadikButton2.RoundedCorners = false;
            this.sadikButton2.Size = new System.Drawing.Size(56, 26);
            this.sadikButton2.TabIndex = 11;
            this.sadikButton2.Text = "Equip";
            this.sadikButton2.Click += new System.EventHandler(this.sadikButton2_Click);
            // 
            // sadikButton1
            // 
            this.sadikButton1.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.sadikButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sadikButton1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikButton1.Image = null;
            this.sadikButton1.Location = new System.Drawing.Point(149, 8);
            this.sadikButton1.Name = "sadikButton1";
            this.sadikButton1.RoundedCorners = false;
            this.sadikButton1.Size = new System.Drawing.Size(52, 26);
            this.sadikButton1.TabIndex = 10;
            this.sadikButton1.Text = "Use";
            this.sadikButton1.Click += new System.EventHandler(this.sadikButton1_Click);
            // 
            // DropItems
            // 
            this.DropItems.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.DropItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropItems.Font = new System.Drawing.Font("Verdana", 8F);
            this.DropItems.Image = null;
            this.DropItems.Location = new System.Drawing.Point(90, 8);
            this.DropItems.Name = "DropItems";
            this.DropItems.RoundedCorners = false;
            this.DropItems.Size = new System.Drawing.Size(53, 26);
            this.DropItems.TabIndex = 9;
            this.DropItems.Text = "throw";
            this.DropItems.Click += new System.EventHandler(this.DropItems_Click);
            // 
            // DeleteItem
            // 
            this.DeleteItem.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.DeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.DeleteItem.Image = null;
            this.DeleteItem.Location = new System.Drawing.Point(7, 8);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.RoundedCorners = false;
            this.DeleteItem.Size = new System.Drawing.Size(77, 26);
            this.DeleteItem.TabIndex = 8;
            this.DeleteItem.Text = "Remove";
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // LVItems
            // 
            this.LVItems.BackColor = System.Drawing.Color.White;
            this.LVItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LVItems.FullRowSelect = true;
            this.LVItems.Location = new System.Drawing.Point(0, 40);
            this.LVItems.Name = "LVItems";
            this.LVItems.ShowItemToolTips = true;
            this.LVItems.Size = new System.Drawing.Size(481, 304);
            this.LVItems.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.LVItems.TabIndex = 7;
            this.LVItems.UseCompatibleStateImageBehavior = false;
            this.LVItems.View = System.Windows.Forms.View.Details;
            // 
            // tabPage9
            // 
            this.tabPage9.HorizontalScrollbarBarColor = true;
            this.tabPage9.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage9.HorizontalScrollbarSize = 10;
            this.tabPage9.Location = new System.Drawing.Point(4, 38);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(481, 344);
            this.tabPage9.TabIndex = 1;
            this.tabPage9.Text = "Management";
            this.tabPage9.VerticalScrollbarBarColor = true;
            this.tabPage9.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage9.VerticalScrollbarSize = 10;
            // 
            // RegenPage
            // 
            this.RegenPage.HorizontalScrollbarBarColor = true;
            this.RegenPage.HorizontalScrollbarHighlightOnWheel = false;
            this.RegenPage.HorizontalScrollbarSize = 10;
            this.RegenPage.Location = new System.Drawing.Point(4, 38);
            this.RegenPage.Name = "RegenPage";
            this.RegenPage.Size = new System.Drawing.Size(481, 344);
            this.RegenPage.TabIndex = 2;
            this.RegenPage.Text = "Regeneration";
            this.RegenPage.VerticalScrollbarBarColor = true;
            this.RegenPage.VerticalScrollbarHighlightOnWheel = false;
            this.RegenPage.VerticalScrollbarSize = 10;
            // 
            // DiversPage
            // 
            this.DiversPage.Controls.Add(this.MiscPage);
            this.DiversPage.Location = new System.Drawing.Point(104, 4);
            this.DiversPage.Name = "DiversPage";
            this.DiversPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiversPage.Size = new System.Drawing.Size(495, 392);
            this.DiversPage.TabIndex = 3;
            this.DiversPage.Text = "Miscellaneous";
            this.DiversPage.UseVisualStyleBackColor = true;
            // 
            // MiscPage
            // 
            this.MiscPage.Controls.Add(this.MaisonsPage);
            this.MiscPage.Controls.Add(this.metroTabPage9);
            this.MiscPage.Controls.Add(this.StatsPage);
            this.MiscPage.Controls.Add(this.tabPage8);
            this.MiscPage.Controls.Add(this.tabPage2);
            this.MiscPage.Controls.Add(this.marchandPage);
            this.MiscPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiscPage.Location = new System.Drawing.Point(3, 3);
            this.MiscPage.Name = "MiscPage";
            this.MiscPage.SelectedIndex = 1;
            this.MiscPage.Size = new System.Drawing.Size(489, 386);
            this.MiscPage.TabIndex = 1;
            this.MiscPage.UseSelectable = true;
            // 
            // MaisonsPage
            // 
            this.MaisonsPage.Controls.Add(this.sadikLabel9);
            this.MaisonsPage.Controls.Add(this.ParcourirBt);
            this.MaisonsPage.Controls.Add(this.SearcherLogBox);
            this.MaisonsPage.Controls.Add(this.HouseSearcherBox);
            this.MaisonsPage.Controls.Add(this.sadikLabel8);
            this.MaisonsPage.Controls.Add(this.sadikLabel7);
            this.MaisonsPage.Controls.Add(this.StartWaitingBt);
            this.MaisonsPage.Controls.Add(this.MaxPrice);
            this.MaisonsPage.Controls.Add(this.PhraseADire);
            this.MaisonsPage.HorizontalScrollbarBarColor = true;
            this.MaisonsPage.HorizontalScrollbarHighlightOnWheel = false;
            this.MaisonsPage.HorizontalScrollbarSize = 10;
            this.MaisonsPage.Location = new System.Drawing.Point(4, 38);
            this.MaisonsPage.Name = "MaisonsPage";
            this.MaisonsPage.Size = new System.Drawing.Size(481, 344);
            this.MaisonsPage.TabIndex = 0;
            this.MaisonsPage.Text = "Houses";
            this.MaisonsPage.VerticalScrollbarBarColor = true;
            this.MaisonsPage.VerticalScrollbarHighlightOnWheel = false;
            this.MaisonsPage.VerticalScrollbarSize = 10;
            // 
            // sadikLabel9
            // 
            this.sadikLabel9.AutoSize = true;
            this.sadikLabel9.BackColor = System.Drawing.Color.Transparent;
            this.sadikLabel9.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel9.Location = new System.Drawing.Point(35, 216);
            this.sadikLabel9.Name = "sadikLabel9";
            this.sadikLabel9.Size = new System.Drawing.Size(118, 13);
            this.sadikLabel9.TabIndex = 28;
            this.sadikLabel9.Text = "Search for log file :";
            // 
            // ParcourirBt
            // 
            this.ParcourirBt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.ParcourirBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ParcourirBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.ParcourirBt.Image = null;
            this.ParcourirBt.Location = new System.Drawing.Point(374, 226);
            this.ParcourirBt.Name = "ParcourirBt";
            this.ParcourirBt.RoundedCorners = false;
            this.ParcourirBt.Size = new System.Drawing.Size(95, 26);
            this.ParcourirBt.TabIndex = 27;
            this.ParcourirBt.Text = "Browse";
            this.ParcourirBt.Click += new System.EventHandler(this.ParcourirBt_Click);
            // 
            // SearcherLogBox
            // 
            this.SearcherLogBox.Location = new System.Drawing.Point(38, 232);
            this.SearcherLogBox.Name = "SearcherLogBox";
            this.SearcherLogBox.Size = new System.Drawing.Size(330, 20);
            this.SearcherLogBox.TabIndex = 26;
            // 
            // HouseSearcherBox
            // 
            this.HouseSearcherBox.Checked = false;
            this.HouseSearcherBox.Font = new System.Drawing.Font("Verdana", 8F);
            this.HouseSearcherBox.Location = new System.Drawing.Point(38, 181);
            this.HouseSearcherBox.Name = "HouseSearcherBox";
            this.HouseSearcherBox.Size = new System.Drawing.Size(166, 22);
            this.HouseSearcherBox.TabIndex = 25;
            this.HouseSearcherBox.Text = "Enable search";
            this.HouseSearcherBox.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.HouseSearcherBox_CheckedChanged);
            // 
            // sadikLabel8
            // 
            this.sadikLabel8.AutoSize = true;
            this.sadikLabel8.BackColor = System.Drawing.Color.Transparent;
            this.sadikLabel8.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel8.Location = new System.Drawing.Point(35, 106);
            this.sadikLabel8.Name = "sadikLabel8";
            this.sadikLabel8.Size = new System.Drawing.Size(181, 13);
            this.sadikLabel8.TabIndex = 24;
            this.sadikLabel8.Text = "Sentence to say after buying :";
            // 
            // sadikLabel7
            // 
            this.sadikLabel7.AutoSize = true;
            this.sadikLabel7.BackColor = System.Drawing.Color.Transparent;
            this.sadikLabel7.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel7.Location = new System.Drawing.Point(203, 75);
            this.sadikLabel7.Name = "sadikLabel7";
            this.sadikLabel7.Size = new System.Drawing.Size(103, 13);
            this.sadikLabel7.TabIndex = 23;
            this.sadikLabel7.Text = "Maximum price :";
            // 
            // StartWaitingBt
            // 
            this.StartWaitingBt.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.StartWaitingBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartWaitingBt.Font = new System.Drawing.Font("Verdana", 8F);
            this.StartWaitingBt.Image = null;
            this.StartWaitingBt.Location = new System.Drawing.Point(38, 149);
            this.StartWaitingBt.Name = "StartWaitingBt";
            this.StartWaitingBt.RoundedCorners = false;
            this.StartWaitingBt.Size = new System.Drawing.Size(390, 26);
            this.StartWaitingBt.TabIndex = 22;
            this.StartWaitingBt.Text = "Launch waiting for the sale";
            this.StartWaitingBt.Click += new System.EventHandler(this.StartWaitingBt_Click);
            // 
            // MaxPrice
            // 
            this.MaxPrice.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxPrice.Location = new System.Drawing.Point(308, 73);
            this.MaxPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(120, 20);
            this.MaxPrice.TabIndex = 21;
            this.MaxPrice.ThousandsSeparator = true;
            this.MaxPrice.ValueChanged += new System.EventHandler(this.MaxPrice_ValueChanged);
            // 
            // PhraseADire
            // 
            this.PhraseADire.Location = new System.Drawing.Point(38, 122);
            this.PhraseADire.Name = "PhraseADire";
            this.PhraseADire.Size = new System.Drawing.Size(390, 20);
            this.PhraseADire.TabIndex = 20;
            this.PhraseADire.TextChanged += new System.EventHandler(this.PhraseADire_TextChanged);
            // 
            // metroTabPage9
            // 
            this.metroTabPage9.Controls.Add(this.MapView);
            this.metroTabPage9.HorizontalScrollbarBarColor = true;
            this.metroTabPage9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage9.HorizontalScrollbarSize = 10;
            this.metroTabPage9.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage9.Name = "metroTabPage9";
            this.metroTabPage9.Size = new System.Drawing.Size(481, 344);
            this.metroTabPage9.TabIndex = 2;
            this.metroTabPage9.Text = "Map";
            this.metroTabPage9.VerticalScrollbarBarColor = true;
            this.metroTabPage9.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage9.VerticalScrollbarSize = 10;
            this.metroTabPage9.Click += new System.EventHandler(this.metroTabPage9_Click);
            // 
            // MapView
            // 
            this.MapView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.MapView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MapView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ContextName,
            this.CellId,
            this.Type});
            this.MapView.Location = new System.Drawing.Point(3, 15);
            this.MapView.Name = "MapView";
            this.MapView.Size = new System.Drawing.Size(461, 326);
            this.MapView.TabIndex = 2;
            this.MapView.UseCompatibleStateImageBehavior = false;
            this.MapView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 86;
            // 
            // ContextName
            // 
            this.ContextName.Text = "Name";
            this.ContextName.Width = 86;
            // 
            // CellId
            // 
            this.CellId.Text = "Cell ID";
            this.CellId.Width = 97;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 97;
            // 
            // StatsPage
            // 
            this.StatsPage.HorizontalScrollbarBarColor = true;
            this.StatsPage.HorizontalScrollbarHighlightOnWheel = false;
            this.StatsPage.HorizontalScrollbarSize = 10;
            this.StatsPage.Location = new System.Drawing.Point(4, 38);
            this.StatsPage.Name = "StatsPage";
            this.StatsPage.Size = new System.Drawing.Size(481, 344);
            this.StatsPage.TabIndex = 4;
            this.StatsPage.Text = "Characteristics";
            this.StatsPage.VerticalScrollbarBarColor = true;
            this.StatsPage.VerticalScrollbarHighlightOnWheel = false;
            this.StatsPage.VerticalScrollbarSize = 10;
            // 
            // tabPage8
            // 
            this.tabPage8.HorizontalScrollbarBarColor = true;
            this.tabPage8.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage8.HorizontalScrollbarSize = 10;
            this.tabPage8.Location = new System.Drawing.Point(4, 38);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(481, 344);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Heroic";
            this.tabPage8.VerticalScrollbarBarColor = true;
            this.tabPage8.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage8.VerticalScrollbarSize = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(481, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flood";
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // marchandPage
            // 
            this.marchandPage.Controls.Add(this.BtnActualize);
            this.marchandPage.Controls.Add(this.sadikButton3);
            this.marchandPage.Controls.Add(this.sadikLabel10);
            this.marchandPage.Controls.Add(this.numericUpDown1);
            this.marchandPage.Controls.Add(this.LVItemShop);
            this.marchandPage.Controls.Add(this.LVItemBag);
            this.marchandPage.Controls.Add(this.sadikCheckbox1);
            this.marchandPage.HorizontalScrollbarBarColor = true;
            this.marchandPage.HorizontalScrollbarHighlightOnWheel = false;
            this.marchandPage.HorizontalScrollbarSize = 10;
            this.marchandPage.Location = new System.Drawing.Point(4, 38);
            this.marchandPage.Name = "marchandPage";
            this.marchandPage.Size = new System.Drawing.Size(481, 344);
            this.marchandPage.TabIndex = 5;
            this.marchandPage.Text = "Merchant mode";
            this.marchandPage.VerticalScrollbarBarColor = true;
            this.marchandPage.VerticalScrollbarHighlightOnWheel = false;
            this.marchandPage.VerticalScrollbarSize = 10;
            // 
            // BtnActualize
            // 
            this.BtnActualize.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.BtnActualize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualize.Font = new System.Drawing.Font("Verdana", 8F);
            this.BtnActualize.Image = null;
            this.BtnActualize.Location = new System.Drawing.Point(216, 133);
            this.BtnActualize.Name = "BtnActualize";
            this.BtnActualize.RoundedCorners = false;
            this.BtnActualize.Size = new System.Drawing.Size(65, 20);
            this.BtnActualize.TabIndex = 13;
            this.BtnActualize.Text = "Actualize";
            this.BtnActualize.Click += new System.EventHandler(this.BtnActualize_Click);
            // 
            // sadikButton3
            // 
            this.sadikButton3.ButtonStyle = MageBot.Interface.SadikButton.Style.Blue;
            this.sadikButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sadikButton3.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikButton3.Image = null;
            this.sadikButton3.Location = new System.Drawing.Point(287, 133);
            this.sadikButton3.Name = "sadikButton3";
            this.sadikButton3.RoundedCorners = false;
            this.sadikButton3.Size = new System.Drawing.Size(65, 20);
            this.sadikButton3.TabIndex = 12;
            this.sadikButton3.Text = "Add";
            this.sadikButton3.Click += new System.EventHandler(this.sadikButton3_Click);
            // 
            // sadikLabel10
            // 
            this.sadikLabel10.AutoSize = true;
            this.sadikLabel10.BackColor = System.Drawing.Color.Transparent;
            this.sadikLabel10.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.sadikLabel10.Location = new System.Drawing.Point(358, 135);
            this.sadikLabel10.Name = "sadikLabel10";
            this.sadikLabel10.Size = new System.Drawing.Size(35, 13);
            this.sadikLabel10.TabIndex = 11;
            this.sadikLabel10.Text = "Price";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(393, 133);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // LVItemShop
            // 
            this.LVItemShop.BackColor = System.Drawing.Color.White;
            this.LVItemShop.FullRowSelect = true;
            this.LVItemShop.Location = new System.Drawing.Point(1, 159);
            this.LVItemShop.Name = "LVItemShop";
            this.LVItemShop.ShowItemToolTips = true;
            this.LVItemShop.Size = new System.Drawing.Size(477, 112);
            this.LVItemShop.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.LVItemShop.TabIndex = 9;
            this.LVItemShop.UseCompatibleStateImageBehavior = false;
            this.LVItemShop.View = System.Windows.Forms.View.Details;
            // 
            // LVItemBag
            // 
            this.LVItemBag.BackColor = System.Drawing.Color.White;
            this.LVItemBag.FullRowSelect = true;
            this.LVItemBag.Location = new System.Drawing.Point(1, 3);
            this.LVItemBag.Name = "LVItemBag";
            this.LVItemBag.ShowItemToolTips = true;
            this.LVItemBag.Size = new System.Drawing.Size(477, 124);
            this.LVItemBag.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.LVItemBag.TabIndex = 8;
            this.LVItemBag.UseCompatibleStateImageBehavior = false;
            this.LVItemBag.View = System.Windows.Forms.View.Details;
            // 
            // sadikCheckbox1
            // 
            this.sadikCheckbox1.Checked = false;
            this.sadikCheckbox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.sadikCheckbox1.Location = new System.Drawing.Point(311, 277);
            this.sadikCheckbox1.Name = "sadikCheckbox1";
            this.sadikCheckbox1.Size = new System.Drawing.Size(177, 20);
            this.sadikCheckbox1.TabIndex = 2;
            this.sadikCheckbox1.Text = "Enable merchant mode";
            this.sadikCheckbox1.CheckedChanged += new MageBot.Interface.SadikCheckbox.CheckedChangedEventHandler(this.sadikCheckbox1_CheckedChanged_1);
            // 
            // AccountUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.XpBar);
            this.Controls.Add(this.PodsBar);
            this.Controls.Add(this.VitaBar);
            this.Controls.Add(this.KamasLabel);
            this.Controls.Add(this.StatusLb);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.VTabAccount);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(613, 468);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.VTabAccount.ResumeLayout(false);
            this.ConsolePage.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.sadikGroupBox2.ResumeLayout(false);
            this.sadikGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDVerbose)).EndInit();
            this.sadikGroupBox1.ResumeLayout(false);
            this.FightPage.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTimeoutFight)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegenChoice)).EndInit();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresetEndUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresetStartUpD)).EndInit();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRestrictions)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMonstersLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMonstersLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMonstersNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinMonstersNumber)).EndInit();
            this.JobPage.ResumeLayout(false);
            this.FamiPage.ResumeLayout(false);
            this.panelAccountInformations.ResumeLayout(false);
            this.panelAccountInformations.PerformLayout();
            this.InventairePage.ResumeLayout(false);
            this.sadikTabControl2.ResumeLayout(false);
            this.metroTabPage6.ResumeLayout(false);
            this.DiversPage.ResumeLayout(false);
            this.MiscPage.ResumeLayout(false);
            this.MaisonsPage.ResumeLayout(false);
            this.MaisonsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).EndInit();
            this.metroTabPage9.ResumeLayout(false);
            this.marchandPage.ResumeLayout(false);
            this.marchandPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SadikLabel KamasLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripLabel PosLabel;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripMenuItem LoadPathBt;
        internal System.Windows.Forms.ToolStripMenuItem LaunchPathBt;
        internal System.Windows.Forms.ToolStripMenuItem StopPathBt;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private SadikVerticalTabControl VTabAccount;
        private System.Windows.Forms.TabPage ConsolePage;
        private System.Windows.Forms.TabPage FightPage;
        private System.Windows.Forms.TabPage FamiPage;
        private System.Windows.Forms.Panel panelAccountInformations;
        private System.Windows.Forms.ListView listViewPets;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        public SadikLabel StatusLb;
        public System.Windows.Forms.ToolStripDropDownButton PathDownBt;
        private System.Windows.Forms.TabPage DiversPage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage InventairePage;
        private System.Windows.Forms.ImageList imageList1;
        private SadikLabel labelSafe;
        private SadikLabel labelNextMeal;
        public SadikCheckbox checkBoxBegin;
        private System.Windows.Forms.TabPage JobPage;
        private SadikTabControl JobsTabP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LevelLb;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel SubcribeLb;
        public System.Windows.Forms.ToolStripMenuItem RelaunchPath;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        internal System.Windows.Forms.TextBox CommandeBox;
        private System.Windows.Forms.RichTextBox LogConsole;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroProgressBar VitaBar;
        private SadikGroupBox sadikGroupBox2;
        private SadikLabel sadikLabel13;
        private System.Windows.Forms.NumericUpDown NUDVerbose;
        private SadikGroupBox sadikGroupBox1;
        private SadikButton DeleteConfigBt;
        private SadikButton SaveConfig;
        private SadikCheckbox LogCb;
        public SadikCheckbox DebugMode;
        private MetroFramework.Controls.MetroProgressBar PodsBar;
        private MetroFramework.Controls.MetroProgressBar XpBar;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.NumericUpDown NUDTimeoutFight;
        private SadikLabel sadikLabel11;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private SadikButton ChoiceIABt;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private SadikLabel sadikLabel2;
        private SadikLabel sadikLabel1;
        internal System.Windows.Forms.NumericUpDown RegenChoice;
        internal System.Windows.Forms.GroupBox GroupBox4;
        public SadikCheckbox WithItemSetBox;
        private SadikLabel sadikLabel4;
        private SadikLabel sadikLabel3;
        public System.Windows.Forms.NumericUpDown PresetEndUpD;
        public System.Windows.Forms.NumericUpDown PresetStartUpD;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.ListBox lstPopup;
        private SadikButton ForceMonstersBt;
        private SadikButton ForbidMonsterBt;
        private System.Windows.Forms.ListView MonstersRestrictionsView;
        private System.Windows.Forms.NumericUpDown NUDRestrictions;
        private SadikCombo ComparateurBox;
        private System.Windows.Forms.TextBox MonsterTextBox;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private SadikLabel sadikLabel6;
        private SadikLabel sadikLabel5;
        internal System.Windows.Forms.Label lbReplaceMonstersLevel;
        internal System.Windows.Forms.NumericUpDown nudMaxMonstersLevel;
        internal System.Windows.Forms.NumericUpDown nudMinMonstersLevel;
        private System.Windows.Forms.Label lbReplaceMonstersNumber;
        internal System.Windows.Forms.NumericUpDown nudMaxMonstersNumber;
        internal System.Windows.Forms.NumericUpDown nudMinMonstersNumber;
        private MetroFramework.Controls.MetroTabControl sadikTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private SadikButton RegenAddBt;
        private SadikButton AutoDelAddBt;
        private SadikButton sadikButton2;
        private SadikButton sadikButton1;
        private SadikButton DropItems;
        private SadikButton DeleteItem;
        public System.Windows.Forms.ListView LVItems;
        private MetroFramework.Controls.MetroTabPage tabPage9;
        private MetroFramework.Controls.MetroTabPage RegenPage;
        private MetroFramework.Controls.MetroTabControl MiscPage;
        private MetroFramework.Controls.MetroTabPage MaisonsPage;
        private SadikLabel sadikLabel9;
        private SadikButton ParcourirBt;
        public System.Windows.Forms.TextBox SearcherLogBox;
        private SadikCheckbox HouseSearcherBox;
        private SadikLabel sadikLabel8;
        private SadikLabel sadikLabel7;
        private SadikButton StartWaitingBt;
        internal System.Windows.Forms.NumericUpDown MaxPrice;
        internal System.Windows.Forms.TextBox PhraseADire;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage9;
        private System.Windows.Forms.ListView MapView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader ContextName;
        private System.Windows.Forms.ColumnHeader CellId;
        private System.Windows.Forms.ColumnHeader Type;
        private MetroFramework.Controls.MetroTabPage tabPage8;
        private MetroFramework.Controls.MetroTabPage StatsPage;
        public MetroFramework.Controls.MetroLabel NomIA;
        private MetroFramework.Controls.MetroTabPage marchandPage;
        private SadikCheckbox sadikCheckbox1;
        private SadikButton sadikButton3;
        private SadikLabel sadikLabel10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.ListView LVItemShop;
        public System.Windows.Forms.ListView LVItemBag;
        private System.Windows.Forms.Timer PlaceTimer;
        private SadikButton BtnActualize;
        public SadikCheckbox IsLockingFight;
        public SadikCheckbox LockSpectator;
        public SadikCheckbox AskForHelp;
        public SadikCheckbox LockForParty;
        public SadikCheckbox sadikCheckbox2;
    }
}
