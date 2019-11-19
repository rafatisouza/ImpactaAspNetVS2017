using System;

namespace Pessoal.Dominio.Entidades
{
    public class Tarefa
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public Prioridade Prioridade { get; set; }
        public bool Concluida { get; set; }
        public string Pbservacao { get; set; }
    }
}
