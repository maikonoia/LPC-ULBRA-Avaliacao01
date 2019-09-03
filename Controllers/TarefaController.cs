using Microsoft.AspNetCore.Mvc;
using ControleDeTarefas.Models;

namespace ControleDeTarefas.Controllers
{
    public class TarefaController : Controller
    {
        TarefaRepository _repository = new TarefaRepository();
        public IActionResult Index()
        {
            var tarefas = _repository.GetAll();
            return View(tarefas);
        }
        
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Tarefa tarefa)
        {            
            _repository.Create(tarefa);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {   
            
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public RedirectToActionResult Edit(Tarefa tarefa)
        {            
            _repository.Update(tarefa);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {   
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
