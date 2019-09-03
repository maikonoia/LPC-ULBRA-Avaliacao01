using System.Collections.Generic;

namespace ControleDeTarefas.Models
{
    public class TarefaRepository
    {
         public static List<Tarefa> tarefas = new List<Tarefa>();
    
        public TarefaRepository()
        {           
        }

        public void Create(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
        }
        public List<Tarefa> GetAll()
        {
            return tarefas;
        }
        
        public Tarefa GetById(int id)
        {
            return tarefas.Find(i=>i.codigo == id);
        }
        public void Delete(int id)
        {
            tarefas.Remove(GetById(id));
        }

        public void Update(Tarefa tarefa)
        {
            var i = tarefas.FindIndex(x=>x.codigo == tarefa.codigo);
            tarefas[i].prioridade = tarefa.prioridade;
            tarefas[i].nome = tarefa.nome;
            tarefas[i].dataLimite = tarefa.dataLimite;
            tarefas[i].percentual = tarefa.percentual;

            if(tarefa.percentual < 100) {
                tarefas[i].status = false;
            } else {
                tarefas[i].status = true;
            }
        }

    }
}