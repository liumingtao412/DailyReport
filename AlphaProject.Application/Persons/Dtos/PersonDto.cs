using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AlphaProject.Core;

namespace AlphaProject.Persons.Dtos
{
    [AutoMapFrom(typeof(Person))] //AutoMapFrom attribute maps Person -> PersonDto
    public class PersonDto : EntityDto
    {
        public  string Name { get; set; }

    }
}