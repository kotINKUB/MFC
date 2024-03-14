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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MFC
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.Show();
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
                    string avtorization = $"Insert Into Заявки (Оформленный_документ, ФИО_Заказчика, Дата_Оформления) values (@Оформленный_документ, @ФИО_Заказчика, @Дата_Оформления)";
                    SqlCommand command = new SqlCommand(avtorization, connection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = command;
                    command.Parameters.AddWithValue("@Оформленный_документ", textBox1.Text);
                    command.Parameters.AddWithValue("@ФИО_Заказчика", textBox2.Text);
                    command.Parameters.AddWithValue("@Дата_Оформления", dateTimePicker1.Text);


                    sqlDataAdapter.SelectCommand = command;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Заявка оформлена");
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
