using Data_Access_Layer.Data.Context;
using Data_Access_Layer.Data.Repository.Interface;
using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
public class TodoAppRepository : ITodoAppRepository
{
    private readonly TodoDbContext _dbContext;

  
    public TodoAppRepository(TodoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public int Add(Todo todo)
    {
        _dbContext.Todo.Add(todo);
        return _dbContext.SaveChanges() > 0 ? 1 : 0;
    }

    public int Update(Todo todo)
    {
        _dbContext.Todo.Update(todo);
        return _dbContext.SaveChanges() > 0 ? 1 : 0;
    }

    public int Delete(Todo todo)
    {
        _dbContext.Remove(todo);
        return _dbContext.SaveChanges() > 0 ? 1 : 0;
    }

    public List<Todo> GetAll()
    {
        return _dbContext.Todo.ToList();
    }

    public Todo? GetById(Guid id)
    {
        return _dbContext.Todo.Find(id);
    }
}
