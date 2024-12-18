using System;
using System.Collections.Generic;


namespace ManagementApp{
    public class Admin{
        /// <summary>
        /// private attributes for Admin class: _adminName(string), _adminPassword(strint), projects: List<Project>, p
        /// projectManagers: List<ProjectManager>, projectMembers: List <ProjectMember>
        /// </summary>
        private string _adminName;

        private string _adminPassword;


        private List<Project> projects;

        private List<ProjectManager> projectManagers;

        private List <ProjectMember> projectMembers;

        #nullable disable

        /// <summary>
        /// Admin constructor with parameters: adminName, adminPassword as passby values
        /// Initializes Lists: List <Project> projects,List <ProjectManager> projectManagers,List<ProjectMember> projectMembers 
        /// </summary>
        /// <param name="adminName"></param>
        /// <param name="adminPassword"></param>

        public Admin(string adminName, string adminPassword){
            _adminName = adminName;
            _adminPassword = adminPassword;
            projects = new List<Project>();
            projectManagers = new List<ProjectManager>();
            projectMembers = new List<ProjectMember>();
        }

        /// <summary>
        /// read and write property for AdminName, AdminPassword, List<Project> Projects, List<ProjectManager> ProjectManagers,
        /// List<ProjectMember> ProjectMembers
        /// </summary>
        /// <value></value>

        public string AdminName { 
            get { return _adminName;}
            set { _adminName = value; }
        }

        public string AdminPassword{
            get { return _adminPassword;}
            set { _adminPassword = value; }
        }


        public List<Project> Projects {
            get { return projects; }
            set { projects = value; }
        }

        public List <ProjectManager> ProjectManagers {
            get { return projectManagers; }
            set { projectManagers = value; }
        }

        public List <ProjectMember> ProjectMembers {
            get { return projectMembers; }
            set { projectMembers = value; }
        }

        /// <summary>
        /// Method for Admin login that takes input to match with object attributes
        /// </summary>

        public void AdminLogin(){
            Console.WriteLine("Admin Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Admin Password: ");
            string password = Console.ReadLine();

            if(name == _adminName & password == _adminPassword){
                Console.WriteLine("\n");
                Console.WriteLine( "login success " + _adminName);
                Console.WriteLine("\n");
            }
            else{
                Console.WriteLine("\n");
                Console.WriteLine ("Invalid Credentials");
                Console.WriteLine("\n");
                AdminLogin();
            }
        }

        /// <summary>
        /// Method to add project used in main program 
        /// </summary>
        /// <param name="project"></param>

        public void AddProject(Project project){
            Projects.Add(project);
        }

        /// <summary>
        /// Method to add manager used in main program
        /// </summary>
        /// <param name="manager"></param>

        public void AddManager(ProjectManager manager){
            ProjectManagers.Add(manager);
        }

        /// <summary>
        /// Method to add member used in main program
        /// </summary>
        /// <param name="member"></param>

        public void AddMember(ProjectMember member){
            ProjectMembers.Add(member);
        }

        /// <summary>
        /// Method to deactivate member used in main program to remove Ash
        /// </summary>
        /// <param name="member"></param>

        public void  DeactivateMember(ProjectMember member){
            Console.WriteLine("Remove Ash?(1= yes)(2=no)");
            int remove = int.Parse(Console.ReadLine());
            if (remove == 1 ){
                ProjectMembers.Remove(member);
                Console.WriteLine("Removed success fully!");
            }
            else{
                Console.WriteLine("Ash remains");
            }
            
        }

        /// <summary>
        /// method to view details of each project manager and project member that is used in main program
        /// </summary>

        public void ViewUser(){
            foreach (ProjectManager m in projectManagers){
                Console.WriteLine("\n");
                Console.WriteLine("Manager Name: " + m.userName);
                Console.WriteLine("Manager Password: " + m.userPassword);
                Console.WriteLine("Manager ID: "+m.ManagerID);
                Console.WriteLine("\n");
                
            }

            foreach(ProjectMember mb in projectMembers){
                Console.WriteLine("\n");
                Console.WriteLine("Member Name: " + mb.userName);
                Console.WriteLine("Member Password: " + mb.userPassword);
                Console.WriteLine("Member ID: "+ mb.MemberID);
                Console.WriteLine("\n");
            }
        }

        /// <summary>
        /// Method to view each project's details 
        /// </summary>
        public void ViewProjectsListing(){
            foreach (Project project in projects){
                Console.WriteLine("\n");
                Console.WriteLine("Name: " + project.ProjectName);
                Console.WriteLine("Due Date" + project.projectDue);
                Console.WriteLine("\n");
            }
        }

        /// <summary>
        /// method to change an active project member account object to project manager object through attribute input
        /// </summary>
        /// <param name="projectMember"></param>

        public void AppointProjectManager(ProjectMember projectMember){
            Console.WriteLine("\n");
            Console.WriteLine("Account name: ");
            Console.WriteLine("\n");
            string accName = Console.ReadLine();

            Console.WriteLine("Account Password: ");
            Console.WriteLine("\n");
            string accPass = Console.ReadLine();

            Console.WriteLine("MemberID: ");
            Console.WriteLine("\n");
            string accID = Console.ReadLine();

           
            if (accName == projectMember.userName & accPass == projectMember.userPassword & accID == projectMember.MemberID){
                Console.WriteLine("\n");
                Console.WriteLine(projectMember.userName + " has become a project manager");
                Console.WriteLine("\n");
                 ProjectManager projectManager = new ProjectManager(accName,accPass,accID);
                ProjectManagers.Add(projectManager);
                ProjectMembers.Remove(projectMember);
            }
            
        


            else{
                Console.WriteLine("\n");
                Console.WriteLine("User/member does not exist, you may had keyed in manager details");
                Console.WriteLine("\n");
            }
        }

            
        }
}

