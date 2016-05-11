using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.PersonReports.Dtos
{
    public class GetPersonReportsInput : IPagedResultRequest
    {

        public const int DefaultPageSize = 10;
        public int SkipCount { get; set; }

        public int MaxResultCount { get; set; }

        public GetPersonReportsInput()
        {
            MaxResultCount = DefaultPageSize;
            SkipCount = 0;
           
        }
        public DateTime? StartDate { get; set; }
        public DateTime?  EndDate { get; set; }
        public string Keywords { get; set; }
        public int? ProjectId { get; set; }


    }
}
