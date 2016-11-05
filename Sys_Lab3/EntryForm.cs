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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int sizeX = Convert.ToInt32(textBoxSizeX.Text);
            int sizeY = Convert.ToInt32(textBoxSizeY.Text);
            int preyAmount = Convert.ToInt32(textBoxPreyAmount.Text);
            int preyStart = Convert.ToInt32(textBoxPreyStart.Text);
            int preyPeriod = Convert.ToInt32(textBoxPreyPeriod.Text);
            int predatorAmount = Convert.ToInt32(textBoxPredatorAmount.Text);
            int predatorStart = Convert.ToInt32(textBoxPredatorStart.Text);
            int predatorPeriod = Convert.ToInt32(textBoxPredatorPeriod.Text);
            int predatorStarve = Convert.ToInt32(textBoxPredatorStarve.Text);
            Prey.genStart = preyStart;
            Prey.genPeriod = preyPeriod;
            Predator.genStart = predatorStart;
            Predator.genPeriod = predatorPeriod;
            Predator.starve = predatorStarve;
            PondForm pondForm = new PondForm(sizeX, sizeY, preyAmount, predatorAmount);
            pondForm.Show();
        }
    }
}
