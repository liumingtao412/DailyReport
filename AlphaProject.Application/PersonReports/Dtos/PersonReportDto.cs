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
    [AutoMapFrom(typeof(PersonReport))]
    public class PersonReportDto: EntityDto
    {
        public  string Contents { get; set; }
        public  DateTime ReportDate { get; set; }

        public  int PersonID { get; set; }

    }
}
