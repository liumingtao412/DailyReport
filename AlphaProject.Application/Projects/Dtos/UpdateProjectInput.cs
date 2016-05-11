using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects.Dtos
{
    [AutoMapTo(typeof(Project))]
    public class UpdateProjectInput : IInputDto
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [Required]       
        public ProjectState? State { get; set; }
    }
}
