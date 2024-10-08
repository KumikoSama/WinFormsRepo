
namespace MyFirstWinForms
{
    partial class LoginForm
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
            btndone = new Button();
            txtbxuser = new TextBox();
            lbluser = new Label();
            lblpass = new Label();
            txtbxpass = new TextBox();
            linklblreg = new LinkLabel();
            chckshowpass = new CheckBox();
            togglebtn = new PictureBox();
            catpicture = new PictureBox();
            usericon = new PictureBox();
            lockicon = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)togglebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catpicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usericon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lockicon).BeginInit();
            SuspendLayout();
            // 
            // btndone
            // 
            btndone.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btndone.ForeColor = Color.Black;
            btndone.Location = new Point(186, 247);
            btndone.Name = "btndone";
            btndone.Size = new Size(75, 23);
            btndone.TabIndex = 4;
            btndone.Text = "Done";
            btndone.UseVisualStyleBackColor = true;
            btndone.Click += button1_Click;
            // 
            // txtbxuser
            // 
            txtbxuser.Font = new Font("Yu Gothic", 9F);
            txtbxuser.Location = new Point(159, 139);
            txtbxuser.Name = "txtbxuser";
            txtbxuser.Size = new Size(154, 27);
            txtbxuser.TabIndex = 5;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.BackColor = Color.Transparent;
            lbluser.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            lbluser.ForeColor = SystemColors.ActiveCaptionText;
            lbluser.Location = new Point(136, 121);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(72, 16);
            lbluser.TabIndex = 6;
            lbluser.Text = "Username";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.BackColor = Color.Transparent;
            lblpass.Font = new Font("Yu Gothic Medium", 9F, FontStyle.Bold);
            lblpass.ForeColor = SystemColors.ActiveCaptionText;
            lblpass.Location = new Point(136, 182);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(69, 16);
            lblpass.TabIndex = 10;
            lblpass.Text = "Password";
            // 
            // txtbxpass
            // 
            txtbxpass.Font = new Font("Yu Gothic", 9F);
            txtbxpass.Location = new Point(159, 200);
            txtbxpass.Name = "txtbxpass";
            txtbxpass.PasswordChar = '*';
            txtbxpass.Size = new Size(154, 27);
            txtbxpass.TabIndex = 9;
            // 
            // linklblreg
            // 
            linklblreg.AutoSize = true;
            linklblreg.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            linklblreg.LinkColor = Color.Gray;
            linklblreg.Location = new Point(159, 283);
            linklblreg.Name = "linklblreg";
            linklblreg.Size = new Size(131, 15);
            linklblreg.TabIndex = 12;
            linklblreg.TabStop = true;
            linklblreg.Text = "Don't have an account?";
            linklblreg.LinkClicked += linklblreg_LinkClicked;
            // 
            // chckshowpass
            // 
            chckshowpass.AutoSize = true;
            chckshowpass.BackColor = SystemColors.ActiveCaptionText;
            chckshowpass.FlatAppearance.BorderSize = 0;
            chckshowpass.FlatStyle = FlatStyle.Flat;
            chckshowpass.ForeColor = SystemColors.ActiveCaptionText;
            chckshowpass.Location = new Point(293, 208);
            chckshowpass.Name = "chckshowpass";
            chckshowpass.Size = new Size(12, 11);
            chckshowpass.TabIndex = 13;
            chckshowpass.UseVisualStyleBackColor = false;
            chckshowpass.CheckedChanged += chckshowpass_CheckedChanged;
            // 
            // togglebtn
            // 
            togglebtn.Image = Properties.Resources.circle_half_stroke_solid;
            togglebtn.Location = new Point(441, 302);
            togglebtn.Name = "togglebtn";
            togglebtn.Size = new Size(20, 16);
            togglebtn.SizeMode = PictureBoxSizeMode.Zoom;
            togglebtn.TabIndex = 15;
            togglebtn.TabStop = false;
            togglebtn.Click += togglebtn_Click;
            // 
            // catpicture
            // 
            catpicture.BackgroundImageLayout = ImageLayout.Zoom;
            catpicture.Image = Properties.Resources.cat_solid;
            catpicture.Location = new Point(186, 36);
            catpicture.Name = "catpicture";
            catpicture.Size = new Size(89, 79);
            catpicture.SizeMode = PictureBoxSizeMode.Zoom;
            catpicture.TabIndex = 16;
            catpicture.TabStop = false;
            // 
            // usericon
            // 
            usericon.Image = Properties.Resources.user_solid;
            usericon.Location = new Point(139, 144);
            usericon.Name = "usericon";
            usericon.Size = new Size(15, 17);
            usericon.SizeMode = PictureBoxSizeMode.Zoom;
            usericon.TabIndex = 33;
            usericon.TabStop = false;
            // 
            // lockicon
            // 
            lockicon.Image = Properties.Resources.lock_solid;
            lockicon.Location = new Point(139, 205);
            lockicon.Name = "lockicon";
            lockicon.Size = new Size(15, 17);
            lockicon.SizeMode = PictureBoxSizeMode.Zoom;
            lockicon.TabIndex = 34;
            lockicon.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(-5, -6);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 29);
            panel1.TabIndex = 35;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(473, 330);
            Controls.Add(panel1);
            Controls.Add(lockicon);
            Controls.Add(usericon);
            Controls.Add(catpicture);
            Controls.Add(togglebtn);
            Controls.Add(chckshowpass);
            Controls.Add(linklblreg);
            Controls.Add(lblpass);
            Controls.Add(txtbxpass);
            Controls.Add(lbluser);
            Controls.Add(txtbxuser);
            Controls.Add(btndone);
            Name = "LoginForm";
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)togglebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)catpicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)usericon).EndInit();
            ((System.ComponentModel.ISupportInitialize)lockicon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btndone;
        private TextBox txtbxuser;
        private Label lbluser;
        private Label lblpass;
        private TextBox txtbxpass;
        private Label label1;
        private LinkLabel linklblreg;
        private CheckBox chckshowpass;
        private PictureBox togglebtn;
        private PictureBox catpicture;
        private PictureBox usericon;
        private PictureBox lockicon;
        private Panel panel1;
    }
}
