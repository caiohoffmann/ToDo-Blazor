using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskiesBlazor.Data
{
    public class TaskBlock
    {
        public TaskBlock()
        {
            Tasks = new List<Taskie>();
        }
        public int idTaskBlock { get; set; }
        public ICollection<Data.Taskie> Tasks { get; set; }
        public DateTime dtModified { get; set; }
        public string deTaskBlock { get; set; }
        public bool isCompleted { get; set; }
        public string coColor { get; set; }
        public byte order { get; set; }
    }
}
