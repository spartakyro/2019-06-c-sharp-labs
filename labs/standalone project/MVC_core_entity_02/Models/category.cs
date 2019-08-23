using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_core_entity_02.Models
{
    public class category
    {
        public category()
        {
            Tasks = new HashSet<Models.Task>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Models.Task> Tasks { get; set; }

       
    }
}
