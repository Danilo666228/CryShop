﻿using CryShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryShop.Windows.Main
{
    public partial class Main : Form
    {
        public int UserId {  get; set; }
        public Main()
        {
            InitializeComponent();
        }
        public async void FillMiniPrifile()
        {
            User user = new User(); 
            var result = await user.FillMiniProfile(UserId);
            lblNameUser.Text = result.lastname;
            lblBalanceUser.Text = result.balance.ToString();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            FillMiniPrifile();
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorized authorized = new Authorized();
            authorized.Show();
        }
    }
}
