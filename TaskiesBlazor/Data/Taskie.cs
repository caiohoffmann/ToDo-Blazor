using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskiesBlazor.Data
{
    [Table("ToDo")]
    public class Taskie
    {
        [Key]
        public int idTask { get; set; }
        public string deTask { get; set; }
        public bool isCompleted { get; set; }
        public DateTime dtModified { get; set; }
        public int idTaskBlock { get; set; }
        [ForeignKey("idTaskBlock")]
        public TaskBlock TaskBlock { get; set; }
        public int? idParent { get; set; }
        [ForeignKey("idParent")]
        public Taskie Parent { get; set; }
        public ICollection<Taskie> Children { get; set; }
    }
}
