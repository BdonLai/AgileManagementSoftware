using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace ManagementApp
{
    public class Program
    {
        public static void Main()
        {
            /// <summary>
            /// Initialized an admin object, 2 Project objects, 1 project manager object, 3 project member objects
            /// </summary>
            /// <returns></returns>
            Admin admin= new Admin("brandon", "abc32");
            Project p1 = new Project("P1", new DateTime(2024, 10,10,1,4,12));
            Project p2 = new Project("P2", new DateTime(2024,10,10,1,5,12));
            ProjectManager pm = new ProjectManager("Wilson", "100mn","99");
            ProjectMember mb = new ProjectMember("Benson", "ben100","10");
            ProjectMember mb2 = new ProjectMember("Ash", "ash100","88");
            ProjectMember mb3 = new ProjectMember("Delton", "delt55","90");
            
            #nullable disable
            ///Admin section Functions
            /// 
            
            Console.WriteLine("========Admin=======");

            /// <summary>
            /// Admin choice of login function
            /// </summary>
            /// <param name="(1"></param>
            /// <returns></returns>

            Console.WriteLine("Login? (1 = yes)(2= no)");
            int loginAdmin = int.Parse(Console.ReadLine());
            if (loginAdmin == 1){
                admin.AdminLogin();
            }

            else{
                Console.WriteLine("Fucntion Exited");
            }

            ///Added projects p1 and p2 to admin List of Project to be displayed

            admin.AddProject(p1);
            admin.AddProject(p2);

            /// <summary>
            /// Admin choice of Viewing project function
            /// </summary>
            /// <param name="(1=yes)(2"></param>
            /// <returns></returns>

            Console.WriteLine("View Projects? (1=yes)(2=no)");
            int ViewProjects = int.Parse(Console.ReadLine());

            if (ViewProjects == 1){
                admin.ViewProjectsListing();
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///
            /// Added Project manager and project member objects into admin list of project manager and project member for viewing

            admin.AddManager(pm);
            admin.AddMember(mb);    
            admin.AddMember(mb2);
            admin.AddMember(mb3);
        
          

            /// <summary>
            /// Objects added into list of admin user will be shown here
            /// Admin function to display all users
            /// </summary>
            /// <param name="(1"></param>
            /// <returns></returns>

            Console.WriteLine("View users? (1= yes)(2=no)");
            int ViewUser = int.Parse(Console.ReadLine());

            if (ViewUser == 1){
                admin.ViewUser();
            }
            else{
                Console.WriteLine("Function exited");
            }

            /// <summary>
            /// Admin function to deactivate/ remove a member account 
            /// </summary>
            /// <param name="account?(1=yes)(2"></param>
            /// <returns></returns>
            
            Console.WriteLine("Deactivate a member account?(1=yes)(2=no)");
            int removing = int.Parse(Console.ReadLine());

            if(removing == 1){
                admin.DeactivateMember(mb2);
            }
            else{
                Console.WriteLine("fucntion exited");
            }

            Console.WriteLine("\n");
            /// <summary>
            /// Admin function to appoint a project manager from project member
            /// </summary>
            /// <param name="manager?(1=yes)(2"></param>
            /// <returns></returns>

            Console.WriteLine("Appoint Benson who is an existing member as project manager?(1=yes)(2=no)(if yes key in his info)");

            int Appoint = int.Parse(Console.ReadLine());

            if (Appoint == 1){
                admin.AppointProjectManager(mb);
            }

            else{
                Console.WriteLine("function exited");
            }

             Console.WriteLine("\n");

             /// <summary>
             /// Admin function to view the updated project managers and project members after removing one member object and promoting 
             /// a member object to manager object
             /// </summary>
             /// <param name="(1"></param>
             /// <returns></returns>

            Console.WriteLine("View updated members and managers? (1= yes)(2=no)");
            int ViewManagerUser = int.Parse(Console.ReadLine());

            if (ViewManagerUser == 1){
                admin.ViewUser();
            }
            else{
                Console.WriteLine("Function exited");
            }
            

            Console.WriteLine("\n");

            ///Project manager functions section
            ///
            Console.WriteLine("========ProjectManager========");

            ///Project manager function to register as a user and displaying credentials
            ///
            Console.WriteLine("\n");
            Console.WriteLine("Register as a new manager?(1=yes)(2=no)");
            
            int register = int.Parse(Console.ReadLine());

            if (register == 1){
                pm.register();
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///Project manager function to login with credentials keyed in correctly by comparing objects' attributes
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("Login? (1=yes)(2=no)");
            int logging = int.Parse(Console.ReadLine());

            if (logging == 1){
                pm.login();
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///Project manager function to create a new project
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("Create new project? (1= yes)(2= no)");
            int Create =int.Parse(Console.ReadLine());

            if (Create == 1){
                pm.CreateProject();
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///Project manager function to add another project 
            ///
            Console.WriteLine("\n");
            Console.WriteLine("Add another project for viewing? (1=yes)(2=no)");
            int createAgain = int.Parse(Console.ReadLine());

            if (createAgain == 1){
                pm.CreateProject();
            }

            else{
                Console.WriteLine("Function exited");
            }

            /// <summary>
            /// Initialized and added an extra project called P9 
            /// </summary>
            /// <param name="DateTime(2025"></param>
            /// <returns></returns>

            Project P9 = new Project("P9", new DateTime(2025,6,1));
            pm.AddProject(P9);

             Project P4 = new Project("P4",new DateTime(2025,3,5,10,9,1));
            pm.AddProject(P4);

            ///Project manager function to View all projects details in list of projects
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("View all existing Projects?(1=yes)(2=no)");
            int view = int.Parse(Console.ReadLine());

            if(view == 1){
                pm.ViewProject();
            }
            else{
                Console.WriteLine("Fucntion exited");
            }

            ///Project manager function to Remove additional project
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("Remove Project P9? (1= yes)(2=no)");
            int remove = int.Parse(Console.ReadLine());

            if (remove == 1){
                pm.RemoveProjects(P9);
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///project manager function to View Projects details after the result of one additional project being removed
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("View updated existing project? (1=yes)(2= no)");
            int viewupdated = int.Parse(Console.ReadLine());

            if(viewupdated == 1){
                pm.ViewProject();
            }
            else{
                Console.WriteLine("Function exited");
            }

            /// <summary>
            /// Initialized a new project to be added by task, and team member
            /// </summary>
            /// <param name="DateTime(2025"></param>
            /// <returns></returns>

           
            ProjectMember member = new ProjectMember("Ben","ben400", "100");
            pm.AddMember(member);

            ///Project manager function to add a team member to a project
            ///
            Console.WriteLine("\n");
            Console.WriteLine("Add a team Member to a new project (P4)?(1=yes)(2=no)");
            int addtM = int.Parse(Console.ReadLine());

            if (addtM == 1){
                pm.AddTeamMembers(P4);
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///Project manager function to add task and task member to a project
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("Add task and task's team member to a project P4 that dues at 2025/3/5? (1= yes)(2=no)");
            int Addtask = int.Parse(Console.ReadLine());

            if(Addtask == 1){
                pm.AddTask(P4);
            }
            else{
                Console.WriteLine("Function exited");
            }

            Task T1 = new Task("T1",new DateTime(2023,3,4),"None",true);
            pm.ProjectTasks.Add(T1);

           

            ///Project manager function to view all tasks' details
            ///
            Console.WriteLine("\n");
            Console.WriteLine("View remaining Task?(1=yes)(2=no)");
            int viewRemaining = int.Parse(Console.ReadLine());

            if(viewRemaining == 1){
                pm.CompletionStatus(P4);
            }
            else{
                Console.WriteLine("Fucntion exited");
            }

            Console.WriteLine("\n");
            Console.WriteLine("View Tasks details?(1=yes)(2=no)");
            int viewRemainingtask = int.Parse(Console.ReadLine());

            if(viewRemainingtask == 1){
                pm.ViewTasks();
            }
            else{
                Console.WriteLine("Fucntion exited");
            }

            ///Project manager function to remove a task
            ///
            Console.WriteLine("\n");
            Console.WriteLine("Remove task t1? (1=yes),(2=no)");
            int removetask = int.Parse(Console.ReadLine());
            if(removetask ==1){
                pm.ProjectTasks.Remove(T1);
                Console.WriteLine("successfully removed");
            }
            else{
                Console.WriteLine("function exited");
            }

            
            
            ///Project manager function to view all tasks' details after removing
            ///
            Console.WriteLine("\n");
            Console.WriteLine("View Tasks details?(1=yes)(2=no)");
            int viewRemainingtaskss = int.Parse(Console.ReadLine());

            if(viewRemainingtaskss == 1){
                pm.ViewTasks();
            }
            else{
                Console.WriteLine("Fucntion exited");
            }

            


            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");



            ///Project member functions section
            /// 
            Console.WriteLine("========TeamMember===========");

            /// <summary>
            /// Project member function to register as a new member
            /// </summary>
            /// <param name="user?(1=yes)(2"></param>
            /// <returns></returns>

            Console.WriteLine("Register as a new user?(1=yes)(2=no)");
            int TeamMem = int.Parse(Console.ReadLine());

            if (TeamMem == 1){
                member.register();
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///Project member function to login
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("Login as a team member? (1=yes)(2=no)");
            int MemLogin= int.Parse(Console.ReadLine());
            
            if(MemLogin == 1){
                member.login();
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///Project members' function to view task assigned by project manager
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("View Task assigned for Ben just now?(1=yes)(2=no)");
            int memTask = int.Parse(Console.ReadLine());

            if (memTask == 1){
                member.AccessViewtask();
            }
            else{
                Console.WriteLine("function exited");
            }

            /// <summary>
            /// Initialized a task for project member to mark completion status
            /// </summary>
            /// <param name="DateTime(2024"></param>
            /// <returns></returns>

            Task t1 = new Task("T1",new DateTime(2024,12,3,3,5,8),"None", false);
            Console.WriteLine("\n");

            /// <summary>
            /// Project member function to mark task assigned as complete or incomplete
            /// </summary>
            /// <param name="(1=yes)(2"></param>
            /// <returns></returns>

            Console.WriteLine("Mark task assigned as complete/incomplete? (1=yes)(2=no)");
            int mark = int.Parse(Console.ReadLine());

            if (mark == 1){
                member.MarkCompletionStatus(t1);
            }
            else{
                Console.WriteLine("Function exited");
            }

            ///Project member function to add comments to assigned tasks
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("Add comments?(1=yes)(2=no)");
            int memCommt = int.Parse(Console.ReadLine());

            if (memCommt == 1){
                Console.WriteLine("Comment: ");
                string memComment = Console.ReadLine();
                member.AddComment(memComment);
            }
            else{
                Console.WriteLine("function exited");
            }

            ///Project manager function to view all comments from project member
            /// 
            Console.WriteLine("\n");
            Console.WriteLine("View all Comments from Project Manager?(1=yes)(2=no)");
            int viewCComment = int.Parse(Console.ReadLine());

            if (viewCComment == 1){
                pm.comments();
            }
            else{
                Console.WriteLine("fucntion exited");
            }









            



            











            

            

            

            // pm.AddProject(p1);

            // admin.ViewProjectsListing();

            // pm.register();

            // pm.login();





            
            




        }
    }
}
