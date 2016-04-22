using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons.Dtos
{
    /// <summary>
    /// 此类不使用了，而是使用abp提供的泛型PagedResultOutput<T>作为各种list类型的统一返回值
    /// </summary>
    public class GetPersonsOutput : IOutputDto
    {
        public List<PersonDto> Persons { get; set; }

    }
}
