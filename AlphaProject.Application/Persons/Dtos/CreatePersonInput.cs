using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons.Dtos
{
    public class CreatePersonInput :IInputDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string EMail { get; set; }
        public string Mobile { get; set; }

    }
}
