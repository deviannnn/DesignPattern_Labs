﻿namespace ShapeDrawingAdvance
{
    public partial class DrawingForm : Form
    {
        ShapeType type = ShapeType.RightTri; // Default Triangle
        private bool isDrawing = false;
        private ToolStripButton? currentPaintActive;
        private Shape? currentShape;
        private ILineBehavior line = new SolidLine();
        private IPaintBehavior paint = new EmptyPaint();
        private List<Shape> shapes = new List<Shape>();

        public DrawingForm()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                isDrawing = false;
                Refresh();
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                for (int i = shapes.Count - 1; i >= 0; i--)
                {
                    var shape = shapes[i];

                    if (shape.Include(e.Location))
                    {
                        shape.Color = Color.Red;
                        foreach (var otherShape in shapes.Where(s => s != shape))
                        {
                            otherShape.Color = Color.Black;
                        }
                        Refresh();
                        return;
                    }
                }

                var coloredShape = shapes.FirstOrDefault(shape => shape.Color == Color.Red);
                if (coloredShape != null)
                {
                    coloredShape.Color = Color.Black;
                    Refresh();
                }

                isDrawing = true;
                currentShape = ShapeFactory.CreateShape(type);
                currentShape.SetLineBehavior(line);
                currentShape.SetPaintBehavior(paint);
                currentShape.A = currentShape.B = e.Location;
                shapes.Add(currentShape);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                shapes[shapes.Count - 1].B = e.Location;
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void CleanShapeActive()
        {
            rightBtn.BackColor = Color.White;
            leftBtn.BackColor = Color.White;
            isoscelesBtn.BackColor = Color.White;
            equilateralBtn.BackColor = Color.White;
            circleBtn.BackColor = Color.White;
            solidCircleBtn.BackColor = Color.White;
            squareBtn.BackColor = Color.White;
            solidSquareBtn.BackColor = Color.White;
            rectangleBtn.BackColor = Color.White;
            solidRectangleBtn.BackColor = Color.White;
        }

        private void ShapeTypeButtonClick(object sender, EventArgs e, ShapeType shapeType)
        {
            type = shapeType;
            CleanShapeActive();
            ((ToolStripButton)sender).BackColor = Color.Pink;
        }

        private void rightBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.RightTri);
        
        private void leftBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.LeftTri);
        
        private void isoscelesBtn_Click(object sender, EventArgs e) => 
            ShapeTypeButtonClick(sender, e, ShapeType.IsoscelesTri);

        private void equilateralBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.EquilateralTri);

        private void circleBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.Circle);

        private void solidCircleBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.SolidCircle);

        private void squareBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.Square);

        private void solidSquareBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.SolidSquare);

        private void solidRectangleBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.SolidRectangle);

        private void rectangleBtn_Click(object sender, EventArgs e) =>
            ShapeTypeButtonClick(sender, e, ShapeType.Rectangle);

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            CleanShapeActive();
            Refresh();
        }

        private void CleanPaintActive()
        {
            greenPaintBtn.BackColor = Color.White;
            orangePaintBtn.BackColor = Color.White;
        }

        private void PaintButtonClick(object sender, EventArgs e, Color color)
        {
            CleanPaintActive();
            if (((ToolStripButton)sender) == currentPaintActive)
            {
                paint = new EmptyPaint();
                currentPaintActive = null;
            }
            else
            {
                paint = new ColorPaint(color);
                ((ToolStripButton)sender).BackColor = Color.Pink;
                currentPaintActive = ((ToolStripButton)sender);
            }
        }

        private void solidBtn_Click(object sender, EventArgs e)
        {
            line = new SolidLine();
            solidBtn.BackColor = Color.Pink;
            dashBtn.BackColor = Color.White;
        }

        private void dashBtn_Click(object sender, EventArgs e)
        {
            line = new DashLine();
            dashBtn.BackColor = Color.Pink;
            solidBtn.BackColor = Color.White;
        }

        private void greenPaintBtn_Click(object sender, EventArgs e)
        {
            PaintButtonClick(sender, e, Color.Green);
        }

        private void orangePaintBtn_Click(object sender, EventArgs e)
        {
            PaintButtonClick(sender, e, Color.Orange);
        }
    }
}