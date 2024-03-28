using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryShop.Data
{
    public class User
    {
        public int Id { get; set; }
        public byte[] Photo { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public decimal Balance { get; set; } = 0;


        public async Task<bool> Add(string lastname, string firstname, string middlename, string login, string password)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User ExistUser = await db.Users
                    .FirstOrDefaultAsync(t => t.Login == login);
                if (ExistUser != null)
                {
                    MessageBox.Show("Этот логин уже занят\nВыберите другой", "Регистрация", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                db.Users
                    .Add(new User
                    {
                        LastName = lastname,
                        FirstName = firstname,
                        MiddleName = middlename,
                        Login = login,
                        Password = password
                    });
                await db.SaveChangesAsync();
                return true;
            }
        }
        public async Task<int> GetId(string login, string password)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await db.Users
                    .FirstOrDefaultAsync(t => t.Login == login && t.Password == password);
                if (user != null)
                {
                    return user.Id;
                }
                else
                {
                    return 0;
                }
            }
        }
        public async Task<(string lastname, decimal? balance)> FillMiniProfile(int userId)
        {
            using (ConnectDb db = new ConnectDb())
            {
                User user = await db.Users
                    .FirstOrDefaultAsync(t=> t.Id == userId);
                if (user != null)
                {
                    return (user.LastName, user.Balance);
                }
                return (null, null);
            }
        }
    }
}
