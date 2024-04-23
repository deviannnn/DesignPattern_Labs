namespace Processing
{
    partial class MainForm
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
            Label label1;
            tbxInput = new TextBox();
            btnStart = new Button();
            progressBar1 = new ProgressBar();
            lblProcess = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 35);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter N";
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(68, 31);
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(267, 23);
            tbxInput.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(341, 31);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(16, 109);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 10);
            progressBar1.TabIndex = 2;
            progressBar1.Visible = false;
            // 
            // lblProcess
            // 
            lblProcess.AutoSize = true;
            lblProcess.Location = new Point(16, 87);
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new Size(67, 15);
            lblProcess.TabIndex = 4;
            lblProcess.Text = "Processing:";
            lblProcess.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 161);
            Controls.Add(lblProcess);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btnStart);
            Controls.Add(tbxInput);
            MaximumSize = new Size(450, 200);
            MinimumSize = new Size(450, 200);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxInput;
        private Button btnStart;
        private ProgressBar progressBar1;
        private Label label1;
        private Label lblProcess;
    }
}