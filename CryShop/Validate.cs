using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryShop
{
    public class Validate
    {
        public bool RegistrationUser(string lastname,string firstname,string middlename,string login,string password,string repeatpassword)
        {
            if(string.IsNullOrWhiteSpace(lastname)
                || string.IsNullOrWhiteSpace(firstname)
                || string.IsNullOrWhiteSpace(middlename)
                || string.IsNullOrWhiteSpace(login)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }
            if(password != repeatpassword)
            {
                MessageBox.Show("Пароли должны совпадать");
                return false;
            }
            return true;
        }
        public bool LoginUser(string login,string password)
        {
            if(string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Заполните все поля");
                return false;
            }
            return true;
        }
    }
}
