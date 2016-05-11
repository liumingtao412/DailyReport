using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AlphaProject.Projects.Dtos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Linq.Extensions;

namespace AlphaProject.Projects
{
    public class ProjectAppService : ApplicationService, IProjectAppService
    {
        private readonly IRepository<Project> _projectRepository;
        public ProjectAppService(IRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public PagedResultOutput<ProjectDto> GetProjects(GetProjectsInput input)
        {
            //throw new NotImplementedException();
            var projects = _projectRepository.GetAll().OrderBy(p => p.ProjectName).PageBy(input);
            if (!string.IsNullOrEmpty(input.ProjectName))
            {
                projects = projects.Where(p => p.ProjectName == input.ProjectName);
            }
            if (input.State.HasValue)
            {
                projects = projects.Where(p => p.State == input.State.Value);
            }

            var projectCount = projects.Count();


            return new PagedResultOutput<ProjectDto>(
                projectCount,
                Mapper.Map<List<ProjectDto>>(projects)
                );
        }


        public int CreateProject(CreateProjectInput input)
        {
           // throw new NotImplementedException();
            return _projectRepository.InsertAndGetId(Mapper.Map<Project>(input));
        }


        public void DeleteProject(DeleteProjectInput input)
        {

            //throw new NotImplementedException();
            if (input.Id.HasValue)
            {
                _projectRepository.Delete(input.Id.Value);
            }
        }


        public void UpdateProject(UpdateProjectInput input)
        {
            //throw new NotImplementedException();
            Project projectToUpdate = Mapper.Map<Project>(input);
            _projectRepository.Update(projectToUpdate);
        }
    }
}
