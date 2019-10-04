using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskiesBlazor.Data
{
    [Table("ToDoBlock")]
    public class TaskBlock
    {
        public TaskBlock()
        {
            Tasks = new List<Taskie>();
        }
        [Key]
        public int idTaskBlock { get; set; }
        public ICollection<Data.Taskie> Tasks { get; set; }
        public DateTime dtModified { get; set; }
        public string deTaskBlock { get; set; }
        public bool isCompleted { get; set; }
        public string coColor { get; set; }
        public byte order { get; set; }
    }
}
