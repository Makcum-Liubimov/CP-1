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
    public partial class RegistrationForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            // Логіка збереження користувацьких даних (наприклад, у файл або базу даних)
            Username = usernameTextBox.Text;
            Password = passwordTextBox.Text;

            // Припускаємо, що ви додаєте користувача до списку користувачів
            UserStore.AddUser(Username, Password);

            MessageBox.Show("Реєстрація успішна.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
