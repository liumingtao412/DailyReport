using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AlphaProject.PersonReports.Dtos;
using AlphaProject.Persons;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Linq.Extensions;


namespace AlphaProject.PersonReports
{
    public class PersonReportAppService:ApplicationService,IPersonReportAppService
    {
        private readonly IPersonRepository _personRepository;
        //private readonly IPersonManager _personManager;
        public PersonReportAppService(IPersonRepository personRepository)
        {
           _personRepository = personRepository;
          // _personManager = personManager;
        }
        public PagedResultOutput<PersonReportDto> GetPersonReports(GetPersonReportsInput input)
        {
           // throw new NotImplementedException();

            //todo:GetPersonReports
            var currentPerson = _personRepository.FirstOrDefault(2);//todo: change to get current login person
            if (currentPerson == null)
            {
                throw new ApplicationException("User not login");
            }


            var personReports = currentPerson.GetReports().OrderBy(p => p.ReportDate).PageBy(input);
       
            if (input.ProjectId.HasValue)
            {
                personReports = personReports.Where(p => p.ProjectId == input.ProjectId.Value);
            }
            if (!string.IsNullOrEmpty(input.Keywords))
            {
                personReports = personReports.Where(p => p.Contents.Contains(input.Keywords));
            }
            if (input.StartDate.HasValue)
            {
                personReports = personReports.Where(p=>p.ReportDate>=input.StartDate.Value);
            }
            if (input.EndDate.HasValue)
            {
                personReports = personReports.Where(p => p.ReportDate <= input.EndDate.Value);
            }
            var personReportCount = personReports.Count();


            return new PagedResultOutput<PersonReportDto>(
                personReportCount,
                Mapper.Map<List<PersonReportDto>>(personReports)
                );
        }


        public void CreatePersonReport(CreatePersonReportInput input)
        {
            //throw new NotImplementedException();
            var currentPerson = _personRepository.FirstOrDefault(2);//todo:change to get current login person
            PersonReport newReport = Mapper.Map<PersonReport>(input);
            newReport.ReportDate = DateTime.Now;
            currentPerson.WiteReport(newReport);
        }
    }
}
