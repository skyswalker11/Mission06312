using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission0631.Models
{
    public class EnterTaskSubmission
    {
        [Key]
        [Required]
        public int TaskID { get; set; }
        [Required(ErrorMessage = "Task is Required")]
        public string Task { get; set; }
        public string DueDate { get; set; }
        [Required(ErrorMessage = "Quadrant is Required")]
        public string Quadrant { get; set; }
        //public string Category { get; set; }
        public bool Completed { get; set; }
        [Required]
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
