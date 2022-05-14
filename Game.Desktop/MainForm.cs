// Emre Gülsen
// B211200032
// Bilisim Sistemleri Mühendisligi
// NDP Proje

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Desktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            PlayForm playForm = new PlayForm();
            playForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Controls controls = new Controls();
            controls.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
