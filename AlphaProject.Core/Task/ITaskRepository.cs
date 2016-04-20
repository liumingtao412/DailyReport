using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Core
{
    public interface ITaskRepository : IRepository<Task, long>
    {
        List<Task> GetAllTasksWithPerson(int? assignedPersonId, TaskState? state);
    }
}
