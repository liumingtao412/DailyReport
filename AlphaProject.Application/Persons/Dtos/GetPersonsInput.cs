using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons.Dtos
{
    public class GetPersonsInput : IPagedResultRequest
    {
        public const int DefaultPageSize = 10;
        public int SkipCount { get; set; }

        public int MaxResultCount { get; set; }

        public GetPersonsInput()
        {
            MaxResultCount = DefaultPageSize;
            SkipCount = 0;
            Name = string.Empty;
            PersonId = null;
            ProjectId = null;
        }


        public string Name { get; set; }
        public int? PersonId { get; set; }
        public int? ProjectId { get; set; }

        /// <summary>
        /// 重写ToString方法，用来写日志
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("[GetPersonsInput > Name = {0}]",Name);
        }

     


    }
}
