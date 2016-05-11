﻿using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects.Dtos
{
    public class DeleteProjectInput : IInputDto
    {
        [Required]
        public int? Id { get; set; }
  
    }
}
