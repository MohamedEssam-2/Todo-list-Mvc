using AutoMapper;
using Business_Logic_Layer.DTO;
using Business_Logic_Layer.Services.Interface;
using Data_Access_Layer.Data.Context;
using Data_Access_Layer.Data.Repository.Interface;
using Data_Access_Layer.Models;

public class TodoService : ITodoService
{
    private readonly ITodoAppRepository _todoAppRepo;
    private readonly IMapper _mapper;
    private readonly TodoDbContext _dbContext;

    public TodoService(ITodoAppRepository todoAppRepo, IMapper mapper, TodoDbContext dbContext)
    {
        _todoAppRepo = todoAppRepo;
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public bool AddTodo(AddOrUpdateTodoDto todoDto)
    {
        var todo = _mapper.Map<Todo>(todoDto);
       var r = _todoAppRepo.Add(todo);
        if (r == 0) return false;
        return true;

    }

    public bool DeleteTodo(Guid id)
    {
        var todo = _todoAppRepo.GetById(id);
        if (todo is null) return false;

        var r = _todoAppRepo.Delete(todo);
        if (r == 0) return false;
        return true;
    }

    public List<TodoDto> GetAllTodo()
    {
        var todos = _todoAppRepo.GetAll();
        return _mapper.Map<List<TodoDto>>(todos);
    }

    public TodoDto? GetTodoById(Guid id)
    {
        var todo = _todoAppRepo.GetById(id);
        return todo == null ? null : _mapper.Map<TodoDto>(todo);
    }

    public bool UpdateTodo(AddOrUpdateTodoDto todoDto)
    {
        var todo = _mapper.Map<Todo>(todoDto);
      var r =  _todoAppRepo.Update(todo);
        if (r == 0) return false;
        return true;
    }
}
