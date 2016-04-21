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
    public class Project : Entity
    {
        [DisplayName("项目名称")]
        public virtual string ProjectName { get; set; }

        [DisplayName("是否启动")]
        [DefaultValue(false)]
        public virtual bool isStarted { get; set; }

        [DisplayName("是否完成")]
        [DefaultValue(false)]
        public virtual bool  isFinished { get; set; }

        [ForeignKey("ProjectID")]
        public virtual ICollection<ProjectReport> ProjectReports { get; set; }

       
    }
}
