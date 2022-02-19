using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerIngest.Infrastructure.Datatable
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
    }
}
