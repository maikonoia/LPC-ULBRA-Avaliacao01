using System;

namespace ControleDeTarefas.Models
{
    public class Tarefa
    {
        public int codigo { get; set; }
        public float prioridade { get; set; }
        public string nome { get; set; }
        public DateTime dataLimite { get; set; }
        public float percentual { get; set; }
        public Boolean status { get; set; }

        public Tarefa() {}
        public Tarefa(int codigo, float prioridade, string nome, DateTime dataLimite, float percentual){
            this.codigo = codigo;
            this.prioridade = prioridade;
            this.nome = nome;
            this.dataLimite = dataLimite;
            this.percentual = percentual;

            if(percentual < 100) {
                this.status = false;
            } else {
                this.status = true;
            }
        }
    }
}