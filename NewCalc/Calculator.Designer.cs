namespace NewCalc
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            txtDisplay = new TextBox();
            btn1 = new Button();
            btnplus = new Button();
            btnminus = new Button();
            btnequals = new Button();
            btndivide = new Button();
            btnmultiply = new Button();
            btndelete = new Button();
            btnclear = new Button();
            btn0 = new Button();
            btndot = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            txtPreview = new TextBox();
            btnneg = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.MistyRose;
            txtDisplay.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.DimGray;
            txtDisplay.Location = new Point(12, 52);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(315, 50);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = Color.MistyRose;
            btn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn1.ForeColor = Color.DimGray;
            btn1.Location = new Point(34, 230);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 49);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.YellowGreen;
            btnplus.FlatAppearance.BorderColor = Color.OliveDrab;
            btnplus.FlatAppearance.BorderSize = 2;
            btnplus.FlatStyle = FlatStyle.Flat;
            btnplus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnplus.ForeColor = SystemColors.ButtonHighlight;
            btnplus.Location = new Point(205, 285);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(49, 49);
            btnplus.TabIndex = 8;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += btnOprtr_Click;
            // 
            // btnminus
            // 
            btnminus.BackColor = Color.YellowGreen;
            btnminus.FlatAppearance.BorderColor = Color.OliveDrab;
            btnminus.FlatAppearance.BorderSize = 2;
            btnminus.FlatStyle = FlatStyle.Flat;
            btnminus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnminus.ForeColor = SystemColors.ButtonHighlight;
            btnminus.Location = new Point(205, 230);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(49, 49);
            btnminus.TabIndex = 9;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += btnOprtr_Click;
            // 
            // btnequals
            // 
            btnequals.BackColor = Color.YellowGreen;
            btnequals.FlatAppearance.BorderColor = Color.OliveDrab;
            btnequals.FlatAppearance.BorderSize = 2;
            btnequals.FlatStyle = FlatStyle.Flat;
            btnequals.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnequals.ForeColor = SystemColors.ButtonHighlight;
            btnequals.Location = new Point(260, 230);
            btnequals.Name = "btnequals";
            btnequals.Size = new Size(49, 104);
            btnequals.TabIndex = 12;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = false;
            btnequals.Click += btnequals_Click;
            // 
            // btndivide
            // 
            btndivide.BackColor = Color.YellowGreen;
            btndivide.FlatAppearance.BorderColor = Color.OliveDrab;
            btndivide.FlatAppearance.BorderSize = 2;
            btndivide.FlatStyle = FlatStyle.Flat;
            btndivide.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndivide.ForeColor = SystemColors.ButtonHighlight;
            btndivide.Location = new Point(260, 175);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(49, 49);
            btndivide.TabIndex = 11;
            btndivide.Text = "÷";
            btndivide.UseVisualStyleBackColor = false;
            btndivide.Click += btnOprtr_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.BackColor = Color.YellowGreen;
            btnmultiply.FlatAppearance.BorderColor = Color.OliveDrab;
            btnmultiply.FlatAppearance.BorderSize = 2;
            btnmultiply.FlatStyle = FlatStyle.Flat;
            btnmultiply.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnmultiply.ForeColor = SystemColors.ButtonHighlight;
            btnmultiply.Location = new Point(205, 175);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(49, 49);
            btnmultiply.TabIndex = 10;
            btnmultiply.Text = "×";
            btnmultiply.UseVisualStyleBackColor = false;
            btnmultiply.Click += btnOprtr_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Gold;
            btndelete.FlatAppearance.BorderColor = Color.Goldenrod;
            btndelete.FlatAppearance.BorderSize = 2;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(260, 120);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(49, 49);
            btndelete.TabIndex = 30;
            btndelete.Text = "DEL";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.Gold;
            btnclear.FlatAppearance.BorderColor = Color.Goldenrod;
            btnclear.FlatAppearance.BorderSize = 2;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ButtonHighlight;
            btnclear.Location = new Point(205, 120);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(49, 49);
            btnclear.TabIndex = 29;
            btnclear.Text = "C";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click_1;
            // 
            // btn0
            // 
            btn0.BackColor = Color.MistyRose;
            btn0.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn0.ForeColor = Color.DimGray;
            btn0.Location = new Point(91, 285);
            btn0.Name = "btn0";
            btn0.Size = new Size(51, 49);
            btn0.TabIndex = 28;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // btndot
            // 
            btndot.BackColor = Color.Gold;
            btndot.FlatAppearance.BorderColor = Color.Goldenrod;
            btndot.FlatAppearance.BorderSize = 2;
            btndot.FlatStyle = FlatStyle.Flat;
            btndot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndot.ForeColor = SystemColors.ButtonHighlight;
            btndot.Location = new Point(148, 285);
            btndot.Name = "btndot";
            btndot.Size = new Size(51, 49);
            btndot.TabIndex = 27;
            btndot.Text = ".";
            btndot.UseVisualStyleBackColor = false;
            btndot.Click += btndot_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.MistyRose;
            btn9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn9.ForeColor = Color.DimGray;
            btn9.Location = new Point(148, 120);
            btn9.Name = "btn9";
            btn9.Size = new Size(51, 49);
            btn9.TabIndex = 26;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btnNum_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.MistyRose;
            btn8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn8.ForeColor = Color.DimGray;
            btn8.Location = new Point(91, 120);
            btn8.Name = "btn8";
            btn8.Size = new Size(51, 49);
            btn8.TabIndex = 25;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btnNum_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.MistyRose;
            btn7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn7.ForeColor = Color.DimGray;
            btn7.Location = new Point(34, 120);
            btn7.Name = "btn7";
            btn7.Size = new Size(51, 49);
            btn7.TabIndex = 24;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btnNum_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.MistyRose;
            btn6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn6.ForeColor = Color.DimGray;
            btn6.Location = new Point(148, 175);
            btn6.Name = "btn6";
            btn6.Size = new Size(51, 49);
            btn6.TabIndex = 23;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btnNum_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.MistyRose;
            btn5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn5.ForeColor = Color.DimGray;
            btn5.Location = new Point(91, 175);
            btn5.Name = "btn5";
            btn5.Size = new Size(51, 49);
            btn5.TabIndex = 22;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btnNum_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.MistyRose;
            btn4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn4.ForeColor = Color.DimGray;
            btn4.Location = new Point(34, 175);
            btn4.Name = "btn4";
            btn4.Size = new Size(51, 49);
            btn4.TabIndex = 21;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btnNum_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.MistyRose;
            btn3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn3.ForeColor = Color.DimGray;
            btn3.Location = new Point(148, 230);
            btn3.Name = "btn3";
            btn3.Size = new Size(51, 49);
            btn3.TabIndex = 20;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btnNum_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.MistyRose;
            btn2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn2.ForeColor = Color.DimGray;
            btn2.Location = new Point(91, 230);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 49);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // txtPreview
            // 
            txtPreview.BackColor = Color.Salmon;
            txtPreview.BorderStyle = BorderStyle.None;
            txtPreview.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPreview.ForeColor = Color.GhostWhite;
            txtPreview.Location = new Point(12, 32);
            txtPreview.Name = "txtPreview";
            txtPreview.ReadOnly = true;
            txtPreview.Size = new Size(315, 20);
            txtPreview.TabIndex = 31;
            txtPreview.TextAlign = HorizontalAlignment.Right;
            // 
            // btnneg
            // 
            btnneg.BackColor = Color.Gold;
            btnneg.FlatAppearance.BorderColor = Color.Goldenrod;
            btnneg.FlatAppearance.BorderSize = 2;
            btnneg.FlatStyle = FlatStyle.Flat;
            btnneg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnneg.ForeColor = SystemColors.ButtonHighlight;
            btnneg.Location = new Point(34, 285);
            btnneg.Name = "btnneg";
            btnneg.Size = new Size(51, 49);
            btnneg.TabIndex = 32;
            btnneg.Text = "-/+";
            btnneg.UseVisualStyleBackColor = false;
            btnneg.Click += btnneg_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(342, 365);
            Controls.Add(btnneg);
            Controls.Add(txtPreview);
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
            Controls.Add(btnequals);
            Controls.Add(btndivide);
            Controls.Add(btnmultiply);
            Controls.Add(btnminus);
            Controls.Add(btnplus);
            Controls.Add(btn1);
            Controls.Add(txtDisplay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn1;
        private Button btnplus;
        private Button btnminus;
        private Button btnequals;
        private Button btndivide;
        private Button btnmultiply;
        private Button btndelete;
        private Button btnclear;
        private Button btn0;
        private Button btndot;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private TextBox txtPreview;
        private Button btnneg;
    }
}
