namespace ShapeDrawing
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.circleBtn = new System.Windows.Forms.ToolStripButton();
            this.solidCircleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.squareBtn = new System.Windows.Forms.ToolStripButton();
            this.solidSquareBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rectangleBtn = new System.Windows.Forms.ToolStripButton();
            this.solidRectangleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripSeparator1,
            this.circleBtn,
            this.solidCircleBtn,
            this.toolStripSeparator2,
            this.squareBtn,
            this.solidSquareBtn,
            this.toolStripSeparator3,
            this.rectangleBtn,
            this.solidRectangleBtn,
            this.toolStripSeparator4,
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
            this.rightBtn.BackColor = System.Drawing.SystemColors.Control;
            this.rightBtn.Image = global::ShapeDrawing.Properties.Resources.right_triangle;
            this.rightBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(75, 29);
            this.rightBtn.Text = "R-Tri";
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Image = global::ShapeDrawing.Properties.Resources.left_triangle;
            this.leftBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(72, 29);
            this.leftBtn.Text = "L-Tri";
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // isoscelesBtn
            // 
            this.isoscelesBtn.Image = global::ShapeDrawing.Properties.Resources.isosceles_triangle;
            this.isoscelesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isoscelesBtn.Name = "isoscelesBtn";
            this.isoscelesBtn.Size = new System.Drawing.Size(96, 29);
            this.isoscelesBtn.Text = "Isos-Tri";
            this.isoscelesBtn.Click += new System.EventHandler(this.isoscelesBtn_Click);
            // 
            // equilateralBtn
            // 
            this.equilateralBtn.Image = global::ShapeDrawing.Properties.Resources.equilateral_triangle;
            this.equilateralBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.equilateralBtn.Name = "equilateralBtn";
            this.equilateralBtn.Size = new System.Drawing.Size(102, 29);
            this.equilateralBtn.Text = "Equil-Tri";
            this.equilateralBtn.Click += new System.EventHandler(this.equilateralBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // circleBtn
            // 
            this.circleBtn.Image = global::ShapeDrawing.Properties.Resources.circle;
            this.circleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(82, 29);
            this.circleBtn.Text = "Circle";
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // solidCircleBtn
            // 
            this.solidCircleBtn.Image = global::ShapeDrawing.Properties.Resources.solid_circle;
            this.solidCircleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidCircleBtn.Name = "solidCircleBtn";
            this.solidCircleBtn.Size = new System.Drawing.Size(99, 29);
            this.solidCircleBtn.Text = "S-Circle";
            this.solidCircleBtn.Click += new System.EventHandler(this.solidCircleBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // squareBtn
            // 
            this.squareBtn.Image = global::ShapeDrawing.Properties.Resources.square;
            this.squareBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(95, 29);
            this.squareBtn.Text = "Square";
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // solidSquareBtn
            // 
            this.solidSquareBtn.Image = global::ShapeDrawing.Properties.Resources.solid_square;
            this.solidSquareBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidSquareBtn.Name = "solidSquareBtn";
            this.solidSquareBtn.Size = new System.Drawing.Size(112, 29);
            this.solidSquareBtn.Text = "S-Square";
            this.solidSquareBtn.Click += new System.EventHandler(this.solidSquareBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // rectangleBtn
            // 
            this.rectangleBtn.Image = global::ShapeDrawing.Properties.Resources.rectangle;
            this.rectangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rectangleBtn.Name = "rectangleBtn";
            this.rectangleBtn.Size = new System.Drawing.Size(116, 29);
            this.rectangleBtn.Text = "Rectangle";
            this.rectangleBtn.Click += new System.EventHandler(this.rectangleBtn_Click);
            // 
            // solidRectangleBtn
            // 
            this.solidRectangleBtn.Image = global::ShapeDrawing.Properties.Resources.solid_rectangle;
            this.solidRectangleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.solidRectangleBtn.Name = "solidRectangleBtn";
            this.solidRectangleBtn.Size = new System.Drawing.Size(133, 29);
            this.solidRectangleBtn.Text = "S-Rectangle";
            this.solidRectangleBtn.Click += new System.EventHandler(this.solidRectangleBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 34);
            // 
            // cleanBtn
            // 
            this.cleanBtn.Image = global::ShapeDrawing.Properties.Resources.broom;
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
            this.Text = "Shape Drawing";
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
        private ToolStripButton cleanBtn;
        private ToolStripButton equilateralBtn;
        private ToolStripButton circleBtn;
        private ToolStripButton solidCircleBtn;
        private ToolStripButton rectangleBtn;
        private ToolStripButton squareBtn;
        private ToolStripButton solidSquareBtn;
        private ToolStripButton solidRectangleBtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
    }
}