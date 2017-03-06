using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Shubham Salaria
// Student #: 200333595
// Date: march 5th 2017

namespace COmp1004_Movie_Assignment3
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            SelectionForm select = new SelectionForm();
            select.Show();
            this.Hide();

        }
    }
}
