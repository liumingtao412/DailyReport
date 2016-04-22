using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace AlphaProject.Persons.Dtos
{
    public class QuitProjectInput : IInputDto
    {
        [Required]
        public int PersonId { get; set; }
        [Required]
        public int ProjectId { get; set; }
      

    }
}
