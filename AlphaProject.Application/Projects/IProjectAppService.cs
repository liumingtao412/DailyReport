using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AlphaProject.Projects.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects
{
    public interface IProjectAppService : IApplicationService
    {
        PagedResultOutput<ProjectDto> GetProjects(GetProjectsInput input);
    }
}
