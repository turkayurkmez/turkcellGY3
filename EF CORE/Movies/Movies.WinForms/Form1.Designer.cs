namespace Movies.WinForms
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
            buttonGetMovies = new Button();
            listBoxMovies = new ListBox();
            SuspendLayout();
            // 
            // buttonGetMovies
            // 
            buttonGetMovies.Location = new Point(124, 48);
            buttonGetMovies.Name = "buttonGetMovies";
            buttonGetMovies.Size = new Size(75, 23);
            buttonGetMovies.TabIndex = 0;
            buttonGetMovies.Text = "Getir";
            buttonGetMovies.UseVisualStyleBackColor = true;
            buttonGetMovies.Click += buttonGetMovies_Click;
            // 
            // listBoxMovies
            // 
            listBoxMovies.FormattingEnabled = true;
            listBoxMovies.ItemHeight = 15;
            listBoxMovies.Location = new Point(107, 77);
            listBoxMovies.Name = "listBoxMovies";
            listBoxMovies.Size = new Size(120, 94);
            listBoxMovies.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 282);
            Controls.Add(listBoxMovies);
            Controls.Add(buttonGetMovies);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonGetMovies;
        private ListBox listBoxMovies;
    }
}