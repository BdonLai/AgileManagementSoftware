using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework.Internal;

namespace ManagementApp{
    public class ProjectManager: User{
        /// <summary>
        /// Project Manager class inherited from parent class User
        /// private attributes of Project Manager: List<Project> _projects, List<ProjectMember> _projectmember, string _userName,
        /// string _userPassword, string _ManagerID
        /// </summary>

        private List <Project> _projects;


        private List <ProjectMember> _projectmember;

        private List <Task> _projectTasks;

        private string _userName;

        private string _userPassword;

        private string _ManagerID;
        
        #nullable disable

        
        /// <summary>
        /// ProjectManager constructor that takes parameters of userName, userPassword, ManagerID
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <param name="ManagerID"></param>
        public ProjectManager(string userName, string userPassword, string ManagerID){
            _ManagerID = ManagerID;
            _userName = userName;
            _userPassword = userPassword;
            _projectmember = new List <ProjectMember> ();
            _projectTasks= new List <Task> ();
            _projects = new List <Project> ();
        }
        /// <summary>
        /// read and write property for: string userName, string userPassword, string ManagerID, List <Task> ProjectTasks,
        /// List <ProjectMember> ProjectMembers, List<Project> Projects
        /// </summary>
        /// <value></value>
        public string userName{
            get{ return _userName; }
            set{ _userName = value; }
        }

        public string userPassword{
            get{ return _userPassword; }
            set{ _userPassword = value; }
        }

        public string ManagerID{
            get{ return _ManagerID; }
            set{ _ManagerID = value; }

        }

         public List <Task> ProjectTasks {
            get {return _projectTasks;}
            set { _projectTasks = value;}
        }

        public List <ProjectMember> ProjectMembers {
            get {return _projectmember;}
            set { _projectmember = value;}
        }

        public List<Project> Projects{
            get {return _projects;}
            set { _projects = value;}
        }

        /// <summary>
        /// Add Project method to project into list
        /// </summary>
        /// <param name="project"></param>

        public void AddProject (Project project){
            _projects.Add (project);
        }

        /// <summary>
        /// remove project method to remove project from list
        /// </summary>
        /// <param name="project"></param>

        public void RemoveProject(Project project){
            _projects.Remove (project);
        }
        /// <summary>
        /// Count project method to count projects in list of project
        /// </summary>
        /// <returns></returns>

        public int CountProject(){
            return _projects.Count;
        }

        /// <summary>
        /// Add member method that adds member to the list of project member
        /// </summary>
        /// <param name="member"></param>

        public void AddMember(ProjectMember member){
            ProjectMembers.Add(member);
        }

        /// <summary>
        /// Prints out the task details of completion
        /// </summary>
        /// <param name="p"></param>

        public void CompletionStatus(Project p){
            foreach (Task t in ProjectTasks){
                if (t.taskCompletion == true){
                    Console.WriteLine(t.TaskName + "Task is complete");
                }

                else if (t.taskCompletion == false){
                    Console.WriteLine(t.TaskName +  "Task is not complete");
                    TimeSpan Remaining = p.projectDue - t.taskDue;
                    Console.WriteLine("Remaining Days: "+Remaining.ToString());
                }

            }
        }

        /// <summary>
        /// Method that prints out all tasks' details
        /// </summary>

        public void ViewTasks(){
            foreach (Task t in ProjectTasks){
                Console.WriteLine("Task Name: " +t.TaskName);
                Console.WriteLine("Task Due: " +t.taskDue);
                Console.WriteLine("Task comment: " + t.Comments);
                Console.WriteLine("Task Status " +t.taskCompletion);
            }
        }

        /// <summary>
        /// Method to add project member
        /// </summary>
        /// <param name="p"></param>

        public void AddTeamMembers(Project p){

            Console.WriteLine ("Existing Project Member account Name(e.g. there is one existing member object called Ben): ");
            string member = Console.ReadLine();

            foreach (ProjectMember mem in ProjectMembers){
                if(mem.userName == member){
                    p.ProjectMemberss.Add(mem);
                    Console.WriteLine("Add successful");
                }

                else{
                    Console.WriteLine("name not exist");
                }
            }
        }

        /// <summary>
        /// method to add task and task member
        /// </summary>
        /// <param name="project"></param>

