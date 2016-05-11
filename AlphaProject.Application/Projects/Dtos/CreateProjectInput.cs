using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects.Dtos
{
    [AutoMapTo(typeof(Project))]
    public class CreateProjectInput : IInputDto
    {
        [Required]
        public  string ProjectName { get; set; }
        [DefaultValue(ProjectState.Stop)]
        public  ProjectState State { get; set; }

    }
}
