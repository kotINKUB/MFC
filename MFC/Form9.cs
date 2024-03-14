using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MFC
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.Show();
            Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "мФЦDataSet.Заявки". При необходимости она может быть перемещена или удалена.
            this.заявкиTableAdapter.Fill(this.мФЦDataSet.Заявки);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            заявкиTableAdapter.Update(мФЦDataSet.Заявки);
            заявкиTableAdapter.Fill(мФЦDataSet.Заявки);
            MessageBox.Show("Изменения добавлены");
        }
    }
}
