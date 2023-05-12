using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcc1
{
    public partial class frm_check : Form
    {
        public frm_check()
        {
            InitializeComponent();
        }

        private void pct_svn_Click(object sender, EventArgs e)
        {
            frm_svn svn = new frm_svn();
            svn.Show();
        }
    }
}
