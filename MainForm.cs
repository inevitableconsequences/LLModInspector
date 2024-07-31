namespace ModInspector_for_Legacy_Launcher
{
    public partial class MainForm : Form
    {
        private Point _formPos;

        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void minimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void movePanel_MouseDown(object sender, MouseEventArgs e)
        {
            _formPos = new Point(e.X, e.Y);
        }

        private void movePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Left += e.X - _formPos.X;
            Top += e.Y - _formPos.Y;
        }
    }
}
