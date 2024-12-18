using System;
using System.Collections.Generic;

namespace ManagementApp{
    public class ProjectMember: User{
        /// <summary>
        /// Project member class that inherited from user
        /// private attributes: string comment,string _userName,string _MemberID,List <Task> _Tasks,List<ProjectMember> _members
        /// </summary>

        private string comment;
        private string _userName;

        private string _userPassword;

        private string _MemberID;

        private List <Task> _Tasks;

        private List<ProjectMember> _members;

        #nullable disable
       
        /// <summary>
        /// ProjectMember constructor with parameters: string userName, string userPassword,string MemberID
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPassword"></param>
        /// <param name="MemberID"></param>
        public ProjectMember(string userName, string userPassword,string MemberID){
            _userName = userName;
            _userPassword = userPassword;
            _MemberID = MemberID;
            _Tasks= new List<Task>();
            _members = new List<ProjectMember>();
        }

        /// <summary>
        /// read and write property for  List <Task> Tasks,string userName, List <ProjectMember> ProjectMembers,string userPassword
        /// ,string MemberID
        /// </summary>
        /// <value></value>

        public List <Task> Tasks{
            get{ return _Tasks; }
            set{value = _Tasks; }
        }

        public string userName {
            get {return _userName;}
            set { _userName = value;}
        }

        public List <ProjectMember> ProjectMembers {
            get {return _members;}
            set { _members= value;}
        }


        public string userPassword {
            get {return _userPassword;}
            set { _userPassword = value;}
        }

        public string MemberID{
            get {return _MemberID;}
            set { _MemberID = value;}
        }
        
        /// <summary>
        /// method to add comment from project member
        /// </summary>
        /// <param name="Mcomment"></param>
        /// <returns></returns>
         public string AddComment(string Mcomment){
            return Comment = Mcomment;
            
         }
         
        /// <summary>
        /// method to add task
        /// </summary>
        /// <param name="t"></param>
         public void AddTask(Task t){
            Tasks.Add(t);
            
         }
        
        /// <summary>
        /// method to view task assigned
        /// </summary>

        public void AccessViewtask (){
           foreach (Task t in Tasks){
            Console.WriteLine("Task Name: " + t.TaskName);
            Console.WriteLine("Task Due: "+ t.taskDue);
            Console.WriteLine("Task Completion status: "+ t.taskCompletion);

           }
        }

        
        /// <summary>
        /// method to mark completion of tasks
        /// </summary>
        /// <param name="t"></param>
        public void MarkCompletionStatus(Task t){
            Console.WriteLine("1 = completed, 2 = incomplete");
            int result = int.Parse(Console.ReadLine());
            if (result == 1){
                t.taskCompletion = true;
                Console.WriteLine("Task completed, completion status " + t.taskCompletion);
            }

            else if (result == 2){
                t.taskCompletion = false;
                Console.WriteLine("Task incomplete, completion status "+ t.taskCompletion);
            }
        } 



        /// <summary>
        /// override method to register as project member
        /// </summary>
        /// <returns></returns>

        public override string register(){

            
            Console.WriteLine("Name: ");
            userName = Console.ReadLine();

            Console.WriteLine("Password: ");
            userPassword = Console.ReadLine();

            Console.WriteLine("Member ID: ");
            MemberID = Console.ReadLine();


            ProjectMember pmem = new ProjectMember(userName, userPassword,MemberID);
            Console.WriteLine("Your name:" + userName);
            Console.WriteLine("Your Password:" + userPassword);
            Console.WriteLine("Your ID:" + MemberID);
            
            addMemberMan(pmem);
            
            return userName + userPassword + MemberID;
        }

        /// <summary>
        ///  override method to login as project member
        /// </summary>
        public override void login(){
            Console.WriteLine("Name: ");
            string MName = Console.ReadLine();

            Console.WriteLine("Password: ");
            string MPassword = Console.ReadLine();

            Console.WriteLine("Member ID: ");
            string MemID = Console.ReadLine();

            ProjectMember pmb = new ProjectMember(MName, MPassword, MemID);

            foreach (ProjectMember members in projectMember){
            if(members == pmb){
                Console.WriteLine("Login Successfull");
            }

            else if(MName == userName & MPassword == userPassword & MemID == MemberID){
               Console.WriteLine("Login Sucess");
            }

            else{
                Console.WriteLine("Retry, invalid object credentials");
                login();
            }
        }
        }

        /// <summary>
        /// Read and write property for Comment
        /// </summary>
        /// <value></value>

        public string Comment{
            get{return comment;}
            set{comment = value;}
        }



    }
}