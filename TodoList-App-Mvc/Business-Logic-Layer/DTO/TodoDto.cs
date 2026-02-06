using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models.Enum;

namespace Business_Logic_Layer.DTO
{
    public class TodoDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }

        public DateTime? CreatedDate { get; set; } 
        public DateTime? LastModified { get; set; } 

        public Status Status { get; set; }

        public Priority Priority { get; set; }
    }
}
