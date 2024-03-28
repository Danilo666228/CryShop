using CryShop.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryShop.Windows.Registration
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void btnRegistration_Click(object sender, EventArgs e)
        {
            User user = new User();
            Validate validate = new Validate();
            if (validate.RegistrationUser(txbLastName.Text, txbFirstName.Text, txbMiddleName.Text, txbLogin.Text, txbPassword.Text, txbRepeatPassword.Text))
            {
                if (await Task.Run(() => user.Add(txbLastName.Text, txbFirstName.Text, txbMiddleName.Text, txbLogin.Text, txbPassword.Text)))
                {
                    this.Hide();
                    Authorized authorized = new Authorized();
                    authorized.Show();
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorized authorized = new Authorized();
            authorized.Show();
        }
    }
}
