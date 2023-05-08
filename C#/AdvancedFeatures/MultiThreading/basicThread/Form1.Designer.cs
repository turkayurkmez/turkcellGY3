namespace basicThread
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
            buttonCounter = new Button();
            labelCounter = new Label();
            buttonTest = new Button();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // buttonCounter
            // 
            buttonCounter.Location = new Point(141, 71);
            buttonCounter.Name = "buttonCounter";
            buttonCounter.Size = new Size(155, 23);
            buttonCounter.TabIndex = 0;
            buttonCounter.Text = "Sayacı başlat";
            buttonCounter.UseVisualStyleBackColor = true;
            buttonCounter.Click += buttonCounter_Click;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(228, 112);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(0, 15);
            labelCounter.TabIndex = 1;
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(333, 73);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(75, 23);
            buttonTest.TabIndex = 2;
            buttonTest.Text = "Göster";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(105, 158);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(218, 23);
            progressBar2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 310);
            Controls.Add(progressBar2);
            Controls.Add(buttonTest);
            Controls.Add(labelCounter);
            Controls.Add(buttonCounter);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCounter;
        private Label labelCounter;
        private Button buttonTest;
        private ProgressBar progressBar2;
    }
}