namespace Movies.WinForms
{
    partial class FormPlayers
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
            buttonUpdate = new Button();
            buttonAddPlayer = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxPlayerInfo = new TextBox();
            textBoxPlayerLastName = new TextBox();
            textBoxPlayerName = new TextBox();
            dataGridViewPlayers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(buttonAddPlayer);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(textBoxPlayerInfo);
            splitContainer1.Panel1.Controls.Add(textBoxPlayerLastName);
            splitContainer1.Panel1.Controls.Add(textBoxPlayerName);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewPlayers);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(87, 303);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(147, 31);
            buttonUpdate.TabIndex = 22;
            buttonUpdate.Text = "Oyuncu Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAddPlayer
            // 
            buttonAddPlayer.Location = new Point(87, 259);
            buttonAddPlayer.Name = "buttonAddPlayer";
            buttonAddPlayer.Size = new Size(147, 38);
            buttonAddPlayer.TabIndex = 21;
            buttonAddPlayer.Text = "Oyuncu Ekle";
            buttonAddPlayer.UseVisualStyleBackColor = true;
            buttonAddPlayer.Click += buttonAddPlayer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 212);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 20;
            label3.Text = "Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 158);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 19;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 105);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 18;
            label1.Text = "Ad ";
            // 
            // textBoxPlayerInfo
            // 
            textBoxPlayerInfo.Location = new Point(77, 230);
            textBoxPlayerInfo.Name = "textBoxPlayerInfo";
            textBoxPlayerInfo.Size = new Size(100, 23);
            textBoxPlayerInfo.TabIndex = 17;
            // 
            // textBoxPlayerLastName
            // 
            textBoxPlayerLastName.Location = new Point(77, 176);
            textBoxPlayerLastName.Name = "textBoxPlayerLastName";
            textBoxPlayerLastName.Size = new Size(100, 23);
            textBoxPlayerLastName.TabIndex = 16;
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Location = new Point(77, 123);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(100, 23);
            textBoxPlayerName.TabIndex = 15;
            // 
            // dataGridViewPlayers
            // 
            dataGridViewPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlayers.Dock = DockStyle.Fill;
            dataGridViewPlayers.Location = new Point(0, 0);
            dataGridViewPlayers.Name = "dataGridViewPlayers";
            dataGridViewPlayers.RowTemplate.Height = 25;
            dataGridViewPlayers.Size = new Size(526, 446);
            dataGridViewPlayers.TabIndex = 0;
            // 
            // FormPlayers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "FormPlayers";
            Text = "FormPlayers";
            Load += FormPlayers_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button buttonUpdate;
        private Button buttonAddPlayer;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxPlayerInfo;
        private TextBox textBoxPlayerLastName;
        private TextBox textBoxPlayerName;
        private DataGridView dataGridViewPlayers;
    }
}