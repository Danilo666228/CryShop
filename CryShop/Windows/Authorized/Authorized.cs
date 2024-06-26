﻿using CryShop.Data;
using CryShop.Windows.Main;
using CryShop.Windows.Registration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryShop
{
    public partial class Authorized : Form
    {
        public Authorized()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            Validate validate = new Validate();
            int UserId = await Task.Run(() => user.GetId(txbLogin.Text, txbPassword.Text));
            if (validate.LoginUser(txbLogin.Text, txbPassword.Text))
            {
                if (UserId != 0)
                {
                    this.Hide();
                    MessageBox.Show("Вы успешно вошли");
                    Main mainForm = new Main();
                    mainForm.UserId = UserId;
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Логин или пароль не верный");
                }
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
