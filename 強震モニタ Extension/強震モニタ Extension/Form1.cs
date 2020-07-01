using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class 強震モニタExtension : Form
    {
        public 強震モニタExtension()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            web.Navigate("https://kwatch-24h.net/2moni/2sec_alm_2monitw.html#");
        }
    }
}
