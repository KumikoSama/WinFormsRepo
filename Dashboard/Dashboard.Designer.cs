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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dbtable = new DataGridView();
            panel1 = new Panel();
            btngoback = new PictureBox();
            label1 = new Label();
            exitappbtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dbtable).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btngoback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).BeginInit();
            SuspendLayout();
            // 
            // dbtable
            // 
            dbtable.AllowUserToAddRows = false;
            dbtable.AllowUserToDeleteRows = false;
            dbtable.AllowUserToResizeColumns = false;
            dbtable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Linen;
            dataGridViewCellStyle1.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkKhaki;
            dbtable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dbtable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dbtable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dbtable.BackgroundColor = Color.Linen;
            dbtable.BorderStyle = BorderStyle.None;
            dbtable.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dbtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Linen;
            dataGridViewCellStyle2.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkKhaki;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dbtable.DefaultCellStyle = dataGridViewCellStyle2;
            dbtable.GridColor = SystemColors.Menu;
            dbtable.Location = new Point(85, 86);
            dbtable.Name = "dbtable";
            dbtable.ReadOnly = true;
            dbtable.Size = new Size(615, 321);
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
            // btngoback
            // 
            btngoback.BackgroundImage = (Image)resources.GetObject("btngoback.BackgroundImage");
            btngoback.BackgroundImageLayout = ImageLayout.Zoom;
            btngoback.Location = new Point(17, 16);
            btngoback.Name = "btngoback";
            btngoback.Size = new Size(29, 28);
            btngoback.TabIndex = 1;
            btngoback.TabStop = false;
            btngoback.Click += btngoback_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(264, 17);
            label1.Name = "label1";
            label1.Size = new Size(231, 28);
            label1.TabIndex = 0;
            label1.Text = "ALL USER INFORMATION";
            // 
            // exitappbtn
            // 
            exitappbtn.BackColor = Color.Transparent;
            exitappbtn.Image = (Image)resources.GetObject("exitappbtn.Image");
            exitappbtn.Location = new Point(758, 17);
            exitappbtn.Name = "exitappbtn";
            exitappbtn.Size = new Size(35, 29);
            exitappbtn.SizeMode = PictureBoxSizeMode.Zoom;
            exitappbtn.TabIndex = 4;
            exitappbtn.TabStop = false;
            exitappbtn.Click += exitappbtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dbtable);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dbtable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btngoback).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitappbtn).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dbtable;
        private Panel panel1;
        private Label label1;
        private PictureBox btngoback;
        private PictureBox exitappbtn;
    }
}