        public void AddTask( Project project){
            Console.WriteLine("Task Name :");
            string TTaskName = Console.ReadLine();

            Console.WriteLine("Due Date: (e.g. 2024,10,10)(Must be before project due date(2025,3,5)");
            DateTime TtaskDue = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Task Comments: ");
            string CComment = Console.ReadLine();

            Console.WriteLine("CompletionStatus: (1=true)(0=false)");
            int Completion = int.Parse(Console.ReadLine());

            if(Completion == 0){
                bool statuscompletion = false;
                Task tk = new Task(TTaskName,TtaskDue, CComment, statuscompletion);

                if (TtaskDue < project.projectDue ){
                    _projectTasks.Add(tk);
                    Console.WriteLine("Task added");
                }
                else if (TtaskDue > project.projectDue){
                    Console.WriteLine("task not added, due date of task is after project due");
                    
                }

                Console.WriteLine("Add an existing member account Name for Task Team member(e.g there is an existing member named: Ben): ");
                string UserN = Console.ReadLine();

                foreach (ProjectMember pm in ProjectMembers){
                if (pm.userName == UserN ){
                 pm.AddTask(tk);
                 Console.WriteLine("Task Member added " + pm.userName);
                }
            }

                
            }

            else if(Completion == 1){
                bool statuscompletion = true;

                Task tk = new Task(TTaskName,TtaskDue, CComment, statuscompletion);

                if (TtaskDue < project.projectDue ){
                    _projectTasks.Add(tk);
                    Console.WriteLine("Task added");
                }

                Console.WriteLine("Add Task Team member Name(e.g. Existing member Name: Ben): ");
                string UserN = Console.ReadLine();

                foreach (ProjectMember pm in ProjectMembers){
                if (pm.userName == UserN ){
                 pm.AddTask(tk);
                 Console.WriteLine("Task Member added " + pm.userName);
                 
                }
            }
           
               
            }
            else{
                Console.WriteLine("invalid, Task not created");
            }

        }

        /// <summary>
        /// Method to view all comments made by project member
        /// </summary>

        public void comments(){
            foreach (ProjectMember pt in ProjectMembers){
                Console.WriteLine("Comments: " + pt.Comment);
            }
        }

        /// <summary>
        /// method to create project
        /// </summary>
        public void CreateProject(){
            Console.WriteLine("Project Name: ");
            string pName = Console.ReadLine();

            Console.WriteLine("Project Due Date(e.g. 2025,10,10): ");
            DateTime due = DateTime.Parse(Console.ReadLine());

            Project p1 = new Project (pName,due);
            AddProject(p1);
        }

        /// <summary>
        /// Method to remove a project
        /// </summary>
        /// <param name="p"></param>
        public void RemoveProjects(Project p){
            
            
            Console.WriteLine("Due date detail of the selected Project(e.g 2025,6,1): ");
            DateTime prName = DateTime.Parse(Console.ReadLine());
                 if (p.projectDue == prName){
                    Projects.Remove(p);
                }
                }
        
        
        /// <summary>
        /// Method to view all projects' details
        /// </summary>

        public void ViewProject(){
            foreach(Project p in Projects){
                Console.WriteLine("Project Name: " +p.ProjectName);
                Console.WriteLine("Project Due Date: "+p.projectDue);
            }
        }

        /// <summary>
        /// Override method to register for project manager
        /// </summary>
        /// <returns></returns>
        public override string register()
        {
           
            Console.WriteLine("Name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Password: ");
            userPassword = Console.ReadLine();

            Console.WriteLine("Manager ID: ");
            ManagerID = Console.ReadLine();

            ProjectManager pm1 = new ProjectManager(userName, userPassword,ManagerID);
            Console.WriteLine("Your name:" + userName);
            Console.WriteLine("Your Password:" + userPassword);
            Console.WriteLine("Your ID:" + ManagerID);
            addProjectMan(pm1);
            return userName + userPassword + ManagerID;
        }

        /// <summary>
        /// override method to login for project manager
        /// </summary>

        public override void login(){
            Console.WriteLine("Name: ");
            string MName = Console.ReadLine();

            Console.WriteLine("Password: ");
            string MPassword = Console.ReadLine();

            Console.WriteLine("Manager ID: ");
            string manID = Console.ReadLine();

            ProjectManager pm = new ProjectManager(MName, MPassword,manID);

           
            foreach(ProjectManager man in projectManager){
            if(pm == man){
                Console.WriteLine("Login Successful");
            }
            else if (MName == userName & MPassword == userPassword & manID == ManagerID){
               Console.WriteLine("Login Success");
            }

            else{
                Console.WriteLine("Retry, invalid object credentials");
                login();
            }
        }

    }
}

}