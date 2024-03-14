namespace MFC
{
    partial class Form7
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.мФЦDataSet = new MFC.МФЦDataSet();
            this.заявкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заявкиTableAdapter = new MFC.МФЦDataSetTableAdapters.ЗаявкиTableAdapter();
            this.iDЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оформленныйдокументDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОЗаказчикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОформленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗавершенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.мФЦDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 116);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(156, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Просмотр заявлений";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MFC.Properties.Resources._8ietf70zt5jltMoYIkCKj6g6PL8R2OuU6wY57EAhveLlZ6CQBySrgd_XbrgvZUHT3EJeR8iA;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SaddleBrown;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(830, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаявкиDataGridViewTextBoxColumn,
            this.оформленныйдокументDataGridViewTextBoxColumn,
            this.фИОЗаказчикаDataGridViewTextBoxColumn,
            this.датаОформленияDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.датаЗавершенияDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.iDСотрудникаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заявкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 282);
            this.dataGridView1.TabIndex = 2;
            // 
            // мФЦDataSet
            // 
            this.мФЦDataSet.DataSetName = "МФЦDataSet";
            this.мФЦDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заявкиBindingSource
            // 
            this.заявкиBindingSource.DataMember = "Заявки";
            this.заявкиBindingSource.DataSource = this.мФЦDataSet;
            // 
            // заявкиTableAdapter
            // 
            this.заявкиTableAdapter.ClearBeforeFill = true;
            // 
            // iDЗаявкиDataGridViewTextBoxColumn
            // 
            this.iDЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "ID_Заявки";
            this.iDЗаявкиDataGridViewTextBoxColumn.HeaderText = "ID_Заявки";
            this.iDЗаявкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЗаявкиDataGridViewTextBoxColumn.Name = "iDЗаявкиDataGridViewTextBoxColumn";
            this.iDЗаявкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // оформленныйдокументDataGridViewTextBoxColumn
            // 
            this.оформленныйдокументDataGridViewTextBoxColumn.DataPropertyName = "Оформленный_документ";
            this.оформленныйдокументDataGridViewTextBoxColumn.HeaderText = "Оформленный_документ";
            this.оформленныйдокументDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.оформленныйдокументDataGridViewTextBoxColumn.Name = "оформленныйдокументDataGridViewTextBoxColumn";
            this.оформленныйдокументDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОЗаказчикаDataGridViewTextBoxColumn
            // 
            this.фИОЗаказчикаDataGridViewTextBoxColumn.DataPropertyName = "ФИО_Заказчика";
            this.фИОЗаказчикаDataGridViewTextBoxColumn.HeaderText = "ФИО_Заказчика";
            this.фИОЗаказчикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОЗаказчикаDataGridViewTextBoxColumn.Name = "фИОЗаказчикаDataGridViewTextBoxColumn";
            this.фИОЗаказчикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаОформленияDataGridViewTextBoxColumn
            // 
            this.датаОформленияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Оформления";
            this.датаОформленияDataGridViewTextBoxColumn.HeaderText = "Дата_Оформления";
            this.датаОформленияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаОформленияDataGridViewTextBoxColumn.Name = "датаОформленияDataGridViewTextBoxColumn";
            this.датаОформленияDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаЗавершенияDataGridViewTextBoxColumn
            // 
            this.датаЗавершенияDataGridViewTextBoxColumn.DataPropertyName = "Дата_Завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.HeaderText = "Дата_Завершения";
            this.датаЗавершенияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаЗавершенияDataGridViewTextBoxColumn.Name = "датаЗавершенияDataGridViewTextBoxColumn";
            this.датаЗавершенияDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID_Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID_Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "ID_Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(987, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.мФЦDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заявкиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private МФЦDataSet мФЦDataSet;
        private System.Windows.Forms.BindingSource заявкиBindingSource;
        private МФЦDataSetTableAdapters.ЗаявкиTableAdapter заявкиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оформленныйдокументDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОЗаказчикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОформленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗавершенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
    }
}

