namespace fractal_triangle
{
    public partial class Form1 : Form
    {
        int GlobalMaxDepth;
        string GlobalOption;

        public Form1()
        {
            InitializeComponent();
            GlobalMaxDepth = 3;
            UpdateLabel();
        }

        private void CreateFractal(Object sender, PaintEventArgs e)
        {
            int depth = 0;

            if (GlobalOption == "triangle")
            {
                Point point1 = new Point(420, 120);
                Point point2 = new Point(50, 820);
                Point point3 = new Point(750, 820);

                CreateTriangle(sender, e, point1, point2, point3, depth);
            }
            if (GlobalOption == "carpet")
            {
                Point topLeft = new Point(10, 120);
                Point bottomRight = new Point(750, 860);

                CreateCarpet(sender, e, topLeft, bottomRight, depth);
            }
        }

        private void CreateTriangle(Object sender, PaintEventArgs e, Point p1, Point p2, Point p3, int depth)
        {
            if (depth >= GlobalMaxDepth) { return; }
            depth++;

            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 2);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p3, p1);

            pen.Dispose();

            Point mid1 = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
            Point mid2 = new Point((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2);
            Point mid3 = new Point((p3.X + p1.X) / 2, (p3.Y + p1.Y) / 2);

            CreateTriangle(sender, e, p1, mid1, mid3, depth);
            CreateTriangle(sender, e, mid1, p2, mid2, depth);
            CreateTriangle(sender, e, mid3, mid2, p3, depth);
        }

        private void CreateCarpet(Object sender, PaintEventArgs e, Point topLeft, Point bottomRight, int depth)
        {
            if (depth >= GlobalMaxDepth) { return; }
            depth++;

            Graphics g = e.Graphics;

            int width = (bottomRight.X - topLeft.X) / 3;
            int height = (bottomRight.Y - topLeft.Y) / 3;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 1 && j == 1)
                    {
                        SolidBrush brush1 = new SolidBrush(Color.White);
                        g.FillRectangle(brush1, topLeft.X + i * width, topLeft.Y + j * height, width, height);
                        brush1.Dispose();
                        continue;
                    }

                    SolidBrush brush = new SolidBrush(Color.Black);
                    g.FillRectangle(brush, topLeft.X + i * width, topLeft.Y + j * height, width, height);
                    brush.Dispose();

                    Point newTopLeft = new Point(topLeft.X + i * width, topLeft.Y + j * height);
                    Point newBottomRight = new Point(topLeft.X + (i + 1) * width, topLeft.Y + (j + 1) * height);

                    CreateCarpet(sender, e, newTopLeft, newBottomRight, depth);
                }
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            GlobalOption = "triangle";
            Invalidate();
        }

        private void btnCarpet_Click(object sender, EventArgs e)
        {
            GlobalOption = "carpet";
            Invalidate();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            GlobalMaxDepth++;
            UpdateLabel();
            Invalidate();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (GlobalMaxDepth > 0)
            {
                GlobalMaxDepth--;
                UpdateLabel();
                Invalidate();
            }
        }

        private void UpdateLabel()
        {
            labelActualDeepth.Text = GlobalMaxDepth.ToString();
        }
    }
}
