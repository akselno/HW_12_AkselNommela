namespace EX_01
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Movie_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Liked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button_save = new System.Windows.Forms.Button();
            this.button_choose = new System.Windows.Forms.Button();
            this.textBox_fileName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movie_title,
            this.Sex,
            this.Liked});
            this.dataGridView1.Location = new System.Drawing.Point(52, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // Movie_title
            // 
            this.Movie_title.HeaderText = "Movie title";
            this.Movie_title.MinimumWidth = 6;
            this.Movie_title.Name = "Movie_title";
            this.Movie_title.Width = 125;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Sex";
            this.Sex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Sex.MinimumWidth = 6;
            this.Sex.Name = "Sex";
            this.Sex.Width = 125;
            // 
            // Liked
            // 
            this.Liked.HeaderText = "Liked it?";
            this.Liked.MinimumWidth = 6;
            this.Liked.Name = "Liked";
            this.Liked.Width = 125;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(52, 347);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(153, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save values";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_choose
            // 
            this.button_choose.Location = new System.Drawing.Point(52, 395);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(153, 23);
            this.button_choose.TabIndex = 2;
            this.button_choose.Text = "Choose folder";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // textBox_fileName
            // 
            this.textBox_fileName.Location = new System.Drawing.Point(248, 348);
            this.textBox_fileName.Name = "textBox_fileName";
            this.textBox_fileName.Size = new System.Drawing.Size(290, 22);
            this.textBox_fileName.TabIndex = 3;
            this.textBox_fileName.Text = "Movies";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label_path.Location = new System.Drawing.Point(245, 398);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(117, 16);
            this.label_path.TabIndex = 4;
            this.label_path.Text = "Folder not chosen.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_path);
            this.Controls.Add(this.textBox_fileName);
            this.Controls.Add(this.button_choose);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_title;
        private System.Windows.Forms.DataGridViewComboBoxColumn Sex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Liked;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.TextBox textBox_fileName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label_path;
    }
}

