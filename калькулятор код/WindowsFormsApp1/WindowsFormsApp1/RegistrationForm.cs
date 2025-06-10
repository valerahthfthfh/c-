using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        private const string UsersFilePath = "users.txt";

        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            Form1 calculatorForm = new Form1(username);
            calculatorForm.FormClosed += (s, args) => this.Close();

            this.Hide();
            calculatorForm.Show();

            RegistrationForm login = new RegistrationForm();
            login.FormClosed += (s, args) => this.Close();
            // Закрываем форму регистрации и открываем калькулятор
            this.Visible = false;
        }
    }
}