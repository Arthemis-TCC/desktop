using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace tcc1
{
    class login : conexao
    {
        private string usuario_l;
        private string senha_l;

        public void setUsuario_l(string usuario_l)
        {
            this.usuario_l = usuario_l;
        }

        public string getUsuario_l()
        {
            return this.usuario_l;
        }

        public void setSenha_l(string senha_l)
        {
            this.senha_l = senha_l;
        }

        public string getSenha_l()
        {
            return this.senha_l;
        }

        public int consultar_login()
        {
            this.abrirconexao();

            string mSQL = "Select count(email) from funcionario where email = '" + getUsuario_l() + "' and senha = '" + getSenha_l() + "'";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultado_query = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();

            int valor_login;
            valor_login = resultado_query;
            this.fecharconexao();
            return valor_login;
        }
    }
}
