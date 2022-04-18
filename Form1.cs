using OOP6.Model;

namespace OOP6
{
    public partial class Form1 : Form
    {
        private Ball _ball;
        private Graphics _graphics;
        private Mover _mover;
        private Drawer _drawer;
        private double _maxValue = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _graphics = pictureBox1.CreateGraphics();

            var point = new Point(this.Width / 2, this.Height / 2);
            var radius = 50;
            _ball = new Ball(radius, point);

            _mover = new Mover(_ball, pictureBox1);

            _drawer = new Drawer(_graphics, _ball);

            SetLabelText();
            timer.Start();
        }

        private void SetLabelText()
        {
            label2.Text += _maxValue;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _mover.Work();
            _drawer.Work();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var numerics = sender as NumericUpDown;
            if (numerics.Value > 10)
            {
                numerics.Value = 10;
            }

            _mover.SetSpeed((int) numerics?.Value);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            _graphics = pictureBox1.CreateGraphics();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            _graphics = pictureBox1.CreateGraphics();
        }
    }
}