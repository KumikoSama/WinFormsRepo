namespace BasicCalc
{
    partial class Calcu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calcu));
            txtDisplay = new TextBox();
            btnplus = new Button();
            btnmultiply = new Button();
            btnminus = new Button();
            btndivide = new Button();
            btnequals = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btndot = new Button();
            btn0 = new Button();
            btnclear = new Button();
            btndelete = new Button();
            txtpreview = new TextBox();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.Desktop;
            txtDisplay.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = SystemColors.Window;
            txtDisplay.Location = new Point(16, 45);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(334, 46);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += txtDisplay_TextChanged_1;
            // 
            // btnplus
            // 
            btnplus.BackColor = SystemColors.Desktop;
            btnplus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnplus.ForeColor = SystemColors.ButtonHighlight;
            btnplus.Location = new Point(212, 146);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(57, 53);
            btnplus.TabIndex = 1;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += btnOprtr_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.BackColor = SystemColors.Desktop;
            btnmultiply.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnmultiply.ForeColor = SystemColors.ButtonHighlight;
            btnmultiply.Location = new Point(212, 205);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(57, 53);
            btnmultiply.TabIndex = 2;
            btnmultiply.Text = "*";
            btnmultiply.UseVisualStyleBackColor = false;
            btnmultiply.Click += btnOprtr_Click;
            // 
            // btnminus
            // 
            btnminus.BackColor = SystemColors.Desktop;
            btnminus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnminus.ForeColor = SystemColors.ButtonHighlight;
            btnminus.Location = new Point(275, 146);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(57, 53);
            btnminus.TabIndex = 3;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += btnOprtr_Click;
            // 
            // btndivide
            // 
            btndivide.BackColor = SystemColors.Desktop;
            btndivide.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndivide.ForeColor = SystemColors.ButtonHighlight;
            btndivide.Location = new Point(275, 205);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(57, 53);
            btndivide.TabIndex = 4;
            btndivide.Text = "/";
            btndivide.UseVisualStyleBackColor = false;
            btndivide.Click += btnOprtr_Click;
            // 
            // btnequals
            // 
            btnequals.BackColor = SystemColors.Desktop;
            btnequals.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnequals.ForeColor = SystemColors.ButtonHighlight;
            btnequals.Location = new Point(212, 264);
            btnequals.Name = "btnequals";
            btnequals.Size = new Size(120, 64);
            btnequals.TabIndex = 5;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = false;
            btnequals.Click += btnequals_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.Desktop;
            btn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(41, 224);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 49);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.Desktop;
            btn2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(98, 224);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 49);
            btn2.TabIndex = 7;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.Desktop;
            btn3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(155, 224);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 49);
            btn3.TabIndex = 8;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.Desktop;
            btn4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(41, 169);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 49);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.Desktop;
            btn5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(98, 169);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 49);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.Desktop;
            btn6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(155, 169);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 49);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.Desktop;
            btn7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(41, 114);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 49);
            btn7.TabIndex = 12;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.Desktop;
            btn8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(98, 114);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 49);
            btn8.TabIndex = 13;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNum_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.Desktop;
            btn9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(155, 114);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 49);
            btn9.TabIndex = 14;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNum_Click;
            // 
            // btndot
            // 
            btndot.BackColor = SystemColors.Desktop;
            btndot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndot.ForeColor = SystemColors.ButtonHighlight;
            btndot.Location = new Point(155, 279);
            btndot.Name = "btndot";
            btndot.Size = new Size(51, 49);
            btndot.TabIndex = 15;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = false;
            btndot.Click += btndot_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.Desktop;
            btn0.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(41, 279);
            btn0.Name = "btn0";
            btn0.Size = new Size(108, 49);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = SystemColors.Desktop;
            btnclear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ButtonHighlight;
            btnclear.Location = new Point(212, 114);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(57, 26);
            btnclear.TabIndex = 17;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = SystemColors.Desktop;
            btndelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(275, 114);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(57, 26);
            btndelete.TabIndex = 18;
            btndelete.Text = "DEL";
            btndelete.UseVisualStyleBackColor = false;
            // 
            // txtpreview
            // 
            txtpreview.BackColor = SystemColors.MenuText;
            txtpreview.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtpreview.ForeColor = SystemColors.ScrollBar;
            txtpreview.Location = new Point(16, 20);
            txtpreview.Name = "txtpreview";
            txtpreview.Size = new Size(334, 27);
            txtpreview.TabIndex = 19;
            txtpreview.Text = "Text preview";
            txtpreview.TextAlign = HorizontalAlignment.Right;
            // 
            // Calcu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(362, 349);
            Controls.Add(btndelete);
            Controls.Add(btnclear);
            Controls.Add(btn0);
            Controls.Add(btndot);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnequals);
            Controls.Add(btndivide);
            Controls.Add(btnminus);
            Controls.Add(btnmultiply);
            Controls.Add(btnplus);
            Controls.Add(txtDisplay);
            Controls.Add(txtpreview);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calcu";
            Text = "Basic Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnplus;
        private Button btnmultiply;
        private Button btnminus;
        private Button btndivide;
        private Button btnequals;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btndot;
        private Button btn0;
        private Button btnclear;
        private Button btndelete;
        private TextBox txtpreview;
    }
}
