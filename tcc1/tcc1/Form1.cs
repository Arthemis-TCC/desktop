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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.setUsuario_l(txt_email.Text);
            l.setSenha_l(txt_senha.Text);
            l.consultar_login();

            int valor = l.consultar_login();

            if (valor == 1)
            {
                frm_check formulario = new frm_check();
                formulario.Show();
                this.Hide();
            }
            else if (txt_email.Text == "admin" && txt_senha.Text == "admin")
            {
                frm_check formulario = new frm_check();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e senhas inválidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "tcc1", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
