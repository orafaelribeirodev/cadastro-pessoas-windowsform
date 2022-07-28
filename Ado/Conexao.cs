using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado
{
    public static class Conexao
    {
        public static string StringConexao = "User ID=postgres;Password=101288;Host=localhost;Port=5432;Database=projeto01;";
        private static NpgsqlConnection? connect;

        /// <summary>
        /// Conecta no banco de dados
        /// </summary>
        /// <returns></returns>
        public static string Conectar()
        {
            connect = new NpgsqlConnection(StringConexao);
            return ValidarConexao();
        }

        /// <summary>
        /// Valida a conexão
        /// </summary>
        /// <returns></returns>
        private static string ValidarConexao()
        {
            try
            {
                //Abre a conexão
                connect.Open();
                //Se a conexão estiver aberta
                if (connect.State == System.Data.ConnectionState.Open)
                {
                    //Fecha a conexão
                    connect.Close();
                    return "";
                }
                return "Não foi possível conectar ao banco de dados.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
