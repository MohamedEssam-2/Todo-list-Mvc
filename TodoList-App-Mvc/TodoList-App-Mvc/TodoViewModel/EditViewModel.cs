using Data_Access_Layer.Models.Enum;

namespace TodoList_App_Mvc.TodoViewModel
{
    public class EditViewModel
    {

        public Guid Id { get; set; }
        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }

        public Status Status { get; set; } = Status.Pending;

        public Priority Priority { get; set; } = Priority.Medium;
    }
}
