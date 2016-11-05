using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sys_Lab3
{
    public partial class PondForm : Form
    {
        private ModellingClass modellingObject;
        private int sizeX;
        private int sizeY;

        public PondForm(int sizeX, int sizeY, int preyAmount, int predatorAmount)
        {
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            modellingObject = new ModellingClass(sizeX, sizeY, preyAmount, predatorAmount);
            InitializeComponent();
        }

        private void PondForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Math.Max(530, 40 + 4 * sizeX), 180 + 4 * sizeY);
            pictureBoxPond.Size = new Size(4 * sizeX, 4 * sizeY);
            trackBarSpeed.Minimum = 10;
            trackBarSpeed.Maximum = 500;
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            if (buttonStartPause.Text == "Старт")
            {
                buttonStartPause.Text = "Пауза";
                buttonStep.Enabled = false;
                buttonStats.Enabled = false;
                timer1.Interval = trackBarSpeed.Value;
                trackBarSpeed.Enabled = false;
                timer1.Start();
            }
            else
            {
                buttonStartPause.Text = "Старт";
                buttonStep.Enabled = true;
                buttonStats.Enabled = true;
                trackBarSpeed.Enabled = true;
                timer1.Stop();
            }
        }

        private void buttonStep_Click(object sender, EventArgs e)
        {

        }
    }
}
