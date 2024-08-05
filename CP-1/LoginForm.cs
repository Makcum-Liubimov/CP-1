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
    public partial class LoginForm : Form
    {
        public static string UserType { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextBox.Text) || string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.");
                return;
            }

            if (UserStore.IsValidUser(usernameTextBox.Text, passwordTextBox.Text))
            {
                UserType = userTypeComboBox.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильне ім'я користувача або пароль.");
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Показуємо форму реєстрації
            RegistrationForm registrationForm = new RegistrationForm();
            if (registrationForm.ShowDialog() == DialogResult.OK)
            {
                usernameTextBox.Text = registrationForm.Username;
                passwordTextBox.Text = registrationForm.Password;
            }
        }
    }
}
