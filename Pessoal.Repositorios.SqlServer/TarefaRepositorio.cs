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
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
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

        private List<SqlParameter>  Mapear(Tarefa tarefa)
        {
            var paramentros = new List<SqlParameter>();
            paramentros.Add(new SqlParameter("@Nome", tarefa.Nome));
            paramentros.Add(new SqlParameter("@Prioridade", tarefa.Prioridade));
            paramentros.Add(new SqlParameter("@Concluida", tarefa.Concluida));
            paramentros.Add(new SqlParameter("@Observacao", tarefa.Pbservacao));
            return paramentros;
        }

        public Tarefa Selecionar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tarefa> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
