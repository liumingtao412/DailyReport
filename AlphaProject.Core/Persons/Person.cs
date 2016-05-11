using Abp.Domain.Entities;
using AlphaProject.Users;
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

        //[ForeignKey("UserId")]
        public virtual User User { get; protected set; }
        //public virtual long UserId { get; protected set; }

        public virtual ICollection<Person_Project> Person_Projects { get; set; }


        public  void SetUser(User user)
        {
            this.User = user;
        }
  
        public void WiteReport(PersonReport report)
        {
            this.PersonReports.Add(report);
            
        }

        public IQueryable<PersonReport> GetReports()
        {
            return this.PersonReports.AsQueryable();
        }
       

      

    }
}
