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
    public partial class frm_svn : Form
    {
        public frm_svn()
        {
            InitializeComponent();
        }

        svn_engenhiro s = new svn_engenhiro();

        private void frm_svn_Load(object sender, EventArgs e)
        {
            dgv_svn.DataSource = s.Consultar();
        }

        private void dgv_svn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
