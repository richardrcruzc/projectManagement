using ProjectManagement.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ProjectManagement.Domain.Enums;

namespace ProjectManagement.Domain.Projects
{
    public class TeamMember: States.TeamMemberState
    {

        public static TeamMember Create(Project project, Person person )
        {
            var obj = new TeamMember {
                Project = project,
                ProjectId = project.Id,
                Person =person,
                PersonId =person.Id,


            };
            return obj;

        }
        public void Update(Project project, Person person )
        {
            Project = project;
            ProjectId = project.Id;
            Person = person;
            PersonId = person.Id;


        }

        public TeamMember AddTeamRole(ICollection<TeamRole> items)
        {
            foreach (var item in items)
            {
                TeamRole.Add(item);
            }
            return this;
        }
        public TeamMember AddPermision(ICollection<Permission> items)
        {
            foreach (var item in items)
            {
                Permision.Add(item);
            }
            return this;
        }


        #region Added to please the O/RM

        /// <summary>
        /// Used by the O/RM to materialize objects
        /// </summary>
        private TeamMember()
        {
        }

        #endregion

        public Project Project { get; set; }
        public Person Person { get; set; }
        public ICollection<TeamRole> TeamRole { get; set; }

        public TeamStatus TeamStatus { get; set; }
        public ICollection<Permission> Permision { get; set; }


    }
}
