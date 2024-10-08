
namespace MyFirstWinForms
{
    partial class MainForm
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
            pictureBox1 = new PictureBox();
            lblwelcome = new Label();
            lbldisplayname = new Label();
            lbluserinfo = new Label();
            lblname = new Label();
            lblgender = new Label();
            lbluser = new Label();
            updatelblname = new Label();
            updatelbluser = new Label();
            updatelblgender = new Label();
            updatelblbirth = new Label();
            lblbirthday = new Label();
            linkLabel1 = new LinkLabel();
            usericon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usericon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.black_cat;
            pictureBox1.Location = new Point(93, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblwelcome
            // 
            lblwelcome.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblwelcome.AutoSize = true;
            lblwelcome.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblwelcome.Location = new Point(58, 148);
            lblwelcome.Name = "lblwelcome";
            lblwelcome.Size = new Size(167, 33);
            lblwelcome.TabIndex = 1;
            lblwelcome.Text = "WELCOME";
            lblwelcome.Click += lblwelcome_Click;
            // 
            // lbldisplayname
            // 
            lbldisplayname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbldisplayname.AutoSize = true;
            lbldisplayname.Font = new Font("Rockwell", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbldisplayname.Location = new Point(76, 177);
            lbldisplayname.Name = "lbldisplayname";
            lbldisplayname.Size = new Size(130, 30);
            lbldisplayname.TabIndex = 2;
            lbldisplayname.Text = "Username";
            lbldisplayname.Click += label1_Click;
            // 
            // lbluserinfo
            // 
            lbluserinfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbluserinfo.AutoSize = true;
            lbluserinfo.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbluserinfo.Location = new Point(35, 244);
            lbluserinfo.Name = "lbluserinfo";
            lbluserinfo.Size = new Size(134, 19);
            lbluserinfo.TabIndex = 3;
            lbluserinfo.Text = "User Information";
            // 
            // lblname
            // 
            lblname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblname.AutoSize = true;
            lblname.Font = new Font("Yu Gothic", 9.75F);
            lblname.Location = new Point(61, 275);
            lblname.Name = "lblname";
            lblname.Size = new Size(47, 17);
            lblname.TabIndex = 4;
            lblname.Text = "Name:";
            // 
            // lblgender
            // 
            lblgender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Yu Gothic", 9.75F);
            lblgender.Location = new Point(61, 328);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(56, 17);
            lblgender.TabIndex = 5;
            lblgender.Text = "Gender:";
            // 
            // lbluser
            // 
            lbluser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Yu Gothic", 9.75F);
            lbluser.Location = new Point(61, 300);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(74, 17);
            lbluser.TabIndex = 6;
            lbluser.Text = "Username:";
            // 
            // updatelblname
            // 
            updatelblname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updatelblname.AutoSize = true;
            updatelblname.Font = new Font("Yu Gothic Light", 9.75F);
            updatelblname.Location = new Point(163, 277);
            updatelblname.Name = "updatelblname";
            updatelblname.Size = new Size(40, 17);
            updatelblname.TabIndex = 7;
            updatelblname.Text = "name";
            // 
            // updatelbluser
            // 
            updatelbluser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updatelbluser.AutoSize = true;
            updatelbluser.Font = new Font("Yu Gothic Light", 9.75F);
            updatelbluser.Location = new Point(163, 302);
            updatelbluser.Name = "updatelbluser";
            updatelbluser.Size = new Size(32, 17);
            updatelbluser.TabIndex = 8;
            updatelbluser.Text = "user";
            // 
            // updatelblgender
            // 
            updatelblgender.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updatelblgender.AutoSize = true;
            updatelblgender.Font = new Font("Yu Gothic Light", 9.75F);
            updatelblgender.Location = new Point(163, 328);
            updatelblgender.Name = "updatelblgender";
            updatelblgender.Size = new Size(47, 17);
            updatelblgender.TabIndex = 9;
            updatelblgender.Text = "gender";
            // 
            // updatelblbirth
            // 
            updatelblbirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            updatelblbirth.AutoSize = true;
            updatelblbirth.Font = new Font("Yu Gothic Light", 9.75F);
            updatelblbirth.Location = new Point(163, 354);
            updatelblbirth.Name = "updatelblbirth";
            updatelblbirth.Size = new Size(53, 17);
            updatelblbirth.TabIndex = 11;
            updatelblbirth.Text = "birthday";
            // 
            // lblbirthday
            // 
            lblbirthday.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblbirthday.AutoSize = true;
            lblbirthday.Font = new Font("Yu Gothic", 9.75F);
            lblbirthday.Location = new Point(61, 354);
            lblbirthday.Name = "lblbirthday";
            lblbirthday.Size = new Size(63, 17);
            lblbirthday.TabIndex = 10;
            lblbirthday.Text = "Birthday:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Yu Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(109, 415);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(49, 16);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // usericon
            // 
            usericon.Image = Properties.Resources.user_solid;
            usericon.Location = new Point(19, 244);
            usericon.Name = "usericon";
            usericon.Size = new Size(15, 17);
            usericon.SizeMode = PictureBoxSizeMode.Zoom;
            usericon.TabIndex = 34;
            usericon.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 443);
            Controls.Add(usericon);
            Controls.Add(linkLabel1);
            Controls.Add(updatelblbirth);
            Controls.Add(lblbirthday);
            Controls.Add(updatelblgender);
            Controls.Add(updatelbluser);
            Controls.Add(updatelblname);
            Controls.Add(lbluser);
            Controls.Add(lblgender);
            Controls.Add(lblname);
            Controls.Add(lbluserinfo);
            Controls.Add(lbldisplayname);
            Controls.Add(lblwelcome);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)usericon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblwelcome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblwelcome;
        private Label lbldisplayname;
        private Label lbluserinfo;
        private Label lblname;
        private Label lblgender;
        private Label lbluser;
        private Label updatelblname;
        private Label updatelbluser;
        private Label updatelblgender;
        private Label updatelblbirth;
        private Label lblbirthday;
        private LinkLabel linkLabel1;
        private PictureBox usericon;
    }
}