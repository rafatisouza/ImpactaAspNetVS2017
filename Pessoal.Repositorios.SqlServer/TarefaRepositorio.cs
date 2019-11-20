using Microsoft.Data.SqlClient;
using Pessoal.Dominio.Entidades;
using Pessoal.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace Pessoal.Repositorios.SqlServer
{
    public class TarefaRepositorio : ITarefaRepositorio
    {
        private string stringConexao;

        public TarefaRepositorio(string stringConexao)
        {
            this.stringConexao = stringConexao;
        }

        public void Atualizar(Tarefa tarefa)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("TarefaAtualizar", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddRange(Mapear(tarefa).ToArray());

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("TareDeletar", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id", id);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public int Inserir(Tarefa tarefa)
        {
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("TarefaInserir", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddRange(Mapear(tarefa).ToArray());

                    return (int)comando.ExecuteScalar();
                }
            }
        }
      
        public List<Tarefa> Selecionar()
        {

            using (var conexao = new SqlConnection(stringConexao)) {
                conexao.Open();
                using(var comando = new SqlCommand("TarefaSelecionar", conexao))
                {
                    var tarefas = new List <Tarefa> ();
                    comando.CommandType = CommandType.StoredProcedure;
                    using (var registro = comando.ExecuteReader())
                    {
                        while (registro.Read())
                        {
                            tarefas.Add(Mapear(registro));

                        }
                    }
                                        
                    return tarefas;

                }
            }
        }

        private Tarefa Mapear(SqlDataReader registro)
        {
            var tarefa = new Tarefa() {
                Concluida = (bool)registro["concluida"],  
                Id = (int)registro["id"],
                Nome = registro["nome"].ToString(),
                Observacao = Convert.ToString(registro["observacao"]),
                Prioridade = (Prioridade)Convert.ToUInt32(registro["prioridade"])                
            };
            return tarefa;
        }

        public Tarefa Selecionar(int id)
        {
            Tarefa tarefa = null;
            using (var conexao = new SqlConnection(stringConexao))
            {
                conexao.Open();
                using (var comando = new SqlCommand("TarefaSelecionar", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;

                    comando.Parameters.AddWithValue("@id", id);
                    using (var registro = comando.ExecuteReader())
                    {

                        if (registro.Read())
                        {
                            tarefa = Mapear(registro);
                            
                        }
                    }
                }
                return tarefa;
            }            
        }
        private List<SqlParameter> Mapear(Tarefa tarefa)
        {
            var parametros = new List<SqlParameter>();
            if (tarefa.Id > 0)
            {
                parametros.Add(new SqlParameter("@id", tarefa.Id));
            }
            parametros.Add(new SqlParameter("@Nome", tarefa.Nome));
            parametros.Add(new SqlParameter("@Prioridade", tarefa.Prioridade));
            parametros.Add(new SqlParameter("@Concluida", tarefa.Concluida));
            parametros.Add(new SqlParameter("@Observacao", tarefa.Observacao));

            return parametros;
        }
    }
}
