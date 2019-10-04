using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskiesBlazor.Models;

namespace TaskiesBlazor.Data
{
    public class TaskBlockService
    {
        private Context _context;

        public async Task<IList<TaskBlock>> GetTaskBlocksAsync()
        {
            using (_context = ContextFactory.GetContext())
            {
                return await _context.TaskBlocks.Include(tb => tb.Tasks).ToListAsync();
            }
        }

        public async Task<TaskBlock> AddAsync(TaskBlock taskBlock)
        {
            using (_context = ContextFactory.GetContext())
            {
                taskBlock.dtModified = DateTime.Now;
                await _context.TaskBlocks.AddAsync(taskBlock);
                await _context.SaveChangesAsync();
                return taskBlock;
            }
        }

        public async Task UpdateAsync(TaskBlock taskBlock)
        {
            using (_context = ContextFactory.GetContext())
            {
                _context.Update(taskBlock);
                await _context.SaveChangesAsync();
            }
        }
    }
}
