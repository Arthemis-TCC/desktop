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
    class svn_engenhiro : conexao
    {
        private string cidade;
        private string status_svn;
        private string data_svn;
      

        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }

        public string getCidade()
        {
            return this.cidade;
        }

        public void setStatus_svn(string status_svn)
        {
            this.status_svn = status_svn;
        }

        public string getStatus_svn()
        {
            return this.status_svn;
        }

        public void setData_svn(string data_svn)
        {
             this.data_svn = data_svn;
        }

        public string getData_svn()
        {
            return this.data_svn;
        }

        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from svn_engenheiro";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
