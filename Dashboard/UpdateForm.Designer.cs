namespace Dashboard
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            panel1 = new Panel();
            lbluserid = new Label();
            rdbtnfem = new RadioButton();
            rdbtnmale = new RadioButton();
            lbluserinfo = new Label();
            label1 = new Label();
            btnupdate = new Button();
            lblage = new Label();
            lbllname = new Label();
            lblfname = new Label();
            txtbxage = new TextBox();
            txtbxlname = new TextBox();
            txtbxfname = new TextBox();
            panel2 = new Panel();
            exitappbtn = new PictureBox();
            btngoback = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btngoback).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(lbluserid);
            panel1.Controls.Add(rdbtnfem);
            panel1.Controls.Add(rdbtnmale);
            panel1.Controls.Add(lbluserinfo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnupdate);
            panel1.Controls.Add(lblage);
            panel1.Controls.Add(lbllname);
            panel1.Controls.Add(lblfname);
            panel1.Controls.Add(txtbxage);
            panel1.Controls.Add(txtbxlname);
            panel1.Controls.Add(txtbxfname);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(117, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 364);
            panel1.TabIndex = 1;
            // 
            // lbluserid
            // 
            lbluserid.AutoSize = true;
            lbluserid.Font = new Font("Sitka Heading", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbluserid.ForeColor = Color.Sienna;
            lbluserid.Location = new Point(245, 59);
            lbluserid.Name = "lbluserid";
            lbluserid.Size = new Size(66, 19);
            lbluserid.TabIndex = 12;
            lbluserid.Text = "USER ID#";
            // 
            // rdbtnfem
            // 
            rdbtnfem.AutoSize = true;
            rdbtnfem.FlatAppearance.BorderSize = 0;
            rdbtnfem.FlatStyle = FlatStyle.Flat;
            rdbtnfem.Font = new Font("Sitka Display", 12F);
            rdbtnfem.ForeColor = Color.Sienna;
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
            rdbtnmale.ForeColor = Color.Sienna;
            rdbtnmale.Location = new Point(313, 236);
            rdbtnmale.Name = "rdbtnmale";
            rdbtnmale.Size = new Size(57, 27);
            rdbtnmale.TabIndex = 9;
            rdbtnmale.TabStop = true;
            rdbtnmale.Text = "Male";
            rdbtnmale.UseVisualStyleBackColor = true;
            // 
            // lbluserinfo
            // 
            lbluserinfo.AutoSize = true;
            lbluserinfo.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserinfo.ForeColor = Color.Sienna;
            lbluserinfo.Location = new Point(191, 31);
            lbluserinfo.Name = "lbluserinfo";
            lbluserinfo.Size = new Size(192, 28);
            lbluserinfo.TabIndex = 8;
            lbluserinfo.Text = "USER INFORMATION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Sienna;
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Font = new Font("Sitka Banner", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = Color.Linen;
            btnupdate.Location = new Point(250, 291);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(75, 30);
            btnupdate.TabIndex = 6;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btndone_Click;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Font = new Font("Sitka Display", 12F);
            lblage.ForeColor = Color.Sienna;
            lblage.Location = new Point(174, 191);
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
            lbllname.Location = new Point(131, 147);
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
            lblfname.Location = new Point(129, 103);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(84, 23);
            lblfname.TabIndex = 3;
            lblfname.Text = "First Name:";
            // 
            // txtbxage
            // 
            txtbxage.BorderStyle = BorderStyle.None;
            txtbxage.Font = new Font("Sitka Subheading", 12F);
            txtbxage.Location = new Point(214, 192);
            txtbxage.Name = "txtbxage";
            txtbxage.Size = new Size(202, 21);
            txtbxage.TabIndex = 2;
            // 
            // txtbxlname
            // 
            txtbxlname.BorderStyle = BorderStyle.None;
            txtbxlname.Font = new Font("Sitka Subheading", 12F);
            txtbxlname.Location = new Point(214, 148);
            txtbxlname.Name = "txtbxlname";
            txtbxlname.Size = new Size(202, 21);
            txtbxlname.TabIndex = 1;
            // 
            // txtbxfname
            // 
            txtbxfname.BorderStyle = BorderStyle.None;
            txtbxfname.Font = new Font("Sitka Subheading", 12F);
            txtbxfname.Location = new Point(214, 104);
            txtbxfname.Name = "txtbxfname";
            txtbxfname.Size = new Size(202, 21);
            txtbxfname.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(121, 73, 51);
            panel2.Location = new Point(245, 291);
            panel2.Name = "panel2";
            panel2.Size = new Size(80, 35);
            panel2.TabIndex = 11;
            // 
            // exitappbtn
            // 
            exitappbtn.BackColor = Color.Transparent;
            exitappbtn.Image = (Image)resources.GetObject("exitappbtn.Image");
            exitappbtn.Location = new Point(764, 12);
            exitappbtn.Name = "exitappbtn";
            exitappbtn.Size = new Size(24, 19);
            exitappbtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitappbtn.TabIndex = 6;
            exitappbtn.TabStop = false;
            exitappbtn.Click += exitappbtn_Click;
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
            btngoback.TabIndex = 5;
            btngoback.TabStop = false;
            btngoback.Click += btngoback_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(exitappbtn);
            Controls.Add(btngoback);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UpdateForm";
            Text = "UpdateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)btngoback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbluserid;
        private RadioButton rdbtnfem;
        private RadioButton rdbtnmale;
        private Label lbluserinfo;
        private Label label1;
        private Button btnupdate;
        private Label lblage;
        private Label lbllname;
        private Label lblfname;
        private TextBox txtbxage;
        private TextBox txtbxlname;
        private TextBox txtbxfname;
        private Panel panel2;
        private PictureBox exitappbtn;
        private PictureBox btngoback;
    }
}