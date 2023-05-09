namespace Movies.WinForms
{
    partial class FormDirectors
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
            splitContainer1 = new SplitContainer();
            buttonAddDirector = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxDirectorInfo = new TextBox();
            textBoxDirectorLastName = new TextBox();
            textBoxDirectorName = new TextBox();
            dataGridView1 = new DataGridView();
            buttonUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonUpdate);
            splitContainer1.Panel1.Controls.Add(buttonAddDirector);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(textBoxDirectorInfo);
            splitContainer1.Panel1.Controls.Add(textBoxDirectorLastName);
            splitContainer1.Panel1.Controls.Add(textBoxDirectorName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(725, 284);
            splitContainer1.SplitterDistance = 241;
            splitContainer1.TabIndex = 0;
            // 
            // buttonAddDirector
            // 
            buttonAddDirector.Location = new Point(67, 195);
            buttonAddDirector.Name = "buttonAddDirector";
            buttonAddDirector.Size = new Size(101, 38);
            buttonAddDirector.TabIndex = 13;
            buttonAddDirector.Text = "Yönetmen Ekle";
            buttonAddDirector.UseVisualStyleBackColor = true;
            buttonAddDirector.Click += buttonAddDirector_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 148);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 12;
            label3.Text = "Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 94);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 41);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 10;
            label1.Text = "Ad ";
            // 
            // textBoxDirectorInfo
            // 
            textBoxDirectorInfo.Location = new Point(57, 166);
            textBoxDirectorInfo.Name = "textBoxDirectorInfo";
            textBoxDirectorInfo.Size = new Size(100, 23);
            textBoxDirectorInfo.TabIndex = 9;
            // 
            // textBoxDirectorLastName
            // 
            textBoxDirectorLastName.Location = new Point(57, 112);
            textBoxDirectorLastName.Name = "textBoxDirectorLastName";
            textBoxDirectorLastName.Size = new Size(100, 23);
            textBoxDirectorLastName.TabIndex = 8;
            // 
            // textBoxDirectorName
            // 
            textBoxDirectorName.Location = new Point(57, 59);
            textBoxDirectorName.Name = "textBoxDirectorName";
            textBoxDirectorName.Size = new Size(100, 23);
            textBoxDirectorName.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(476, 280);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(67, 239);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(101, 38);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Yönetmen Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // FormDirectors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 284);
            Controls.Add(splitContainer1);
            Name = "FormDirectors";
            Text = "FormDirectors";
            Load += FormDirectors_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button buttonAddDirector;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxDirectorInfo;
        private TextBox textBoxDirectorLastName;
        private TextBox textBoxDirectorName;
        private DataGridView dataGridView1;
        private Button buttonUpdate;
    }
}