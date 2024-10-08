namespace MyFirstWinForms
{
    partial class RegistrationForm
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
            linklbllogin = new LinkLabel();
            lbllname = new Label();
            txtbxlname = new TextBox();
            lblfname = new Label();
            txtbxfname = new TextBox();
            btnregister = new Button();
            lblsetpass = new Label();
            txtbxsetpass = new TextBox();
            rbtnfemale = new RadioButton();
            rbtnmale = new RadioButton();
            lblgender = new Label();
            lblsetuser = new Label();
            txtbxsetuser = new TextBox();
            birthdayset = new DateTimePicker();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            chckshowpass = new CheckBox();
            femicon = new PictureBox();
            maleicon = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)femicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maleicon).BeginInit();
            SuspendLayout();
            // 
            // linklbllogin
            // 
            linklbllogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linklbllogin.AutoSize = true;
            linklbllogin.Font = new Font("Yu Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linklbllogin.Location = new Point(163, 400);
            linklbllogin.Name = "linklbllogin";
            linklbllogin.Size = new Size(134, 14);
            linklbllogin.TabIndex = 18;
            linklbllogin.TabStop = true;
            linklbllogin.Text = "Already have an account?";
            linklbllogin.LinkClicked += linklbllogin_LinkClicked;
            // 
            // lbllname
            // 
            lbllname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbllname.AutoSize = true;
            lbllname.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold);
            lbllname.Location = new Point(243, 131);
            lbllname.Name = "lbllname";
            lbllname.Size = new Size(71, 14);
            lbllname.TabIndex = 17;
            lbllname.Text = "Last Name";
            lbllname.Click += lbllname_Click;
            // 
            // txtbxlname
            // 
            txtbxlname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxlname.Location = new Point(259, 148);
            txtbxlname.Name = "txtbxlname";
            txtbxlname.Size = new Size(155, 23);
            txtbxlname.TabIndex = 16;
            // 
            // lblfname
            // 
            lblfname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblfname.AutoSize = true;
            lblfname.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold);
            lblfname.Location = new Point(33, 131);
            lblfname.Name = "lblfname";
            lblfname.Size = new Size(73, 14);
            lblfname.TabIndex = 15;
            lblfname.Text = "First Name";
            // 
            // txtbxfname
            // 
            txtbxfname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxfname.Location = new Point(48, 148);
            txtbxfname.Name = "txtbxfname";
            txtbxfname.Size = new Size(155, 23);
            txtbxfname.TabIndex = 14;
            // 
            // btnregister
            // 
            btnregister.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnregister.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold);
            btnregister.Location = new Point(199, 372);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(67, 23);
            btnregister.TabIndex = 13;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click;
            // 
            // lblsetpass
            // 
            lblsetpass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblsetpass.AutoSize = true;
            lblsetpass.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold);
            lblsetpass.Location = new Point(33, 254);
            lblsetpass.Name = "lblsetpass";
            lblsetpass.Size = new Size(89, 14);
            lblsetpass.TabIndex = 20;
            lblsetpass.Text = "Set Password";
            // 
            // txtbxsetpass
            // 
            txtbxsetpass.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxsetpass.Location = new Point(48, 271);
            txtbxsetpass.Name = "txtbxsetpass";
            txtbxsetpass.PasswordChar = '*';
            txtbxsetpass.Size = new Size(155, 23);
            txtbxsetpass.TabIndex = 19;
            // 
            // rbtnfemale
            // 
            rbtnfemale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbtnfemale.AutoSize = true;
            rbtnfemale.Font = new Font("Yu Gothic", 9F);
            rbtnfemale.Location = new Point(255, 211);
            rbtnfemale.Name = "rbtnfemale";
            rbtnfemale.Size = new Size(65, 20);
            rbtnfemale.TabIndex = 21;
            rbtnfemale.TabStop = true;
            rbtnfemale.Text = "Female";
            rbtnfemale.UseVisualStyleBackColor = true;
            // 
            // rbtnmale
            // 
            rbtnmale.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rbtnmale.AutoSize = true;
            rbtnmale.Font = new Font("Yu Gothic", 9F);
            rbtnmale.Location = new Point(255, 236);
            rbtnmale.Name = "rbtnmale";
            rbtnmale.Size = new Size(53, 20);
            rbtnmale.TabIndex = 22;
            rbtnmale.TabStop = true;
            rbtnmale.Text = "Male";
            rbtnmale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            lblgender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold);
            lblgender.Location = new Point(243, 193);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(49, 14);
            lblgender.TabIndex = 23;
            lblgender.Text = "Gender";
            // 
            // lblsetuser
            // 
            lblsetuser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblsetuser.AutoSize = true;
            lblsetuser.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold);
            lblsetuser.Location = new Point(33, 191);
            lblsetuser.Name = "lblsetuser";
            lblsetuser.Size = new Size(90, 14);
            lblsetuser.TabIndex = 25;
            lblsetuser.Text = "Set Username";
            // 
            // txtbxsetuser
            // 
            txtbxsetuser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtbxsetuser.Location = new Point(48, 208);
            txtbxsetuser.Name = "txtbxsetuser";
            txtbxsetuser.Size = new Size(155, 23);
            txtbxsetuser.TabIndex = 24;
            // 
            // birthdayset
            // 
            birthdayset.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            birthdayset.CalendarFont = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            birthdayset.Location = new Point(259, 293);
            birthdayset.Name = "birthdayset";
            birthdayset.Size = new Size(176, 23);
            birthdayset.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic Medium", 8.25F, FontStyle.Bold);
            label1.Location = new Point(243, 276);
            label1.Name = "label1";
            label1.Size = new Size(80, 14);
            label1.TabIndex = 27;
            label1.Text = "Set Birthday";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.black_cat;
            pictureBox1.Location = new Point(186, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Yu Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(42, 297);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(65, 14);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Clear fields";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // chckshowpass
            // 
            chckshowpass.AutoSize = true;
            chckshowpass.Location = new Point(183, 276);
            chckshowpass.Name = "chckshowpass";
            chckshowpass.Size = new Size(15, 14);
            chckshowpass.TabIndex = 30;
            chckshowpass.UseVisualStyleBackColor = true;
            chckshowpass.CheckedChanged += chckshowpass_CheckedChanged;
            // 
            // femicon
            // 
            femicon.Image = Properties.Resources.venus_solid;
            femicon.Location = new Point(318, 212);
            femicon.Name = "femicon";
            femicon.Size = new Size(15, 17);
            femicon.SizeMode = PictureBoxSizeMode.Zoom;
            femicon.TabIndex = 31;
            femicon.TabStop = false;
            // 
            // maleicon
            // 
            maleicon.Image = Properties.Resources.mars_solid;
            maleicon.Location = new Point(318, 237);
            maleicon.Name = "maleicon";
            maleicon.Size = new Size(15, 17);
            maleicon.SizeMode = PictureBoxSizeMode.Zoom;
            maleicon.TabIndex = 32;
            maleicon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-2, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 29);
            panel1.TabIndex = 36;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(479, 463);
            Controls.Add(panel1);
            Controls.Add(maleicon);
            Controls.Add(femicon);
            Controls.Add(chckshowpass);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(birthdayset);
            Controls.Add(lblsetuser);
            Controls.Add(txtbxsetuser);
            Controls.Add(lblgender);
            Controls.Add(rbtnmale);
            Controls.Add(rbtnfemale);
            Controls.Add(lblsetpass);
            Controls.Add(txtbxsetpass);
            Controls.Add(linklbllogin);
            Controls.Add(lbllname);
            Controls.Add(txtbxlname);
            Controls.Add(lblfname);
            Controls.Add(txtbxfname);
            Controls.Add(btnregister);
            Name = "RegistrationForm";
            Text = "Registration Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)femicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)maleicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linklbllogin;
        private Label lbllname;
        private TextBox txtbxlname;
        private Label lblfname;
        private TextBox txtbxfname;
        private Button btnregister;
        private Label lblsetpass;
        private TextBox txtbxsetpass;
        private RadioButton rbtnfemale;
        private RadioButton rbtnmale;
        private Label lblgender;
        private Label lblsetuser;
        private TextBox txtbxsetuser;
        private DateTimePicker birthdayset;
        private Label label1;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private CheckBox chckshowpass;
        private PictureBox femicon;
        private PictureBox maleicon;
        private Panel panel1;
    }
}