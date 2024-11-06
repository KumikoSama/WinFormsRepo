namespace Dashboard
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dbtable = new DataGridView();
            panel1 = new Panel();
            exitappbtn = new PictureBox();
            btngoback = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btndelete = new Button();
            panel3 = new Panel();
            btnupdate = new Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dbtable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btngoback).BeginInit();
            SuspendLayout();
            // 
            // dbtable
            // 
            dbtable.AllowUserToAddRows = false;
            dbtable.AllowUserToDeleteRows = false;
            dbtable.AllowUserToResizeColumns = false;
            dbtable.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.Linen;
            dataGridViewCellStyle5.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Sienna;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkKhaki;
            dbtable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dbtable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbtable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dbtable.BackgroundColor = Color.Bisque;
            dbtable.BorderStyle = BorderStyle.None;
            dbtable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dbtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Linen;
            dataGridViewCellStyle6.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Sienna;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkKhaki;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dbtable.DefaultCellStyle = dataGridViewCellStyle6;
            dbtable.GridColor = SystemColors.Menu;
            dbtable.Location = new Point(90, 73);
            dbtable.Name = "dbtable";
            dbtable.ReadOnly = true;
            dbtable.Size = new Size(622, 312);
            dbtable.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(exitappbtn);
            panel1.Controls.Add(btngoback);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 54);
            panel1.TabIndex = 1;
            // 
            // exitappbtn
            // 
            exitappbtn.BackColor = Color.Transparent;
            exitappbtn.Image = (Image)resources.GetObject("exitappbtn.Image");
            exitappbtn.Location = new Point(773, 16);
            exitappbtn.Name = "exitappbtn";
            exitappbtn.Size = new Size(20, 22);
            exitappbtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitappbtn.TabIndex = 4;
            exitappbtn.TabStop = false;
            exitappbtn.Click += exitappbtn_Click;
            // 
            // btngoback
            // 
            btngoback.BackgroundImage = (Image)resources.GetObject("btngoback.BackgroundImage");
            btngoback.BackgroundImageLayout = ImageLayout.Zoom;
            btngoback.Location = new Point(17, 16);
            btngoback.Name = "btngoback";
            btngoback.Size = new Size(23, 22);
            btngoback.TabIndex = 1;
            btngoback.TabStop = false;
            btngoback.Click += btngoback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(280, 16);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "ALL USER INFORMATION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 162, 111);
            panel2.Location = new Point(80, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 311);
            panel2.TabIndex = 2;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.Sienna;
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(299, 409);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(89, 29);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete Data";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(121, 73, 51);
            panel3.Location = new Point(294, 409);
            panel3.Name = "panel3";
            panel3.Size = new Size(94, 34);
            panel3.TabIndex = 5;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Sienna;
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = SystemColors.ButtonHighlight;
            btnupdate.Location = new Point(417, 409);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(89, 29);
            btnupdate.TabIndex = 6;
            btnupdate.Text = "Update Data";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(121, 73, 51);
            panel4.Location = new Point(412, 409);
            panel4.Name = "panel4";
            panel4.Size = new Size(94, 34);
            panel4.TabIndex = 7;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 456);
            Controls.Add(btnupdate);
            Controls.Add(panel4);
            Controls.Add(btndelete);
            Controls.Add(panel1);
            Controls.Add(dbtable);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dbtable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)btngoback).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dbtable;
        private Panel panel1;
        private Label label1;
        private PictureBox btngoback;
        private PictureBox exitappbtn;
        private Panel panel2;
        private Button btndelete;
        private Panel panel3;
        private Button btnupdate;
        private Panel panel4;
    }
}