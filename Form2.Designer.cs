namespace Noteapp
{
    partial class Form2
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
            searchbyname = new TextBox();
            dataGridView1 = new DataGridView();
            delete = new Button();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // searchbyname
            // 
            searchbyname.BackColor = Color.LightCoral;
            searchbyname.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchbyname.ForeColor = SystemColors.Menu;
            searchbyname.Location = new Point(32, 36);
            searchbyname.Name = "searchbyname";
            searchbyname.Size = new Size(265, 27);
            searchbyname.TabIndex = 1;
            searchbyname.Text = "Search by title";
            searchbyname.TextChanged += searchbyname_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.MistyRose;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(680, 291);
            dataGridView1.TabIndex = 2;
            // 
            // delete
            // 
            delete.BackColor = Color.White;
            delete.BackgroundImage = Properties.Resources.e4154efc7a9d13c40cdb56ea4d20a83d1;
            delete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            delete.ForeColor = SystemColors.ButtonFace;
            delete.Location = new Point(32, 402);
            delete.Name = "delete";
            delete.Size = new Size(218, 33);
            delete.TabIndex = 4;
            delete.Text = "DELETE NOTE";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // search
            // 
            search.BackColor = Color.White;
            search.BackgroundImage = Properties.Resources.e4154efc7a9d13c40cdb56ea4d20a83d1;
            search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            search.ForeColor = SystemColors.ButtonFace;
            search.Location = new Point(494, 402);
            search.Name = "search";
            search.Size = new Size(218, 33);
            search.TabIndex = 5;
            search.Text = "SEARCH NOTE";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e4154efc7a9d13c40cdb56ea4d20a83d1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 466);
            Controls.Add(search);
            Controls.Add(delete);
            Controls.Add(dataGridView1);
            Controls.Add(searchbyname);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchbyname;
        private DataGridView dataGridView1;
        private Button delete;
        private Button search;
    }
}