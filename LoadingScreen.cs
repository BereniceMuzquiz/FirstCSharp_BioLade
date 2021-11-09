using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatue_Biomarkt_GmbH
{
    public partial class loadingScreen : Form  // Form1 Erb von Klasse Form
    {
        private int loadingBarValue = 0;   //Global

        public loadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            loadingBarTimer.Start();
        }

        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue += 5;

            labelLoadingProgress.Text = loadingBarValue.ToString() + "%";
            loadingProgressBar.Value = loadingBarValue;
            if(loadingBarValue >= loadingProgressBar.Maximum) {
                loadingBarTimer.Stop();
            }
        }
    }
}
