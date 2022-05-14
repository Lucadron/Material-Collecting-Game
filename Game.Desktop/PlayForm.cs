using System;
using System.Windows.Forms;
using Game.Library.Concrete;

namespace Game.Desktop
{
    public partial class PlayForm : Form
    {
        private readonly Oyun _oyun = new Oyun();

        public PlayForm()
        {
            InitializeComponent();
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    _oyun.Stop();
                    break;
                case Keys.Enter:
                    _oyun.Start();
                    break;
                case Keys.Left:
                    _oyun.MoveCollector(Library.Enum.Direction.Left);
                    break;
                case Keys.Right:
                    _oyun.MoveCollector(Library.Enum.Direction.Right);
                    break;
                case Keys.P:
                    _oyun.Pause();
                    break;
            }
        }
    }
}
