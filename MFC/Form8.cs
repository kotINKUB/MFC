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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fr5 = new Form5();
            fr5.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=LAPTOP-J6P2O8B7;Initial Catalog=МФЦ;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string avtorization = $"Insert Into Сотрудники (ФИО, Должность) values (@ФИО, @Должность)";
                    SqlCommand command = new SqlCommand(avtorization, connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = command;
                    command.Parameters.AddWithValue("@ФИО", textBox1.Text);
                    command.Parameters.AddWithValue("@Должность", textBox2.Text);


                    sqlDataAdapter.SelectCommand = command;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Сотрудник добавлен");
                        connection.Close();
                        this.Close();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
