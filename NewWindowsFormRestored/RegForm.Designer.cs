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
            clearfields = new LinkLabel();
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
            panel2 = new Panel();
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
            panel1.Controls.Add(clearfields);
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
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(116, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 364);
            panel1.TabIndex = 0;
            // 
            // clearfields
            // 
            clearfields.AutoSize = true;
            clearfields.BackColor = Color.Transparent;
            clearfields.Font = new Font("Sitka Banner", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            clearfields.LinkColor = Color.FromArgb(64, 64, 64);
            clearfields.Location = new Point(249, 328);
            clearfields.Name = "clearfields";
            clearfields.Size = new Size(74, 18);
            clearfields.TabIndex = 12;
            clearfields.TabStop = true;
            clearfields.Text = "Clear all fields";
            clearfields.LinkClicked += clearfields_LinkClicked;
            // 
            // rdbtnfem
            // 
            rdbtnfem.AutoSize = true;
            rdbtnfem.FlatAppearance.BorderSize = 0;
            rdbtnfem.FlatStyle = FlatStyle.Flat;
            rdbtnfem.Font = new Font("Sitka Display", 12F);
            rdbtnfem.Location = new Point(211, 236);
            rdbtnfem.Name = "rdbtnfem";
            rdbtnfem.Size = new Size(73, 27);
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
            rdbtnmale.Font = new Font("Sitka Display", 12F);
            rdbtnmale.Location = new Point(313, 236);
            rdbtnmale.Name = "rdbtnmale";
            rdbtnmale.Size = new Size(57, 27);
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
            lblnewinfo.Location = new Point(165, 31);
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
            btndone.BackColor = Color.FromArgb(164, 113, 72);
            btndone.FlatAppearance.BorderSize = 0;
            btndone.FlatStyle = FlatStyle.Flat;
            btndone.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndone.ForeColor = Color.Linen;
            btndone.Location = new Point(250, 291);
            btndone.Name = "btndone";
            btndone.Size = new Size(75, 30);
            btndone.TabIndex = 6;
            btndone.Text = "Save";
            btndone.UseVisualStyleBackColor = false;
            btndone.Click += btndone_Click;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Font = new Font("Sitka Display", 12F);
            lblage.ForeColor = Color.Sienna;
            lblage.Location = new Point(175, 183);
            lblage.Name = "lblage";
            lblage.Size = new Size(38, 23);
            lblage.TabIndex = 5;
            lblage.Text = "Age:";
            // 
            // lbllname
            // 
            lbllname.AutoSize = true;
            lbllname.Font = new Font("Sitka Display", 12F);
            lbllname.ForeColor = Color.Sienna;
            lbllname.Location = new Point(132, 139);
            lbllname.Name = "lbllname";
            lbllname.Size = new Size(81, 23);
            lbllname.TabIndex = 4;
            lbllname.Text = "Last Name:";
            // 
            // lblfname
            // 
            lblfname.AutoSize = true;
            lblfname.Font = new Font("Sitka Display", 12F);
            lblfname.ForeColor = Color.Sienna;
            lblfname.Location = new Point(130, 95);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(84, 23);
            lblfname.TabIndex = 3;
            lblfname.Text = "First Name:";
            // 
            // txtbxage
            // 
            txtbxage.BorderStyle = BorderStyle.None;
            txtbxage.Font = new Font("Sitka Subheading", 12F);
            txtbxage.Location = new Point(215, 184);
            txtbxage.Name = "txtbxage";
            txtbxage.Size = new Size(202, 21);
            txtbxage.TabIndex = 2;
            // 
            // txtbxlname
            // 
            txtbxlname.BorderStyle = BorderStyle.None;
            txtbxlname.Font = new Font("Sitka Subheading", 12F);
            txtbxlname.Location = new Point(215, 140);
            txtbxlname.Name = "txtbxlname";
            txtbxlname.Size = new Size(202, 21);
            txtbxlname.TabIndex = 1;
            // 
            // txtbxfname
            // 
            txtbxfname.BorderStyle = BorderStyle.None;
            txtbxfname.Font = new Font("Sitka Subheading", 12F);
            txtbxfname.Location = new Point(215, 96);
            txtbxfname.Name = "txtbxfname";
            txtbxfname.Size = new Size(202, 21);
            txtbxfname.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(156, 102, 68);
            panel2.Location = new Point(246, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 33);
            panel2.TabIndex = 11;
            // 
            // btngoback
            // 
            btngoback.BackColor = Color.Transparent;
            btngoback.BackgroundImage = (Image)resources.GetObject("btngoback.BackgroundImage");
            btngoback.BackgroundImageLayout = ImageLayout.Zoom;
            btngoback.Image = (Image)resources.GetObject("btngoback.Image");
            btngoback.Location = new Point(12, 12);
            btngoback.Name = "btngoback";
            btngoback.Size = new Size(24, 19);
            btngoback.SizeMode = PictureBoxSizeMode.Zoom;
            btngoback.TabIndex = 2;
            btngoback.TabStop = false;
            btngoback.Click += btngoback_Click;
            // 
            // exitappbtn
            // 
            exitappbtn.BackColor = Color.Transparent;
            exitappbtn.Image = (Image)resources.GetObject("exitappbtn.Image");
            exitappbtn.Location = new Point(761, 12);
            exitappbtn.Name = "exitappbtn";
            exitappbtn.Size = new Size(27, 19);
            exitappbtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitappbtn.TabIndex = 4;
            exitappbtn.TabStop = false;
            exitappbtn.Click += exitappbtn_Click;
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private Panel panel2;
        private LinkLabel clearfields;
    }
}