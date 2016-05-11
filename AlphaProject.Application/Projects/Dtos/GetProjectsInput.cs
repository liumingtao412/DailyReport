using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects.Dtos
{
    public class GetProjectsInput : IPagedResultRequest
    {
        public const int DefaultPageSize = 10;

        public string ProjectName { get; set; }
        public ProjectState? State { get; set; }       

        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }

        public GetProjectsInput()
        {
            MaxResultCount = DefaultPageSize;
            SkipCount = 0;
            ProjectName = string.Empty;
            State = null;
        }

    }
}
