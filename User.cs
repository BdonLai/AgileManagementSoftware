using System;
using System.Collections.Generic;

namespace ManagementApp{
    public abstract class User{

        /// <summary>
        /// Parent class User
        /// Private attributes: List <ProjectManager> _projectManager,List <ProjectMember> _projectMember
        /// </summary>


         private List <ProjectManager> _projectManager;

        private List <ProjectMember> _projectMember;


        /// <summary>
        /// Parent class user constructor
        /// </summary>
        public User(){
            _projectManager = new List<ProjectManager>();
            _projectMember = new List<ProjectMember>();
        }

        /// <summary>
        /// Add project manager into user's list
        /// </summary>
        /// <param name="pm"></param>

        public void addProjectMan(ProjectManager pm){
            _projectManager.Add(pm);
        }

        /// <summary>
        /// Add project member into user's list
        /// </summary>
        /// <param name="pm"></param>

        public void addMemberMan(ProjectMember pm){
            _projectMember.Add(pm);
        }

        
        /// <summary>
        /// read and write property for: List<ProjectManager> projectManager,List <ProjectMember> projectMember
        /// </summary>
        /// <value></value>
        public List<ProjectManager> projectManager{
            get{ return _projectManager; }
            set{ _projectManager = value; }
        }

        public List <ProjectMember> projectMember{
            get{ return _projectMember; }
            set{ _projectMember = value; }
        }

        /// <summary>
        /// Abstract methods: register, login
        /// </summary>
        /// <returns></returns>
        public abstract string register();

        public abstract void login();

    }
}