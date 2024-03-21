namespace Noteapp
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
            Titlebox = new TextBox();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            view = new Button();
            save = new Button();
            SuspendLayout();
            // 
            // Titlebox
            // 
            Titlebox.BackColor = Color.PeachPuff;
            Titlebox.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Titlebox.Location = new Point(33, 49);
            Titlebox.Name = "Titlebox";
            Titlebox.Size = new Size(265, 27);
            Titlebox.TabIndex = 0;
            Titlebox.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PapayaWhip;
            label1.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(247, 101);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter your note :)";
            label1.Click += label1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.PeachPuff;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(33, 139);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(536, 226);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // view
            // 
            view.BackColor = Color.White;
            view.BackgroundImage = Properties.Resources.e4154efc7a9d13c40cdb56ea4d20a83d1;
            view.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            view.ForeColor = SystemColors.ButtonFace;
            view.Location = new Point(33, 387);
            view.Name = "view";
            view.Size = new Size(218, 33);
            view.TabIndex = 3;
            view.Text = "VIEW SAVED NOTES";
            view.UseVisualStyleBackColor = false;
            view.Click += view_Click;
            // 
            // save
            // 
            save.BackColor = Color.White;
            save.BackgroundImage = Properties.Resources.e4154efc7a9d13c40cdb56ea4d20a83d1;
            save.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            save.ForeColor = SystemColors.ButtonFace;
            save.Location = new Point(350, 387);
            save.Name = "save";
            save.Size = new Size(218, 33);
            save.TabIndex = 4;
            save.Text = "SAVE NEW NOTE";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.e4154efc7a9d13c40cdb56ea4d20a83d;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(644, 467);
            Controls.Add(save);
            Controls.Add(view);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(Titlebox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Titlebox;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button view;
        private Button save;
    }
}