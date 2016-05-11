using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons.Dtos
{
    public class DeletePersonInput:IInputDto
    {
        public List<int> DeletePersonIds { get; set; }

    }
}
