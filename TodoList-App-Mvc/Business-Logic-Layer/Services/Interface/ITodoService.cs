using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Logic_Layer.DTO;

namespace Business_Logic_Layer.Services.Interface
{
    public interface ITodoService
    {
        public bool AddTodo(AddOrUpdateTodoDto todoDto);
        public bool UpdateTodo(AddOrUpdateTodoDto todoDto);
        public bool DeleteTodo(Guid id);
        public TodoDto? GetTodoById(Guid id);
        public List<TodoDto> GetAllTodo();
    }
}
