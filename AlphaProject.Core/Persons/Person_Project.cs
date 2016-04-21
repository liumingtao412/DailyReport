using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlphaProject.Projects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AlphaProject.Persons
{
    public class Person_Project
    {
        [Key]
        [Column(Order = 0)]
        public virtual int PersonId { get; set; }
        [Key]
        [Column(Order = 1)]
        public virtual int  ProjectId { get; set; }

        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
        [DefaultValue(false)]
        public virtual bool isProjectLeader { get; set; }

    }
}
