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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.MistyRose;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Enabled = false;
            txtDisplay.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.ForeColor = Color.DimGray;
            txtDisplay.Location = new Point(28, 53);
            txtDisplay.MaxLength = 14;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.PlaceholderText = "0";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(283, 43);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = Color.MistyRose;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn1.ForeColor = Color.Gray;
            btn1.Location = new Point(34, 238);
            btn1.Name = "btn1";
            btn1.Size = new Size(51, 49);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btnNum_Click;
            // 
            // btnplus
            // 
            btnplus.BackColor = Color.DarkKhaki;
            btnplus.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnplus.FlatAppearance.BorderSize = 0;
            btnplus.FlatStyle = FlatStyle.Flat;
            btnplus.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnplus.ForeColor = SystemColors.Info;
            btnplus.Location = new Point(205, 293);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(49, 49);
            btnplus.TabIndex = 8;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = false;
            btnplus.Click += btnOprtr_Click;
            // 
            // btnminus
            // 
            btnminus.BackColor = Color.DarkKhaki;
            btnminus.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnminus.FlatAppearance.BorderSize = 0;
            btnminus.FlatStyle = FlatStyle.Flat;
            btnminus.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnminus.ForeColor = SystemColors.Info;
            btnminus.Location = new Point(205, 238);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(49, 49);
            btnminus.TabIndex = 9;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = false;
            btnminus.Click += btnOprtr_Click;
            // 
            // btnequals
            // 
            btnequals.BackColor = Color.DarkKhaki;
            btnequals.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnequals.FlatAppearance.BorderSize = 0;
            btnequals.FlatStyle = FlatStyle.Flat;
            btnequals.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnequals.ForeColor = SystemColors.Info;
            btnequals.Location = new Point(260, 238);
            btnequals.Name = "btnequals";
            btnequals.Size = new Size(49, 104);
            btnequals.TabIndex = 12;
            btnequals.Text = "=";
            btnequals.UseVisualStyleBackColor = false;
            btnequals.Click += btnequals_Click;
            // 
            // btndivide
            // 
            btndivide.BackColor = Color.DarkKhaki;
            btndivide.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btndivide.FlatAppearance.BorderSize = 0;
            btndivide.FlatStyle = FlatStyle.Flat;
            btndivide.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btndivide.ForeColor = SystemColors.Info;
            btndivide.Location = new Point(260, 183);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(49, 49);
            btndivide.TabIndex = 11;
            btndivide.Text = "÷";
            btndivide.UseVisualStyleBackColor = false;
            btndivide.Click += btnOprtr_Click;
            // 
            // btnmultiply
            // 
            btnmultiply.BackColor = Color.DarkKhaki;
            btnmultiply.FlatAppearance.BorderColor = SystemColors.ControlDarkDark;
            btnmultiply.FlatAppearance.BorderSize = 0;
            btnmultiply.FlatStyle = FlatStyle.Flat;
            btnmultiply.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnmultiply.ForeColor = SystemColors.Info;
            btnmultiply.Location = new Point(205, 183);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(49, 49);
            btnmultiply.TabIndex = 10;
            btnmultiply.Text = "×";
            btnmultiply.UseVisualStyleBackColor = false;
            btnmultiply.Click += btnOprtr_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.DarkSeaGreen;
            btndelete.FlatAppearance.BorderColor = Color.SeaGreen;
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(260, 128);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(49, 49);
            btndelete.TabIndex = 30;
            btndelete.Text = "DEL";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.DarkSeaGreen;
            btnclear.FlatAppearance.BorderColor = Color.SeaGreen;
            btnclear.FlatAppearance.BorderSize = 0;
            btnclear.FlatStyle = FlatStyle.Flat;
            btnclear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnclear.ForeColor = SystemColors.ButtonHighlight;
            btnclear.Location = new Point(205, 128);
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
            btn0.FlatAppearance.BorderSize = 0;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn0.ForeColor = Color.Gray;
            btn0.Location = new Point(91, 293);
            btn0.Name = "btn0";
            btn0.Size = new Size(51, 49);
            btn0.TabIndex = 28;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btnNum_Click;
            // 
            // btndot
            // 
            btndot.BackColor = Color.DarkSeaGreen;
            btndot.FlatAppearance.BorderColor = Color.SeaGreen;
            btndot.FlatAppearance.BorderSize = 0;
            btndot.FlatStyle = FlatStyle.Flat;
            btndot.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btndot.ForeColor = SystemColors.ButtonHighlight;
            btndot.Location = new Point(148, 293);
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
            btn9.FlatAppearance.BorderSize = 0;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn9.ForeColor = Color.Gray;
            btn9.Location = new Point(148, 128);
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
            btn8.FlatAppearance.BorderSize = 0;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn8.ForeColor = Color.Gray;
            btn8.Location = new Point(91, 128);
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
            btn7.FlatAppearance.BorderSize = 0;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn7.ForeColor = Color.Gray;
            btn7.Location = new Point(34, 128);
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
            btn6.FlatAppearance.BorderSize = 0;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn6.ForeColor = Color.Gray;
            btn6.Location = new Point(148, 183);
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
            btn5.FlatAppearance.BorderSize = 0;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn5.ForeColor = Color.Gray;
            btn5.Location = new Point(91, 183);
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
            btn4.FlatAppearance.BorderSize = 0;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn4.ForeColor = Color.Gray;
            btn4.Location = new Point(34, 183);
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
            btn3.FlatAppearance.BorderSize = 0;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn3.ForeColor = Color.Gray;
            btn3.Location = new Point(148, 238);
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
            btn2.FlatAppearance.BorderSize = 0;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btn2.ForeColor = Color.Gray;
            btn2.Location = new Point(91, 238);
            btn2.Name = "btn2";
            btn2.Size = new Size(51, 49);
            btn2.TabIndex = 19;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btnNum_Click;
            // 
            // txtPreview
            // 
            txtPreview.BackColor = Color.MistyRose;
            txtPreview.BorderStyle = BorderStyle.None;
            txtPreview.Enabled = false;
            txtPreview.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPreview.ForeColor = SystemColors.ControlDarkDark;
            txtPreview.Location = new Point(28, 30);
            txtPreview.Name = "txtPreview";
            txtPreview.ReadOnly = true;
            txtPreview.Size = new Size(283, 20);
            txtPreview.TabIndex = 31;
            txtPreview.TextAlign = HorizontalAlignment.Right;
            // 
            // btnneg
            // 
            btnneg.BackColor = Color.DarkSeaGreen;
            btnneg.FlatAppearance.BorderColor = Color.SeaGreen;
            btnneg.FlatAppearance.BorderSize = 0;
            btnneg.FlatStyle = FlatStyle.Flat;
            btnneg.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnneg.ForeColor = SystemColors.ButtonHighlight;
            btnneg.Location = new Point(34, 293);
            btnneg.Name = "btnneg";
            btnneg.Size = new Size(51, 49);
            btnneg.TabIndex = 32;
            btnneg.Text = "-/+";
            btnneg.UseVisualStyleBackColor = false;
            btnneg.Click += btnneg_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Location = new Point(12, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(318, 90);
            panel1.TabIndex = 33;
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
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
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
        private Panel panel1;
    }
}
