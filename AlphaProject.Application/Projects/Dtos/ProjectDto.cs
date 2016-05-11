using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects.Dtos
{
    [AutoMapFrom(typeof(Project))]
    public class ProjectDto : EntityDto
    {

        public string ProjectName { get; set; }

        public ProjectState State { get; set; }
    }
}
