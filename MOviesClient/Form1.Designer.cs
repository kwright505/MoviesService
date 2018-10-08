namespace MoviesClient
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
            this.tbMovieList = new System.Windows.Forms.TextBox();
            this.btGetMovieList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btCreate = new System.Windows.Forms.Button();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMovieList
            // 
            this.tbMovieList.Location = new System.Drawing.Point(18, 12);
            this.tbMovieList.Multiline = true;
            this.tbMovieList.Name = "tbMovieList";
            this.tbMovieList.Size = new System.Drawing.Size(292, 176);
            this.tbMovieList.TabIndex = 1;
            this.tbMovieList.TextChanged += new System.EventHandler(this.tbMovieList_TextChanged);
            // 
            // btGetMovieList
            // 
            this.btGetMovieList.Location = new System.Drawing.Point(67, 329);
            this.btGetMovieList.Name = "btGetMovieList";
            this.btGetMovieList.Size = new System.Drawing.Size(200, 36);
            this.btGetMovieList.TabIndex = 2;
            this.btGetMovieList.Text = "List Movies in DataBase ";
            this.btGetMovieList.UseVisualStyleBackColor = true;
            this.btGetMovieList.Click += new System.EventHandler(this.BtGetMovieList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(49, 7);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(223, 20);
            this.tbTitle.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.btCreate);
            this.panel1.Controls.Add(this.dtpReleaseDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbGenre);
            this.panel1.Controls.Add(this.Genre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Location = new System.Drawing.Point(18, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 129);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(6, 96);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(81, 23);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(190, 96);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(82, 23);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Update ";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(99, 96);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(85, 23);
            this.btCreate.TabIndex = 9;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Location = new System.Drawing.Point(84, 59);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(188, 20);
            this.dtpReleaseDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Release Date ";
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(49, 33);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(223, 20);
            this.tbGenre.TabIndex = 6;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Location = new System.Drawing.Point(3, 37);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(39, 13);
            this.Genre.TabIndex = 5;
            this.Genre.Text = "Genre ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btGetMovieList);
            this.Controls.Add(this.tbMovieList);
            this.Name = "Form1";
            this.Text = "Movies Client";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbMovieList;
        private System.Windows.Forms.Button btGetMovieList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
    }
}

