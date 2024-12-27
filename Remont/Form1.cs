using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Remont
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=repair;Username=postgres;Password=alina";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtUsername.Text;
            string password = txtPassword.Text;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT role FROM users WHERE login = @login AND password = @password";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("login", login);
                    command.Parameters.AddWithValue("password", password);

                    var role = command.ExecuteScalar(); // �������� ���� ������������

                    if (role != null)
                    {
                        string userRole = role.ToString();
                        MessageBox.Show($"����� ����������, {login}! ���� ����: {userRole}.");

                        // ��������� ������� ����� �� ������ ����
                        if (userRole == "�������������")
                        {
                            var adminForm = new AdminForm();
                            adminForm.Show();
                        }
                        else if (userRole == "���������")
                        {
                            var employeeForm = new EmployeeForm();
                            employeeForm.Show();
                        }

                        this.Hide(); // �������� ������� �����
                    }
                    else
                    {
                        MessageBox.Show("�������� ����� ��� ������.");
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
