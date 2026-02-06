using System.Linq.Expressions;
using Business_Logic_Layer.DTO;
using Business_Logic_Layer.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using TodoList_App_Mvc.TodoViewModel;
namespace TodoList_App_Mvc.Controllers
{
    public class TodoController(ITodoService _todoService, IWebHostEnvironment _environment) : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var todos = _todoService.GetAllTodo() ?? new List<TodoDto>();
            return View(todos);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TodoListViewModel viewmodel)
        {

            if (!ModelState.IsValid)
                return View(viewmodel);

            try
            {
                _todoService.AddTodo(new AddOrUpdateTodoDto
                {
                    Title = viewmodel.Title,
                    Description = viewmodel.Description,
                    DueDate = viewmodel.DueDate,
                    Status = viewmodel.Status,
                    Priority = viewmodel.Priority
                });

                TempData["Success"] = "Todo Created Successfully";
                return RedirectToAction("Index");
            }
            catch
            {
                TempData["Error"] = "Todo can't be created";
                ModelState.AddModelError("", "Something went wrong");
                return View(viewmodel);
            }
        }
        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var todo = _todoService.GetTodoById(id);
            if (todo == null)
            {
                return NotFound();
            }
            return View(todo);
        }
        [HttpGet]
        public IActionResult Edit(Guid? id)
        {
            if (!id.HasValue) return BadRequest();
            var Todo = _todoService.GetTodoById(id.Value);
            if (id is null) return NotFound();

            var EditViewModel = new EditViewModel()
            {
                Id = Todo.Id,
                Title = Todo.Title,
                Description = Todo.Description,
                DueDate = Todo.DueDate,
                Status = Todo.Status,
                Priority = Todo.Priority
            };
            return View(EditViewModel);
        }
        [HttpPost]
        public IActionResult Edit([FromRoute]Guid id ,EditViewModel detailsViewModel)
        {
            
            if (!ModelState.IsValid)return View(detailsViewModel);
            else
            {
                try
                {
                    var TodoDto = new AddOrUpdateTodoDto()
                    {
                        Id = id,
                        Title = detailsViewModel.Title,
                        Description = detailsViewModel.Description,
                        DueDate = detailsViewModel.DueDate,
                        Status = detailsViewModel.Status,
                        Priority = detailsViewModel.Priority
                    };
                    var result = _todoService.UpdateTodo(TodoDto);
                    if (result == true)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Failed to update Todo.");
                        return View(detailsViewModel);
                    }
                }
                catch (Exception ex)
                {
                    if (_environment.IsDevelopment())
                    {
                        //Development
                        ModelState.AddModelError("", ex.Message);
                        return View(detailsViewModel);
                    }
                    else
                    {
                        //Deployment
                        return View(detailsViewModel);
                    }
                }
            }
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var todo = _todoService.GetTodoById(id);
            if (todo == null)
                return NotFound();

            return View(todo);
        }
        [HttpPost]
        public IActionResult Delete(Guid? id )
        {
            try
            {
                if (!id.HasValue) return BadRequest();
                var isDeleted = _todoService.DeleteTodo(id.Value);
                if (isDeleted)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Failed to Delete Todo.");
                    return View();
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
        }
    }
}

