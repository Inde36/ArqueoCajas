namespace Arqueo_de_cajas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgdatos = new DataGridView();
            fechac = new DataGridViewTextBoxColumn();
            importec = new DataGridViewTextBoxColumn();
            kashc = new DataGridViewTextBoxColumn();
            diferenciac = new DataGridViewTextBoxColumn();
            label1 = new Label();
            cboxestacion = new ComboBox();
            dpfecha = new DateTimePicker();
            label2 = new Label();
            btncargar = new Button();
            lblkash = new Label();
            txtbkash = new TextBox();
            btnguardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgdatos).BeginInit();
            SuspendLayout();
            // 
            // dgdatos
            // 
            dgdatos.AllowUserToAddRows = false;
            dgdatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdatos.Columns.AddRange(new DataGridViewColumn[] { fechac, importec, kashc, diferenciac });
            dgdatos.Location = new Point(12, 130);
            dgdatos.Name = "dgdatos";
            dgdatos.ReadOnly = true;
            dgdatos.RowTemplate.Height = 25;
            dgdatos.Size = new Size(444, 427);
            dgdatos.TabIndex = 0;
            // 
            // fechac
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            fechac.DefaultCellStyle = dataGridViewCellStyle1;
            fechac.HeaderText = "Fecha";
            fechac.Name = "fechac";
            fechac.ReadOnly = true;
            // 
            // importec
            // 
            importec.HeaderText = "Importe";
            importec.Name = "importec";
            importec.ReadOnly = true;
            // 
            // kashc
            // 
            kashc.HeaderText = "Kash";
            kashc.Name = "kashc";
            kashc.ReadOnly = true;
            // 
            // diferenciac
            // 
            diferenciac.HeaderText = "Diferencia";
            diferenciac.Name = "diferenciac";
            diferenciac.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Estacion:";
            // 
            // cboxestacion
            // 
            cboxestacion.FormattingEnabled = true;
            cboxestacion.Location = new Point(72, 20);
            cboxestacion.Name = "cboxestacion";
            cboxestacion.Size = new Size(121, 23);
            cboxestacion.TabIndex = 2;
            // 
            // dpfecha
            // 
            dpfecha.Format = DateTimePickerFormat.Short;
            dpfecha.Location = new Point(72, 59);
            dpfecha.Name = "dpfecha";
            dpfecha.Size = new Size(121, 23);
            dpfecha.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Fecha";
            // 
            // btncargar
            // 
            btncargar.Location = new Point(290, 61);
            btncargar.Name = "btncargar";
            btncargar.Size = new Size(75, 23);
            btncargar.TabIndex = 5;
            btncargar.Text = "Cargar";
            btncargar.UseVisualStyleBackColor = true;
            btncargar.Click += btncargar_Click;
            // 
            // lblkash
            // 
            lblkash.AutoSize = true;
            lblkash.Location = new Point(252, 23);
            lblkash.Name = "lblkash";
            lblkash.Size = new Size(32, 15);
            lblkash.TabIndex = 6;
            lblkash.Text = "Kash";
            lblkash.Visible = false;
            // 
            // txtbkash
            // 
            txtbkash.Location = new Point(290, 20);
            txtbkash.Name = "txtbkash";
            txtbkash.Size = new Size(100, 23);
            txtbkash.TabIndex = 7;
            txtbkash.Visible = false;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(381, 570);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 8;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 605);
            Controls.Add(btnguardar);
            Controls.Add(txtbkash);
            Controls.Add(lblkash);
            Controls.Add(btncargar);
            Controls.Add(label2);
            Controls.Add(dpfecha);
            Controls.Add(cboxestacion);
            Controls.Add(label1);
            Controls.Add(dgdatos);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgdatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button btncargar;
        private Label lblkash;
        private Button btnguardar;
        public ComboBox cboxestacion;
        public DataGridView dgdatos;
        private DataGridViewTextBoxColumn fechac;
        private DataGridViewTextBoxColumn importec;
        private DataGridViewTextBoxColumn kashc;
        private DataGridViewTextBoxColumn diferenciac;
        public DateTimePicker dpfecha;
        public TextBox txtbkash;
    }
}