using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models.Enum;

namespace Business_Logic_Layer.DTO
{
    public class AddOrUpdateTodoDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }

        public Status Status { get; set; } = Status.Pending; 

        public Priority Priority { get; set; } = Priority.Medium;
    }
}
