using OOP6.Model;

namespace OOP6
{
    public partial class Form1 : Form
    {
        private Ball _ball;
        private Graphics _graphics;
        private Mover _mover;
        private Drawer _drawer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _graphics = pictureBox1.CreateGraphics();

            var point = new Point(pictureBox1.Location.X / 2, pictureBox1.Location.Y / 2);
            var radius = 50;

            _ball = new Ball(radius, point);
            _mover = new Mover(_ball, pictureBox1);

            _drawer = new Drawer(_graphics, _ball);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _mover.Work();
            _drawer.Work();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var box = (TextBox)sender;
            try
            {
                var count = Convert.ToInt32(box.Text);
                timer.Interval = (int)Math.Ceiling(100.0 / count);
                timer.Enabled = true;
            }
            catch (Exception)
            {
                timer.Enabled = false;
            }
        }
    }
}