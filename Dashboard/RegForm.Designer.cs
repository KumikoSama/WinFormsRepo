namespace Dashboard
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            panel1 = new Panel();
            rdbtnfem = new RadioButton();
            rdbtnmale = new RadioButton();
            lblnewinfo = new Label();
            label1 = new Label();
            btndone = new Button();
            lblage = new Label();
            lbllname = new Label();
            lblfname = new Label();
            txtbxage = new TextBox();
            txtbxlname = new TextBox();
            txtbxfname = new TextBox();
            btngoback = new PictureBox();
            exitappbtn = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btngoback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(rdbtnfem);
            panel1.Controls.Add(rdbtnmale);
            panel1.Controls.Add(lblnewinfo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btndone);
            panel1.Controls.Add(lblage);
            panel1.Controls.Add(lbllname);
            panel1.Controls.Add(lblfname);
            panel1.Controls.Add(txtbxage);
            panel1.Controls.Add(txtbxlname);
            panel1.Controls.Add(txtbxfname);
            panel1.Location = new Point(113, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 364);
            panel1.TabIndex = 0;
            // 
            // rdbtnfem
            // 
            rdbtnfem.AutoSize = true;
            rdbtnfem.FlatAppearance.BorderSize = 0;
            rdbtnfem.FlatStyle = FlatStyle.Flat;
            rdbtnfem.Location = new Point(199, 236);
            rdbtnfem.Name = "rdbtnfem";
            rdbtnfem.Size = new Size(62, 19);
            rdbtnfem.TabIndex = 10;
            rdbtnfem.TabStop = true;
            rdbtnfem.Text = "Female";
            rdbtnfem.UseVisualStyleBackColor = true;
            // 
            // rdbtnmale
            // 
            rdbtnmale.AutoSize = true;
            rdbtnmale.FlatAppearance.BorderSize = 0;
            rdbtnmale.FlatStyle = FlatStyle.Flat;
            rdbtnmale.Location = new Point(301, 236);
            rdbtnmale.Name = "rdbtnmale";
            rdbtnmale.Size = new Size(50, 19);
            rdbtnmale.TabIndex = 9;
            rdbtnmale.TabStop = true;
            rdbtnmale.Text = "Male";
            rdbtnmale.UseVisualStyleBackColor = true;
            // 
            // lblnewinfo
            // 
            lblnewinfo.AutoSize = true;
            lblnewinfo.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnewinfo.ForeColor = Color.Sienna;
            lblnewinfo.Location = new Point(162, 31);
            lblnewinfo.Name = "lblnewinfo";
            lblnewinfo.Size = new Size(239, 28);
            lblnewinfo.TabIndex = 8;
            lblnewinfo.Text = "NEW USER INFORMATION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // btndone
            // 
            btndone.BackColor = Color.Sienna;
            btndone.FlatAppearance.BorderSize = 0;
            btndone.FlatStyle = FlatStyle.Flat;
            btndone.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndone.ForeColor = Color.Linen;
            btndone.Location = new Point(235, 283);
            btndone.Name = "btndone";
            btndone.Size = new Size(75, 30);
            btndone.TabIndex = 6;
            btndone.Text = "Done";
            btndone.UseVisualStyleBackColor = false;
            btndone.Click += btndone_Click;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Font = new Font("Sitka Display", 11.249999F);
            lblage.ForeColor = Color.Sienna;
            lblage.Location = new Point(176, 185);
            lblage.Name = "lblage";
            lblage.Size = new Size(35, 21);
            lblage.TabIndex = 5;
            lblage.Text = "Age:";
            // 
            // lbllname
            // 
            lbllname.AutoSize = true;
            lbllname.Font = new Font("Sitka Display", 11.249999F);
            lbllname.ForeColor = Color.Sienna;
            lbllname.Location = new Point(134, 138);
            lbllname.Name = "lbllname";
            lbllname.Size = new Size(79, 21);
            lbllname.TabIndex = 4;
            lbllname.Text = "Last Name:";
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.Font = new Font("Sitka Display", 11.249999F);
            lblfname.ForeColor = Color.Sienna;
            lblfname.Location = new Point(132, 93);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(81, 21);
            lblfname.TabIndex = 3;
            lblfname.Text = "First Name:";
            // 
            // txtbxage
            // 
            txtbxage.BorderStyle = BorderStyle.None;
            txtbxage.Location = new Point(215, 188);
            txtbxage.Name = "txtbxage";
            txtbxage.Size = new Size(95, 16);
            txtbxage.TabIndex = 2;
            // 
            // txtbxlname
            // 
            txtbxlname.BorderStyle = BorderStyle.None;
            txtbxlname.Location = new Point(215, 141);
            txtbxlname.Name = "txtbxlname";
            txtbxlname.Size = new Size(170, 16);
            txtbxlname.TabIndex = 1;
            // 
            // txtbxfname
            // 
            txtbxfname.BorderStyle = BorderStyle.None;
            txtbxfname.Location = new Point(215, 96);
            txtbxfname.Name = "txtbxfname";
            txtbxfname.Size = new Size(170, 16);
            txtbxfname.TabIndex = 0;
            // 
            // btngoback
            // 
            btngoback.BackColor = Color.Transparent;
            btngoback.BackgroundImage = (Image)resources.GetObject("btngoback.BackgroundImage");
            btngoback.BackgroundImageLayout = ImageLayout.Zoom;
            btngoback.Image = (Image)resources.GetObject("btngoback.Image");
            btngoback.Location = new Point(12, 12);
            btngoback.Name = "btngoback";
            btngoback.Size = new Size(29, 28);
            btngoback.SizeMode = PictureBoxSizeMode.Zoom;
            btngoback.TabIndex = 2;
            btngoback.TabStop = false;
            btngoback.Click += btngoback_Click;
            // 
            // exitappbtn
            // 
            exitappbtn.BackColor = Color.Transparent;
            exitappbtn.Image = (Image)resources.GetObject("exitappbtn.Image");
            exitappbtn.Location = new Point(753, 12);
            exitappbtn.Name = "exitappbtn";
            exitappbtn.Size = new Size(35, 29);
            exitappbtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitappbtn.TabIndex = 4;
            exitappbtn.TabStop = false;
            exitappbtn.Click += exitappbtn_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(exitappbtn);
            Controls.Add(btngoback);
            Controls.Add(panel1);
            ForeColor = Color.Sienna;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "RegForm";
            Text = "RegForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btngoback).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtbxage;
        private TextBox txtbxlname;
        private TextBox txtbxfname;
        private Label lblage;
        private Label lbllname;
        private Label lblfname;
        private Label label1;
        private Button btndone;
        private Label lblnewinfo;
        private RadioButton rdbtnfem;
        private RadioButton rdbtnmale;
        private PictureBox btngoback;
        private PictureBox exitappbtn;
    }
}