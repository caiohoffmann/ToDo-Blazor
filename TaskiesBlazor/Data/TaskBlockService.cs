using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskiesBlazor.Data
{
    public class TaskBlockService
    {
        private static readonly string[] Names = new[]
        {
            "My Block", "Another Block", "The Other Block"
        };
        public async Task<IList<TaskBlock>> GetTaskBlocksAsync()
        {
            var rng = new Random();
            return await Task.FromResult(Enumerable.Range(1, 3).Select(index => new TaskBlock
            {
                deTaskBlock = Names[rng.Next(Names.Length)],
                idTaskBlock = rng.Next(Names.Length) + 1
            }).ToList());
        }
    }
}
