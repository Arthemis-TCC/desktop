using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Declarações de biblioteca comunicação com o banco de dados

using MySql.Data; //Biblioteca da conexão SQL
using MySql.Data.MySqlClient; //Biblioteca da conexão SQL

namespace tcc1
{
    class conexao
    {
        //Criação de variavéis
        public MySqlConnection conectar;
        //servidor onde está o banco de dados 
        //local (localhost ou 127.0.0.1) ou nuvem
        public string servidor;
        //database é o nome da base de dados
        public string database;
        //usuario e senha para acesso ao gerenciador de banco de dados (localizado no servidor)
        public string usuario;
        public string senha;

        //Criar construtor

        public conexao()
        {
            inicializar();
        }

        //Criação do método inicializar
        public void inicializar()
        {
            servidor = "127.0.0.1";
            database = "agencia_ambiental";
            usuario = "root";
            senha = "";
            string conexaostring;
            conexaostring = "SERVER= " + servidor + ";" + "DATABASE=" + database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";

            conectar = new MySqlConnection(conexaostring);
        }

        //Criar método de abertura 
        //Bool = duas condições/opções
        public bool abrirconexao()
        {
            //Tratamento de erro - para não ter que inicializar o programa todo novamente
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possível conectar");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário e senha inválidos");
                        break;
                }
                return false;
            }
        }

        public bool fecharconexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}