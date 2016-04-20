using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlphaProject.Tasks.Dtos;
using AlphaProject.Core;
using Abp.Domain.Repositories;
using AutoMapper;

namespace AlphaProject.Tasks
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly ITaskRepository _taskRepository;
        private readonly IRepository<Person> _personRepository;

        public TaskAppService(ITaskRepository taskRepository, IRepository<Person> personRepository)
        {
            _taskRepository = taskRepository;
            _personRepository = personRepository;
        }
        public void CreateTask(CreateTaskInput input)
        {
            Logger.Info("Creating a task for input:" + input);
            var newTask = new Task{ Description = input.Description };
            if (input.AssignedPersonId.HasValue)
            {
                newTask.AssignedPersonId = input.AssignedPersonId.Value;
            }
            _taskRepository.Insert(newTask);
        }

        public GetTasksOutput GetTasks(GetTasksInput input)
        {
            var tasks = _taskRepository.GetAllTasksWithPerson(input.AssignedPersonId, input.State);
            return new GetTasksOutput {
                Tasks = Mapper.Map<List<TaskDto>>(tasks)
            };
        }

        public void UpdateTask(UpdateTaskInput input)
        {
            Logger.Info("Updating a task for input:" + input);
            var task = _taskRepository.Get(input.TaskId);
            if(input.State.HasValue)
            {
                task.State = input.State.Value;
            }
            if (input.AssignedPersonId.HasValue)
            {
                task.AssignedPerson = _personRepository.Load(input.AssignedPersonId.Value);
            }
        }
    }
}
