using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer.Models.Enum;

namespace Data_Access_Layer.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModified { get; set; } = DateTime.Now;

        public Status Status { get; set; }
        public Priority Priority { get; set; }

    }
}
