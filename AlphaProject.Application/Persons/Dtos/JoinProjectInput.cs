using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons.Dtos
{
    public  class JoinProjectInput :IInputDto
    {
        [Required]
        public int PersonId { get; set; }
        [Required]
        public int ProjectId { get; set; }
        [DefaultValue(false)]
        public bool IsLeader { get; set; }

    }
}
