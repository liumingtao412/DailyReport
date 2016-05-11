using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using AlphaProject.Projects;
using AlphaProject.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons
{
    public class PersonManager : DomainService, IPersonManager
    {
        private readonly IPersonRepository _personRepository;
        private readonly IRepository<Project> _projectRepository;
        private readonly IRepository<User,long> _userRepository;

        public PersonManager(IPersonRepository personRepository, IRepository<Project> projectRepository, IRepository<User, long> userRepository)
        {
            _personRepository = personRepository;
            _projectRepository = projectRepository;
            _userRepository = userRepository;

        }

        public void JoinProject(int personId, int projectId, bool isLeader = false)
        {
            var person = _personRepository.FirstOrDefault(personId);
            var project = _projectRepository.FirstOrDefault(projectId);
            if (person == null || project == null)
            {
                throw new ApplicationException("Person or Project is null");
            }

            var person_project = person.Person_Projects.FirstOrDefault(p => p.ProjectId == projectId);
            if (person_project == null)//人员尚未参加此项目，则将人员和项目建立关联
            {
                person_project = new Person_Project()
                {
                    Person = person,
                    Project = project,
                    isProjectLeader = isLeader
                };
                person.Person_Projects.Add(person_project);

            }
            else//人员已经参加了此项目，则修改信息，在此可能修改的信息只有一项，即projectleader
            {
                person_project.isProjectLeader = isLeader;

            }


            // Logger.Info("***" + personId + "--" + projectId);


        }
        public void QuitProject(int personId, int projectId)
        {
            var person = _personRepository.FirstOrDefault(personId);
            var project = _projectRepository.FirstOrDefault(projectId);
            if (person == null || project == null)
            {
                throw new ApplicationException("Person or Project is null");
            }

            var person_project = person.Person_Projects.FirstOrDefault(p => p.ProjectId == projectId);
            if (person_project == null)//人员尚未参加此项目，则将人员和项目建立关联
            {
                throw new UserFriendlyException("此人员未参加此项目，无需移除");
            }
            else//人员已经参加了此项目，则修改信息，在此可能修改的信息只有一项，即projectleader
            {
                person.Person_Projects.Remove(person_project);

            }
        }


        public void AssignToUser(int personId, long userId)
        {
           // throw new NotImplementedException();
            User user = _userRepository.FirstOrDefault(userId);
            Person person = _personRepository.FirstOrDefault(personId);
            if (user==null||person==null)
            {
                throw new ApplicationException("user or person is null");
            }

            person.SetUser(user);
        }
    }
}
