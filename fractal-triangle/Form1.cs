namespace fractal_triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateLabel();
        }

        int GlobalMaxDeepth = 4;

        private void CreateFractal(Object sender, PaintEventArgs e)
        {
            int deepth = 0;

            Point point1 = new Point(420, 30);
            Point point2 = new Point(50, 730);
            Point point3 = new Point(750, 730);

            CreateTriangle(sender, e, point1, point2, point3, deepth);
        }

        private void CreateTriangle(Object sender, PaintEventArgs e, Point p1, Point p2, Point p3, int deepth)
        {
            if (deepth >= GlobalMaxDeepth) { return; }
            deepth++;

            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 3);

            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p2, p3);
            g.DrawLine(pen, p3, p1);

            pen.Dispose();

            Point mid1 = new Point((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
            Point mid2 = new Point((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2);
            Point mid3 = new Point((p3.X + p1.X) / 2, (p3.Y + p1.Y) / 2);

            CreateTriangle(sender, e, p1, mid1, mid3, deepth);
            CreateTriangle(sender, e, mid1, p2, mid2, deepth);
            CreateTriangle(sender, e, mid3, mid2, p3, deepth);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            GlobalMaxDeepth++;
            UpdateLabel();
            Invalidate();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (GlobalMaxDeepth > 0)
            {
                GlobalMaxDeepth--;
                UpdateLabel();
                Invalidate();
            }
        }

        private void UpdateLabel()
        {
            labelActualDeepth.Text = GlobalMaxDeepth.ToString();
        }
    }
}
