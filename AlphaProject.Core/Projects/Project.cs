using Abp.Domain.Entities;
using AlphaProject.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Projects
{
    public enum ProjectState
    {
        Stop,
        Active,
        Cancel,
        Finish
    }
    public class Project : Entity
    {
        [DisplayName("项目名称")]
        public virtual string ProjectName { get; set; }

        [DisplayName("项目状态")]
        [DefaultValue(ProjectState.Stop)]
        public virtual ProjectState State { get; set; }//使用了EF6支持枚举，所以可以直接支持枚举类型的变量


        //[DisplayName("是否启动")]
        //[DefaultValue(false)]
        //public virtual bool isStarted { get; set; }

        //[DisplayName("是否完成")]
        //[DefaultValue(false)]
        //public virtual bool  isFinished { get; set; }

        [ForeignKey("ProjectID")]
        public virtual ICollection<ProjectReport> ProjectReports { get; set; }


        public virtual ICollection<Person_Project> Project_Persons { get; set; }

       
    }
}
