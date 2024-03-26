namespace TriangleDrawing
{
    public partial class DrawingForm : Form
    {
        TriangleType type = TriangleType.Right; // Default Triangle
        private bool isDrawing = false;
        private bool drawable = false;
        private Triangle currentTriangle;
        private List<Triangle> triangles = new List<Triangle>();

        public DrawingForm()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                isDrawing = false;
                drawable = false;
                Refresh();
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                if (isDrawing && drawable)
                {
                    isDrawing = false;
                    drawable = false;
                    triangles.Add(currentTriangle);
                    Refresh();
                    return;
                }

                isDrawing = true;
                currentTriangle = TriangleFactory.CreateTriangle(type);
                currentTriangle.A = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && drawable)
            {
                isDrawing = false;
                drawable = false;
                triangles.Add(currentTriangle);
                Refresh();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentTriangle.B = e.Location;
                Refresh();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                currentTriangle.Draw(e);
                int include = 0;

                foreach (var triangle in triangles)
                {
                    if (!triangle.Include(currentTriangle))
                    {
                        include++;
                        triangle.ChangeColor(e);
                    }
                    else
                    {
                        triangle.Draw(e);
                    }
                }

                drawable = include == 0;
                return;
            }

            foreach (var triangle in triangles)
            {
                triangle.Draw(e);
            }
        }

        private void rightBtn_Click(object sender, EventArgs e) => type = TriangleType.Right;
        private void leftBtn_Click(object sender, EventArgs e) => type = TriangleType.Left;
        private void isoscelesBtn_Click(object sender, EventArgs e) => type = TriangleType.Isosceles;
        private void equilateralBtn_Click(object sender, EventArgs e) => type = TriangleType.Equilateral;

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            triangles.Clear();
            Refresh();
        }
    }
}