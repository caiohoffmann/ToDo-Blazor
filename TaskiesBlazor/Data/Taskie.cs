using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskiesBlazor.Data
{
    public class Taskie
    {
        public int idTask { get; set; }
        public string deTask { get; set; }
        public bool isCompleted { get; set; }
        public DateTime dtModified { get; set; }
        public int idTaskBlock { get; set; }
        public TaskBlock TaskBlock { get; set; }
        public int? idParent { get; set; }
        public Task Parent { get; set; }
        public ICollection<Task> Children { get; set; }
    }
}
