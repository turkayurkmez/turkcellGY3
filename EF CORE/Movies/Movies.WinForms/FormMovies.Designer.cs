namespace Movies.WinForms
{
    partial class FormMovies
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
            groupBox1 = new GroupBox();
            listBoxPlayers = new ListBox();
            comboBoxDirectors = new ComboBox();
            textBoxTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerPublishDate = new DateTimePicker();
            label3 = new Label();
            textBoxDuration = new TextBox();
            label4 = new Label();
            buttonAdd = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBoxPlayers);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oyuncular";
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.Dock = DockStyle.Fill;
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(3, 19);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.SelectionMode = SelectionMode.MultiSimple;
            listBoxPlayers.Size = new Size(427, 318);
            listBoxPlayers.TabIndex = 0;
            // 
            // comboBoxDirectors
            // 
            comboBoxDirectors.FormattingEnabled = true;
            comboBoxDirectors.Location = new Point(467, 227);
            comboBoxDirectors.Name = "comboBoxDirectors";
            comboBoxDirectors.Size = new Size(249, 23);
            comboBoxDirectors.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(467, 59);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(147, 23);
            textBoxTitle.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(467, 39);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Film Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(467, 90);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Yayın Tarihi";
            // 
            // dateTimePickerPublishDate
            // 
            dateTimePickerPublishDate.CustomFormat = "dd.MM.yyyy";
            dateTimePickerPublishDate.Format = DateTimePickerFormat.Short;
            dateTimePickerPublishDate.Location = new Point(467, 105);
            dateTimePickerPublishDate.Name = "dateTimePickerPublishDate";
            dateTimePickerPublishDate.Size = new Size(200, 23);
            dateTimePickerPublishDate.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 146);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "Duration";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Location = new Point(467, 164);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(147, 23);
            textBoxDuration.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 209);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Yönetmen";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(467, 326);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(177, 23);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Film Ekle";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormMovies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 450);
            Controls.Add(buttonAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDuration);
            Controls.Add(dateTimePickerPublishDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxTitle);
            Controls.Add(comboBoxDirectors);
            Controls.Add(groupBox1);
            Name = "FormMovies";
            Text = "FormMovies";
            Load += FormMovies_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBoxPlayers;
        private ComboBox comboBoxDirectors;
        private TextBox textBoxTitle;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerPublishDate;
        private Label label3;
        private TextBox textBoxDuration;
        private Label label4;
        private Button buttonAdd;
    }
}