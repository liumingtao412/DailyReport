using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace AlphaProject.Persons.Dtos
{
    [AutoMapFrom(typeof(Person))] //AutoMapFrom attribute maps Person -> PersonDto
    public class PersonDto : EntityDto
    {
        public  string Name { get; set; }
        public string EMail { get; set; }
        public string Moblie { get; set; }

    }
}