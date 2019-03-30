using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eassistant.Modules
{
    public partial class Index : UserControl
    {
        public Index()
        {
            InitializeComponent();
            labelTime.Text = DateTime.Now.ToShortTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToShortTimeString();
            labelDate.Text = DateTime.Now.ToShortDateString();
        }
    }
}
