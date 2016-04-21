using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects
{
    public class ProjectReport : Entity
    {
        [DisplayName("日报内容")]
        public virtual string Contents { get; set; }

        [DisplayName("日报日期")]
        public virtual DateTime ReportDate { get; set; }

        [DisplayName("是否发送成功")]
        [DefaultValue(false)]
        public virtual bool IsSent { get; set; }

        [DisplayName("所属项目")]
        [ForeignKey("ProjectID")]
        public virtual Project BelongProject { get; set; }
        public virtual int ProjectID { get; set; }


       
    }
}
