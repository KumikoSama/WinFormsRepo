namespace RockPaperScissors
{
    partial class SettingUp
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
            this.components = new System.ComponentModel.Container();
            this.btnstart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.cmboxgamemode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(172, 150);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(90, 25);
            this.btnstart.TabIndex = 1;
            this.btnstart.Values.Text = "Start";
            this.btnstart.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(172, 296);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 2;
            this.kryptonButton2.Values.Text = "Go Back";
            // 
            // cmboxgamemode
            // 
            this.cmboxgamemode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboxgamemode.FormattingEnabled = true;
            this.cmboxgamemode.Items.AddRange(new object[] {
            "Best-of-three",
            "Best-of-five",
            "Tournament Mode"});
            this.cmboxgamemode.Location = new System.Drawing.Point(132, 114);
            this.cmboxgamemode.Name = "cmboxgamemode";
            this.cmboxgamemode.Size = new System.Drawing.Size(174, 26);
            this.cmboxgamemode.TabIndex = 4;
            this.cmboxgamemode.Text = "Choose a game mode";
            // 
            // SettingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(434, 394);
            this.Controls.Add(this.cmboxgamemode);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.btnstart);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "SettingUp";
            this.Text = "SettingUp";
            this.Load += new System.EventHandler(this.SettingUp_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnstart;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.ComboBox cmboxgamemode;
    }
}