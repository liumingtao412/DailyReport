
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Core
{
    public enum TaskState
    {
        Active,
        Cancel,
        Stop
    }
    public class Task : Entity<long>
    {
        [ForeignKey("AssignedPersonId")]
        public virtual Person AssignedPerson { get; set; }

        public virtual int?  AssignedPersonId { get; set; }
        public virtual string  Description { get; set; }
        public virtual DateTime CreationTime { get; set; }
        public virtual TaskState State { get; set; }
        public virtual string Remarks { get; set; }


        public Task()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Active;
        }

    }
}
