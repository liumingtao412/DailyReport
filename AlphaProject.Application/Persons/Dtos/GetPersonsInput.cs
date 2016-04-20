using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons.Dtos
{
    public class GetPersonsInput : IInputDto
    {
        [Required]
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("[GetPersonsInput > Name = {0}]",Name);
        }

    }
}
