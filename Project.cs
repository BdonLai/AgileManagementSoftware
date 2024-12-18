using System;
using System.Collections.Generic;

namespace ManagementApp{
    public class Project{
        /// <summary>
        /// private attributes for Project: _projectName (string), _projectDue(DateTime), _ProjectMemberss: List <ProjectMember>
        /// </summary>
        private string _projectName;
        private DateTime _projectDue;

        private List <ProjectMember> _ProjectMemberss;
        
        /// <summary>
        /// Project constructor with parameters: projectName, projectDue
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectDue"></param>
        public Project(string projectName, DateTime projectDue){
            _projectName = projectName;
            _projectDue = projectDue;
            _ProjectMemberss = new List <ProjectMember>();
           
        }

        /// <summary>
        /// Read and write property for ProjectMemberss: List <ProjectMember>, string ProjectName, DateTime projectDue
        /// </summary>
        /// <value></value>

        public List<ProjectMember> ProjectMemberss { 
            get { return _ProjectMemberss;}
            set { _ProjectMemberss = value; }
        }

        

        public string ProjectName {
            get {return _projectName;}
            set { _projectName = value;}
        }

        public DateTime projectDue{
            get {return _projectDue;}
        }

    }
}