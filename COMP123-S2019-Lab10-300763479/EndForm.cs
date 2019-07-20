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
    public partial class EndForm : Form
    {
        public EndForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the BackButton click event. EndForm disappear and MainForm appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
           Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();
        }
        private void EndForm_Load(object sender, EventArgs e)
        {

        }

    }
}
