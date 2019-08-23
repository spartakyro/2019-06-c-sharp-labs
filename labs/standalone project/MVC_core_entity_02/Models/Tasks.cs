using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_core_entity_02.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public String TaskName { get; set; }
        [Display(Name ="Due Date")]
        [DataType(DataType.Date)]

       
        public DateTime dueDate { get; set; }

        //foreign key categoryID
        public int? CategoryID { get; set; }
        public virtual category Category { get; set; }
    }
}
