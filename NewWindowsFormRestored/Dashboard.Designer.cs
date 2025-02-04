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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dbtable = new DataGridView();
            panel1 = new Panel();
            exitappbtn = new PictureBox();
            label1 = new Label();
            btngoback = new PictureBox();
            panel2 = new Panel();
            btnaddnew = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            searchbox = new TextBox();
            btnsearch = new Button();
            btnrefresh = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dbtable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btngoback).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnrefresh).BeginInit();
            SuspendLayout();
            // 
            // dbtable
            // 
            dbtable.AllowUserToAddRows = false;
            dbtable.AllowUserToDeleteRows = false;
            dbtable.AllowUserToResizeColumns = false;
            dbtable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.Linen;
            dataGridViewCellStyle3.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Sienna;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkKhaki;
            dbtable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dbtable.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dbtable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbtable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dbtable.BackgroundColor = Color.Bisque;
            dbtable.BorderStyle = BorderStyle.Fixed3D;
            dbtable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dbtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Linen;
            dataGridViewCellStyle4.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Sienna;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkKhaki;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dbtable.DefaultCellStyle = dataGridViewCellStyle4;
            dbtable.GridColor = SystemColors.Menu;
            dbtable.Location = new Point(128, 100);
            dbtable.Name = "dbtable";
            dbtable.ReadOnly = true;
            dbtable.Size = new Size(626, 327);
            dbtable.TabIndex = 0;
            dbtable.CellContentClick += dbtable_CellContentClick;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(exitappbtn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 54);
            panel1.TabIndex = 1;
            // 
            // exitappbtn
            // 
            exitappbtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exitappbtn.BackColor = Color.Transparent;
            exitappbtn.Image = (Image)resources.GetObject("exitappbtn.Image");
            exitappbtn.Location = new Point(770, 16);
            exitappbtn.Name = "exitappbtn";
            exitappbtn.Size = new Size(23, 22);
            exitappbtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitappbtn.TabIndex = 4;
            exitappbtn.TabStop = false;
            exitappbtn.Click += exitappbtn_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(311, 16);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "ALL USER INFORMATION";
            // 
            // btngoback
            // 
            btngoback.BackgroundImage = (Image)resources.GetObject("btngoback.BackgroundImage");
            btngoback.BackgroundImageLayout = ImageLayout.Zoom;
            btngoback.Image = (Image)resources.GetObject("btngoback.Image");
            btngoback.Location = new Point(12, 13);
            btngoback.Name = "btngoback";
            btngoback.Size = new Size(23, 22);
            btngoback.SizeMode = PictureBoxSizeMode.Zoom;
            btngoback.TabIndex = 1;
            btngoback.TabStop = false;
            btngoback.Click += btngoback_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(164, 113, 72);
            panel2.Controls.Add(btngoback);
            panel2.Controls.Add(btnaddnew);
            panel2.Controls.Add(btndelete);
            panel2.Controls.Add(btnupdate);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(84, 462);
            panel2.TabIndex = 2;
            // 
            // btnaddnew
            // 
            btnaddnew.BackColor = Color.FromArgb(164, 113, 72);
            btnaddnew.FlatAppearance.BorderSize = 0;
            btnaddnew.FlatStyle = FlatStyle.Flat;
            btnaddnew.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnaddnew.ForeColor = SystemColors.ButtonHighlight;
            btnaddnew.Location = new Point(0, 179);
            btnaddnew.Name = "btnaddnew";
            btnaddnew.Size = new Size(84, 29);
            btnaddnew.TabIndex = 8;
            btnaddnew.Text = "Add Data";
            btnaddnew.UseVisualStyleBackColor = false;
            btnaddnew.Click += btnaddnew_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(164, 113, 72);
            btndelete.FlatAppearance.BorderSize = 0;
            btndelete.FlatStyle = FlatStyle.Flat;
            btndelete.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndelete.ForeColor = SystemColors.ButtonHighlight;
            btndelete.Location = new Point(0, 99);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(84, 29);
            btndelete.TabIndex = 3;
            btndelete.Text = "Delete Data";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(164, 113, 72);
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnupdate.ForeColor = SystemColors.ButtonHighlight;
            btnupdate.Location = new Point(0, 140);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(84, 29);
            btnupdate.TabIndex = 6;
            btnupdate.Text = "Update Data";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(156, 102, 68);
            panel3.Location = new Point(0, 179);
            panel3.Name = "panel3";
            panel3.Size = new Size(84, 33);
            panel3.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(156, 102, 68);
            panel4.Location = new Point(0, 140);
            panel4.Name = "panel4";
            panel4.Size = new Size(84, 33);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(156, 102, 68);
            panel5.Location = new Point(0, 99);
            panel5.Name = "panel5";
            panel5.Size = new Size(84, 33);
            panel5.TabIndex = 11;
            // 
            // searchbox
            // 
            searchbox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            searchbox.BackColor = Color.SeaShell;
            searchbox.BorderStyle = BorderStyle.None;
            searchbox.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbox.Location = new Point(128, 70);
            searchbox.Name = "searchbox";
            searchbox.Size = new Size(529, 21);
            searchbox.TabIndex = 3;
            searchbox.TextChanged += searchbox_TextChanged;
            // 
            // btnsearch
            // 
            btnsearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnsearch.BackColor = Color.FromArgb(164, 113, 72);
            btnsearch.FlatAppearance.BorderSize = 0;
            btnsearch.FlatStyle = FlatStyle.Flat;
            btnsearch.Font = new Font("Sitka Text", 8.25F, FontStyle.Bold);
            btnsearch.ForeColor = SystemColors.ButtonHighlight;
            btnsearch.Location = new Point(663, 70);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(59, 21);
            btnsearch.TabIndex = 9;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnrefresh.BackColor = Color.Transparent;
            btnrefresh.Image = (Image)resources.GetObject("btnrefresh.Image");
            btnrefresh.Location = new Point(728, 70);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(26, 21);
            btnrefresh.SizeMode = PictureBoxSizeMode.Zoom;
            btnrefresh.TabIndex = 10;
            btnrefresh.TabStop = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 456);
            Controls.Add(btnrefresh);
            Controls.Add(btnsearch);
            Controls.Add(searchbox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dbtable);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                              ";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dbtable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)btngoback).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnrefresh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dbtable;
        private Panel panel1;
        private Label label1;
        private PictureBox btngoback;
        private PictureBox exitappbtn;
        private Panel panel2;
        private Button btndelete;
        private Button btnupdate;
        private Button btnaddnew;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox searchbox;
        private Button btnsearch;
        private PictureBox btnrefresh;
    }
}