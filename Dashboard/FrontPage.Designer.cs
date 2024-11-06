namespace Dashboard
{
    partial class FrontPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            btnaddnew = new Button();
            lblinforeg = new Label();
            btnviewall = new Button();
            exitappbtn = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).BeginInit();
            SuspendLayout();
            // 
            // btnaddnew
            // 
            btnaddnew.BackColor = Color.Sienna;
            btnaddnew.FlatAppearance.BorderSize = 0;
            btnaddnew.FlatStyle = FlatStyle.Flat;
            btnaddnew.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            btnaddnew.ForeColor = Color.White;
            btnaddnew.Location = new Point(247, 240);
            btnaddnew.Name = "btnaddnew";
            btnaddnew.Size = new Size(138, 35);
            btnaddnew.TabIndex = 1;
            btnaddnew.Text = "Add New";
            btnaddnew.UseVisualStyleBackColor = false;
            btnaddnew.Click += btnaddnew_Click;
            // 
            // lblinforeg
            // 
            lblinforeg.AutoSize = true;
            lblinforeg.BackColor = Color.Transparent;
            lblinforeg.Font = new Font("Sitka Heading", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblinforeg.ForeColor = Color.Sienna;
            lblinforeg.Location = new Point(170, 97);
            lblinforeg.Name = "lblinforeg";
            lblinforeg.Size = new Size(285, 78);
            lblinforeg.TabIndex = 0;
            lblinforeg.Text = "INFORMATION\r\nREGISTRATION FORM";
            lblinforeg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnviewall
            // 
            btnviewall.BackColor = Color.Sienna;
            btnviewall.FlatAppearance.BorderSize = 0;
            btnviewall.FlatStyle = FlatStyle.Flat;
            btnviewall.Font = new Font("Sitka Banner", 12F, FontStyle.Bold);
            btnviewall.ForeColor = Color.White;
            btnviewall.Location = new Point(247, 291);
            btnviewall.Name = "btnviewall";
            btnviewall.Size = new Size(138, 35);
            btnviewall.TabIndex = 2;
            btnviewall.Text = "View All";
            btnviewall.UseVisualStyleBackColor = false;
            btnviewall.Click += btnviewall_Click;
            // 
            // exitappbtn
            // 
            exitappbtn.BackColor = Color.Transparent;
            exitappbtn.Image = (Image)resources.GetObject("exitappbtn.Image");
            exitappbtn.Location = new Point(596, 12);
            exitappbtn.Name = "exitappbtn";
            exitappbtn.Size = new Size(31, 23);
            exitappbtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitappbtn.TabIndex = 3;
            exitappbtn.TabStop = false;
            exitappbtn.Click += exitappbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(121, 73, 51);
            panel1.Location = new Point(243, 240);
            panel1.Name = "panel1";
            panel1.Size = new Size(142, 40);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(121, 73, 51);
            panel2.Location = new Point(243, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(142, 40);
            panel2.TabIndex = 5;
            // 
            // FrontPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(639, 427);
            Controls.Add(exitappbtn);
            Controls.Add(btnviewall);
            Controls.Add(lblinforeg);
            Controls.Add(btnaddnew);
            Controls.Add(panel1);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrontPage";
            Text = "FrontPage";
            ((System.ComponentModel.ISupportInitialize)exitappbtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnaddnew;
        private Label lblinforeg;
        private Button btnviewall;
        private PictureBox exitappbtn;
        private Panel panel1;
        private Panel panel2;
    }
}
