using Abp.Domain.Services;
using AlphaProject.Projects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaProject.Persons
{
    public interface IPersonManager : IDomainService
    {
        void JoinProject(int personId, int projectId, bool isLeader=false);
        void QuitProject(int personId, int projectId);

        void AssignToUser(int personId, long userId);

    }
}
