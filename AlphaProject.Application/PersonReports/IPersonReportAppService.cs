using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AlphaProject.PersonReports.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.PersonReports
{
    public interface IPersonReportAppService : IApplicationService
    {
        PagedResultOutput<PersonReportDto> GetPersonReports(GetPersonReportsInput input);
        void CreatePersonReport(CreatePersonReportInput input);
    }
}
