namespace foodorderingsystem
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(622, 148);
            label1.Name = "label1";
            label1.Size = new Size(165, 41);
            label1.TabIndex = 12;
            label1.Text = "About Us :";
            // 
            // label2
            // 
            label2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(622, 214);
            label2.Name = "label2";
            label2.Size = new Size(932, 241);
            label2.TabIndex = 13;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CadetBlue;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(31, 500);
            label3.Name = "label3";
            label3.Size = new Size(186, 41);
            label3.TabIndex = 14;
            label3.Text = "Contact Us :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 565);
            label4.Name = "label4";
            label4.Size = new Size(455, 165);
            label4.TabIndex = 15;
            label4.Text = "-> Email: @foodorderingsystem.com\r\n\r\n-> Phone: +91 1234567890\r\n\r\n-> Address: XYZ College / Institute, India";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.CadetBlue;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(622, 500);
            label5.Name = "label5";
            label5.Size = new Size(336, 46);
            label5.TabIndex = 16;
            label5.Text = "Order Food Online :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(541, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(622, 582);
            button1.Name = "button1";
            button1.Size = new Size(326, 74);
            button1.TabIndex = 18;
            button1.Text = "View Food Menu";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1409, 694);
            button2.Name = "button2";
            button2.Size = new Size(135, 54);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkSlateGray;
            label6.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Transparent;
            label6.Location = new Point(345, 21);
            label6.Name = "label6";
            label6.Size = new Size(868, 62);
            label6.TabIndex = 20;
            label6.Text = "Welcom To TR² Food Ordering System";
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Descargar_fondo_de_patrón_de_estilo_de_vida_de_comida_saludable_gratis1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1556, 757);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "home";
            Text = "home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        // private Button back;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label6;
        // private Button menu;
    }
}