using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_1
{
    public partial class UserStore : Form
    {
        private static Dictionary<string, string> users = new Dictionary<string, string>();

        public static void AddUser(string username, string password)
        {
            if (!users.ContainsKey(username))
            {
                users.Add(username, password);
            }
        }

        public static bool IsValidUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username] == password;
        }
    }
}
