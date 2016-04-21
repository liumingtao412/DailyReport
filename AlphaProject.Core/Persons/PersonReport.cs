using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons
{
    public class PersonReport : Entity
    {
        [DisplayName("日报内容")]
        [Required]
        public virtual string Contents { get; set; }
        [DisplayName("提交日期")]
        public virtual DateTime ReportDate { get; set; }

        [ForeignKey("PersonID")]
        public virtual Person Author { get; set; }
        public virtual int PersonID { get; set; }


    }
}
