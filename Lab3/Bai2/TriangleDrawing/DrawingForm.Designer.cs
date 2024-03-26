namespace TriangleDrawing
{
    partial class DrawingForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rightBtn = new System.Windows.Forms.ToolStripButton();
            this.leftBtn = new System.Windows.Forms.ToolStripButton();
            this.isoscelesBtn = new System.Windows.Forms.ToolStripButton();
            this.equilateralBtn = new System.Windows.Forms.ToolStripButton();
            this.cleanBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightBtn,
            this.leftBtn,
            this.isoscelesBtn,
            this.equilateralBtn,
            this.cleanBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1143, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rightBtn
            // 
            this.rightBtn.Image = global::TriangleDrawing.Properties.Resources.right_triangle;
            this.rightBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(147, 29);
            this.rightBtn.Text = "Right Triangle";
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Image = global::TriangleDrawing.Properties.Resources.left_triangle;
            this.leftBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(134, 29);
            this.leftBtn.Text = "Left Triangle";
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // isoscelesBtn
            // 
            this.isoscelesBtn.Image = global::TriangleDrawing.Properties.Resources.isosceles_triangle;
            this.isoscelesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isoscelesBtn.Name = "isoscelesBtn";
            this.isoscelesBtn.Size = new System.Drawing.Size(175, 29);
            this.isoscelesBtn.Text = "Isosceles Triangle";
            this.isoscelesBtn.Click += new System.EventHandler(this.isoscelesBtn_Click);
            // 
            // equilateralBtn
            // 
            this.equilateralBtn.Image = global::TriangleDrawing.Properties.Resources.equilateral_triangle;
            this.equilateralBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.equilateralBtn.Name = "equilateralBtn";
            this.equilateralBtn.Size = new System.Drawing.Size(186, 29);
            this.equilateralBtn.Text = "Equilateral Triangle";
            this.equilateralBtn.Click += new System.EventHandler(this.equilateralBtn_Click);
            // 
            // cleanBtn
            // 
            this.cleanBtn.Image = global::TriangleDrawing.Properties.Resources.broom;
            this.cleanBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cleanBtn.Name = "cleanBtn";
            this.cleanBtn.Size = new System.Drawing.Size(83, 29);
            this.cleanBtn.Text = "Clean";
            this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
            // 
            // DrawingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DrawingForm";
            this.Text = "Triangle Drawing";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton rightBtn;
        private ToolStripButton leftBtn;
        private ToolStripButton isoscelesBtn;
        private ToolStripButton equilateralBtn;
        private ToolStripButton cleanBtn;
    }
}