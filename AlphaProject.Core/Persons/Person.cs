using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons
{
    public class Person : Entity
    {
        [DisplayName("姓名")]
        public virtual string Name { get; set; }
        [DisplayName("邮箱")]
        public virtual string EMail { get; set; }
        [DisplayName("手机")]
        public virtual string Mobile { get; set; }
        [ForeignKey("PersonID")]
        public virtual ICollection<PersonReport> PersonReports { get; set; }


    }
}
