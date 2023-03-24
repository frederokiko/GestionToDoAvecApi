using GestionToDoAvecApi.Models.Entities;
using GestionToDoAvecApi.Models.Repository;
using System.Text.Json;

namespace GestionToDoAvecApi.Models.Services
{
    public class ToDoServices : ITodoRepository
    {
        private readonly IHttpClientFactory _factory;

        public bool Create(ToDo toDo)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo>? Get()
        {
            using (HttpClient httpClient = _factory.CreateClient("Api"))
            {
                using(HttpResponseMessage httpResponseMessage = httpClient.GetAsync("todo").Result)
                {
                    httpResponseMessage.EnsureSuccessStatusCode();
                    string json = httpResponseMessage.Content.ReadAsStringAsync().Result;
                    //Ajouter apres le todo pour bien afficher la deserialisation !(json,new JsonSerializerOptions() { PropertyNameCaseInsensitive = true })
                    return JsonSerializer.Deserialize<ToDo[]>(json,new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
                }
            }
        }

        public ToDo? Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ToDo toDo)
        {
            throw new NotImplementedException();
        }
    }
}
