using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10_300763479
{
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the SplashScreen load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        /// <summary>
        /// This is the event handler for the tick event of SplashTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }
    }
}
