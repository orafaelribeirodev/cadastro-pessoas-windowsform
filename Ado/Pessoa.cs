using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado
{
    public static class Pessoa
    {
        public static string Salvar(Dominio.Pessoa pessoa)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(Conexao.StringConexao))
            {
                try
                {
                    string sql = "insert into pessoa(pes_nome, pes_nasc, pes_sexo)values(@pes_nome,@pes_nasc,@pes_sexo)";
                    NpgsqlCommand comando = new NpgsqlCommand(sql, connect);
                    comando.Parameters.AddWithValue("@pes_nome", pessoa.pes_nome);
                    comando.Parameters.AddWithValue("@pes_nasc", Convert.ToDateTime(pessoa.pes_nasc));
                    comando.Parameters.AddWithValue("@pes_sexo", pessoa.pes_sexo);
                    connect.Open();
                    comando.ExecuteNonQuery();
                    connect.Close();
                    return "";
                }
                catch (Exception e)
                {
                    connect.Close();
                    return e.Message;
                }
            }
        }

        public static string Editar(Dominio.Pessoa pessoa)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(Conexao.StringConexao))
            {
                try
                {
                    string sql = "update pessoa set pes_nome=@pes_nome, pes_nasc=@pes_nasc, pes_sexo=@pes_sexo where pes_id=@pes_id";
                    NpgsqlCommand comando = new NpgsqlCommand(sql, connect);
                    comando.Parameters.AddWithValue("@pes_id", pessoa.pes_id);
                    comando.Parameters.AddWithValue("@pes_nome", pessoa.pes_nome);
                    comando.Parameters.AddWithValue("@pes_nasc", Convert.ToDateTime(pessoa.pes_nasc));
                    comando.Parameters.AddWithValue("@pes_sexo", pessoa.pes_sexo);
                    connect.Open();
                    comando.ExecuteNonQuery();
                    connect.Close();
                    return "";
                }
                catch (Exception e)
                {
                    connect.Close();
                    return e.Message;
                }
            }
        }


        public static string Excluir(int id)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(Conexao.StringConexao))
            {
                try
                {
                    string sql = "delete from pessoa where pes_id=@pes_id";
                    NpgsqlCommand comando = new NpgsqlCommand(sql, connect);
                    comando.Parameters.AddWithValue("@pes_id", id);
                    connect.Open();
                    comando.ExecuteNonQuery();
                    connect.Close();
                    return "";
                }
                catch (Exception e)
                {
                    connect.Close();
                    return e.Message;
                }
            }
        }


        public static List<Dominio.Pessoa> Carregar(string filtro)
        {
            using (NpgsqlConnection connect = new NpgsqlConnection(Conexao.StringConexao))
            {
                try
                {
                    List<Dominio.Pessoa> lista = new List<Dominio.Pessoa>();
                    string sql = $"select pes_id, pes_nome, to_char(pes_nasc,'dd/MM/yyyy') as pes_nasc, pes_sexo from pessoa {filtro}";
                    NpgsqlCommand comando = new NpgsqlCommand(sql, connect);
                    connect.Open();
                    NpgsqlDataReader read = comando.ExecuteReader();
                    while (read.Read())
                    {
                        Dominio.Pessoa pessoa = new Dominio.Pessoa();
                        pessoa.pes_id = Convert.ToInt32(read["pes_id"].ToString());
                        pessoa.pes_nome = read["pes_nome"].ToString();
                        pessoa.pes_nasc = read["pes_nasc"].ToString();
                        pessoa.pes_sexo = read["pes_sexo"].ToString();
                        lista.Add(pessoa);
                    }
                    read.Close();
                    connect.Close();
                    return lista;
                }
                catch (Exception ex)
                {
                    connect.Close();
                    return null;
                }
            }
        }
    }
}

