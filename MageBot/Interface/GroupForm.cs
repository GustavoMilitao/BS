﻿using MageBot.Core.Account;
using MageBot.Core.Groups;
using MageBot.Protocol.Messages.Game.Context.Roleplay.Party;
using Util.Util.Text.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Util.Util.I18n.Strings;

namespace MageBot.Interface
{
    public partial class GroupForm : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Container for multiple accountUC.
        /// </summary>

        #region Fields
        public List<AccountUC> listAccounts;
        #endregion

        private delegate void Callback(AccountUC account);

        #region Constructors
        public GroupForm(List<Account> accounts, string name)
        {
            InitializeComponent();
            accounts.ForEach(i => i.Config.IsSocket = true);
            listAccounts = new List<AccountUC>();
            var group = new Group(accounts, Name);
            foreach (Account account in accounts)
            {
                TabPage tab = new TabPage(account.AccountName);
                AccountTabs.TabPages.Add(tab);
                account.MyGroup = group;
                AccountUC naccount = new AccountUC(account, this);
                listAccounts.Add(naccount);
                tab.Controls.Add(naccount);
                MasterChoice.Items.Add(account.AccountName);
                naccount.Dock = DockStyle.Fill;
                naccount.Show();
            }
            Text = name;
        }

        #endregion

        #region Public Methods
        public void AddMember(string name)
        {
            MasterChoice1.Items.Add(name);
        }
        #endregion

        #region events
        public void MasterChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = (string)MasterChoice.SelectedItem;
            AccountUC master = listAccounts.Where(i => i.Account.AccountName == item).FirstOrDefault();
            master.Account.IsMaster = true;
            master.Account.Log(new BotTextInformation("This is the Master account now !"), 1);
            master.Focus();
            foreach(AccountUC ac in listAccounts)
            {
                if(ac.Account.AccountName != master.Account.AccountName)
                {
                    ac.Account.IsMaster = false;
                    Invite(ac.Account.CharacterBaseInformations.Name, master.Account);
                }
            }
        }
        #endregion

        #region Dofus group methods
        private void Invite(string name, Account account)
        {
            PartyInvitationRequestMessage msg = new PartyInvitationRequestMessage(name);
            account.SocketManager.Send(msg);
        }

        private void QuitGroup(int partyid, Account account)
        {
            PartyLeaveRequestMessage msg = new PartyLeaveRequestMessage((uint)partyid);
            account.SocketManager.Send(msg);
        }
        #endregion
    }
}