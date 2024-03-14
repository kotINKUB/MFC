using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-J6P2O8B7;Initial Catalog=МФЦ;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string avtorization = $"SELECT Роль from Роли Where Логин='" + textBox2.Text + "' and Пароль='" + textBox1.Text + "'";
                    SqlCommand commandAvtorization = new SqlCommand(avtorization, connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = commandAvtorization;
                    object resultAvtorization = commandAvtorization.ExecuteScalar();
                    Users.UserPassword = textBox2.Text;
                    if (resultAvtorization != null)
                    {
                        string roleUser = resultAvtorization.ToString();
                        switch (roleUser)
                        {
                            case "Клиент":
                                Form3 fr3 = new Form3();
                                fr3.Show();
                                Hide();
                                break;
                            case "Менеджер":
                                Form4 fr4 = new Form4();
                                fr4.Show();
                                Hide();
                                break;
                            case "Администратор":
                                Form5 fr5 = new Form5();
                                fr5.Show();
                                Hide();
                                break;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Веденные логин и пароль не числятся в базе данных!");
                    }

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
