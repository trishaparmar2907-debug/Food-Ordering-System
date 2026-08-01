namespace foodorderingsystem
{
    partial class thankyou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(thankyou));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Segoe UI Black", 28.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 194);
            label1.Name = "label1";
            label1.Size = new Size(906, 62);
            label1.TabIndex = 0;
            label1.Text = "🎉 THANK YOU FOR YOUR ORDER! 🎉";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(366, 295);
            label2.Name = "label2";
            label2.Size = new Size(756, 100);
            label2.TabIndex = 1;
            label2.Text = "Your order has been placed successfully.\r\nWe hope you enjoyed our service!";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button1.Location = new Point(836, 438);
            button1.Name = "button1";
            button1.Size = new Size(174, 64);
            button1.TabIndex = 2;
            button1.Text = "FINISH";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.Location = new Point(482, 438);
            button2.Name = "button2";
            button2.Size = new Size(168, 64);
            button2.TabIndex = 3;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // thankyou
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1537, 831);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "thankyou";
            Text = "thankyou";
            Load += thankyou_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}