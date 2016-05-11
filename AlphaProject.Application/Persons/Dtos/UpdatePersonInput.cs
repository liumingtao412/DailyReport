﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons.Dtos
{
    [AutoMapTo(typeof(Person))]
    public class UpdatePersonInput : IInputDto
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EMail { get; set; }

        public string Mobile { get; set; }

        public long? UserId { get; set; }
    }
}
