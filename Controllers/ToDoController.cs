using GestionToDoAvecApi.Models.Entities;
using GestionToDoAvecApi.Models.Forms;
using GestionToDoAvecApi.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace GestionToDoAvecApi.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ITodoRepository _repository;

        public ToDoController(ITodoRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(int id)
        {
            return View(_repository.Get().Select(t => new ToDoSimple() { Id = t.Id, Title = t.Title }).ToList());
            
            //return View(data);
        }
    }
}
