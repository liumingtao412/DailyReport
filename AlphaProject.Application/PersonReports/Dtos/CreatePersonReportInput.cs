using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AlphaProject.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.PersonReports.Dtos
{
    [AutoMapTo(typeof(PersonReport))]
    public class CreatePersonReportInput : IInputDto
    {
        [Required]
        public  string Contents { get; set; }

    }
}
