using Abp.EntityFramework;
using AlphaProject.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AlphaProject.EntityFramework.Repositories
{
    public class TaskRepository : AlphaProjectRepositoryBase<Task, long>, ITaskRepository
    {
        public List<Task> GetAllTasksWithPerson(int? assignedPersonId, TaskState? state)
        {
            var query = GetAll();
            if (assignedPersonId.HasValue)
            {
                query = query.Where(task => task.AssignedPerson.Id == assignedPersonId.Value);
            }

            if (state.HasValue)
            {
                query = query.Where(task => task.State == state);
            }
            return query.OrderByDescending(t => t.CreationTime)
                .Include(t => t.AssignedPerson)
                .ToList();
        }
        public TaskRepository(IDbContextProvider<AlphaProjectDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }
    }
}
