using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_3009230681
{
    public partial class SplashForm : Form
    {
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.pickHighestCardForm;
            }
        }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();

            this.Hide();

            SplashFormTimer.Enabled = false;
        }
    }
}
