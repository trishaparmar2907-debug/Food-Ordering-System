namespace foodorderingsystem
{
    partial class cart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.CadetBlue;
            dataGridView1.Location = new Point(29, 115);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 700);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.CadetBlue;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button3.Location = new Point(358, 193);
            button3.Name = "button3";
            button3.Size = new Size(157, 50);
            button3.TabIndex = 3;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(565, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 34);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(358, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 34);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.Location = new Point(1626, 622);
            button1.Name = "button1";
            button1.Size = new Size(205, 54);
            button1.TabIndex = 6;
            button1.Text = "Clear Items";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.Location = new Point(1006, 622);
            button2.Name = "button2";
            button2.Size = new Size(170, 56);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button4.Location = new Point(1312, 624);
            button4.Name = "button4";
            button4.Size = new Size(192, 54);
            button4.TabIndex = 8;
            button4.Text = "Pay Now";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1006, 493);
            label1.Name = "label1";
            label1.Size = new Size(217, 38);
            label1.TabIndex = 9;
            label1.Text = "Grand Total : ₹ ";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(1296, 493);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 38);
            textBox3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 34);
            label2.Name = "label2";
            label2.Size = new Size(532, 38);
            label2.TabIndex = 11;
            label2.Text = "Enter Item Name You Want To Update :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 100);
            label3.Name = "label3";
            label3.Size = new Size(292, 38);
            label3.TabIndex = 12;
            label3.Text = "Enter New Quantity :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(button3);
            panel1.ForeColor = SystemColors.Desktop;
            panel1.Location = new Point(1006, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 265);
            panel1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSlateGray;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(908, 9);
            label4.Name = "label4";
            label4.Size = new Size(189, 46);
            label4.TabIndex = 14;
            label4.Text = "Order Cart";
            // 
            // cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            BackgroundImage = Properties.Resources.Descargar_fondo_de_patrón_de_estilo_de_vida_de_comida_saludable_gratis5;
            ClientSize = new Size(1874, 862);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "cart";
            Text = "cart";
            Load += cart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
    }
}