using GestionToDoAvecApi.Models.Entities;

namespace GestionToDoAvecApi.Models.Repository
{
    public interface ITodoRepository
    {
        IEnumerable<ToDo>? Get();
        public ToDo? Get(int id);
        public bool Create(ToDo toDo);
        public bool Update(ToDo toDo);
        public bool Delete(int id);
    }
}
