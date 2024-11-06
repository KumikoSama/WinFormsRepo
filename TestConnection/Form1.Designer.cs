namespace TestConnection
{
    partial class Form1
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
            btnTest = new Button();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            cmbTables = new ComboBox();
            cmbDatabases = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(150, 275);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(75, 23);
            btnTest.TabIndex = 0;
            btnTest.Text = "Test";
            btnTest.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(132, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(267, 275);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cmbTables
            // 
            cmbTables.FormattingEnabled = true;
            cmbTables.Location = new Point(90, 47);
            cmbTables.Name = "cmbTables";
            cmbTables.Size = new Size(121, 23);
            cmbTables.TabIndex = 3;
            cmbTables.SelectedIndexChanged += cmbTables_SelectedIndexChanged;
            // 
            // cmbDatabases
            // 
            cmbDatabases.FormattingEnabled = true;
            cmbDatabases.Location = new Point(301, 47);
            cmbDatabases.Name = "cmbDatabases";
            cmbDatabases.Size = new Size(121, 23);
            cmbDatabases.TabIndex = 4;
            cmbDatabases.SelectedIndexChanged += cmbDatabases_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 319);
            Controls.Add(cmbDatabases);
            Controls.Add(cmbTables);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(btnTest);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private ComboBox cmbTables;
        private ComboBox cmbDatabases;
    }
}
