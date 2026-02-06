using Data_Access_Layer.Models.Enum;

namespace TodoList_App_Mvc.TodoViewModel
{
    public class DetailsViewModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public Status Status { get; set; }

        public Priority Priority { get; set; }
    }
}
