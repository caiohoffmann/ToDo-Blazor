using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskiesBlazor.Models;

namespace TaskiesBlazor.Data
{
    public class TaskieService
    {
        private Context _context;

        public async Task<IList<Taskie>> GetTaskiesAsync()
        {
            using (_context = ContextFactory.GetContext())
            {
                return await _context.Taskies.ToListAsync();
            }
        }

        public async Task<Taskie> AddTaskieAsync(Taskie taskie)
        {
            taskie.dtModified = DateTime.Now;
            using (_context = ContextFactory.GetContext())
            {
                await _context.Taskies.AddAsync(taskie);
                await _context.SaveChangesAsync();
            }
            return taskie;
        }

        public async Task<Taskie> UpdateTaskie(Taskie taskie)
        {
            taskie.dtModified = DateTime.Now;
            using (_context = ContextFactory.GetContext())
            {
                _context.Update(taskie);
                await _context.SaveChangesAsync();
            }
            return taskie;
        }
    }
}
