namespace foodorderingsystem
{
    partial class onlinepayment
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkCyan;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 229);
            label1.Name = "label1";
            label1.Size = new Size(179, 40);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 304);
            label2.Name = "label2";
            label2.Size = new Size(215, 40);
            label2.TabIndex = 1;
            label2.Text = "Total Amount :";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CadetBlue;
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(341, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(911, 561);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bank Details :";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(347, 464);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(433, 43);
            textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(347, 359);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(433, 43);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(347, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 43);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(347, 124);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(433, 43);
            textBox1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 467);
            label6.Name = "label6";
            label6.Size = new Size(164, 38);
            label6.TabIndex = 3;
            label6.Text = "IFSC Code :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 359);
            label5.Name = "label5";
            label5.Size = new Size(257, 38);
            label5.TabIndex = 2;
            label5.Text = "Account Number :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 247);
            label4.Name = "label4";
            label4.Size = new Size(227, 38);
            label4.TabIndex = 1;
            label4.Text = "Account Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 124);
            label3.Name = "label3";
            label3.Size = new Size(185, 38);
            label3.TabIndex = 0;
            label3.Text = "Bank Name :";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.Location = new Point(1484, 491);
            button1.Name = "button1";
            button1.Size = new Size(194, 82);
            button1.TabIndex = 3;
            button1.Text = "Pay Now";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.Location = new Point(1484, 229);
            button2.Name = "button2";
            button2.Size = new Size(184, 76);
            button2.TabIndex = 4;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button3.Location = new Point(1484, 353);
            button3.Name = "button3";
            button3.Size = new Size(184, 71);
            button3.TabIndex = 5;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkSlateGray;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(585, 26);
            label7.Name = "label7";
            label7.Size = new Size(583, 54);
            label7.TabIndex = 6;
            label7.Text = "Complete Your Food Payment";
            // 
            // onlinepayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Descargar_fondo_de_patrón_de_estilo_de_vida_de_comida_saludable_gratis7;
            ClientSize = new Size(1872, 847);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "onlinepayment";
            Text = "onlinepayment";
            Load += onlinepayment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
    }
}