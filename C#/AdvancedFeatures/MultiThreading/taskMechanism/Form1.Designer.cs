namespace taskMechanism
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
            progressBar2 = new ProgressBar();
            buttonTest = new Button();
            labelCounter = new Label();
            buttonCounter = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(305, 252);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(218, 23);
            progressBar2.TabIndex = 8;
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(477, 172);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(75, 23);
            buttonTest.TabIndex = 7;
            buttonTest.Text = "Göster";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // labelCounter
            // 
            labelCounter.AutoSize = true;
            labelCounter.Location = new Point(372, 211);
            labelCounter.Name = "labelCounter";
            labelCounter.Size = new Size(0, 15);
            labelCounter.TabIndex = 6;
            // 
            // buttonCounter
            // 
            buttonCounter.Location = new Point(285, 170);
            buttonCounter.Name = "buttonCounter";
            buttonCounter.Size = new Size(155, 23);
            buttonCounter.TabIndex = 5;
            buttonCounter.Text = "Sayacı başlat";
            buttonCounter.UseVisualStyleBackColor = true;
            buttonCounter.Click += buttonCounter_Click;
            // 
            // button1
            // 
            button1.Location = new Point(612, 174);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(620, 219);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
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

        private ProgressBar progressBar2;
        private Button buttonTest;
        private Label labelCounter;
        private Button buttonCounter;
        private Button button1;
        private Label label1;
    }
}