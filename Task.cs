using System;
using System.Collections.Generic;
using System.Formats.Tar;

namespace ManagementApp{
    public class Task{

        /// <summary>
        /// Task class private attributes: string _taskName, DateTime _taskDue,string _comment,bool _taskCompletion,List<ProjectMember> projectMembers
        /// </summary>
        private string _taskName;
        private DateTime _taskDue;
        
        private string _comments;

        private bool _taskCompletion;

        List<ProjectMember> projectMembers;


        /// <summary>
        ///  Task constructor with parameters:string taskName, DateTime taskDue,string Comments, bool taskCompletion
        ///  initialized  projectMembers = new List<ProjectMember>()/// 
        /// </summary>
        /// <param name="taskName"></param>
        /// <param name="taskDue"></param>
        /// <param name="Comments"></param>
        /// <param name="taskCompletion"></param>
        public Task(string taskName, DateTime taskDue,string Comments, bool taskCompletion){
            _taskName = taskName;
            _taskDue = taskDue;
            _comments = Comments;
            _taskCompletion = taskCompletion;
            projectMembers = new List<ProjectMember>();
        }

        /// <summary>
        /// Method to add member into task
        /// </summary>
        /// <param name="member"></param>

        public void AddMember(ProjectMember member){
             projectMembers.Add(member);
        }

        /// <summary>
        /// Method to remove member from task
        /// </summary>
        /// <param name="member"></param>
        public void RemoveMember (ProjectMember member){
            projectMembers.Remove(member);
        }
        /// <summary>
        /// method to count members in task
        /// </summary>
        /// <returns></returns>
        public int CountMembers(){
            return projectMembers.Count;
        }
        /// <summary>
        /// Method to set comment from project member as its own comment
        /// </summary>
        /// <returns></returns>

        public string comments(){
            foreach (ProjectMember pt in ProjectMembers){
                _comments = pt.Comment;
            }

            return _comments;
        }

        /// <summary>
        /// read and write property for:string TaskName,DateTime taskDue,string Comments,bool taskCompletion,List <ProjectMember> ProjectMembers
        /// </summary>
        /// <value></value>

        public string TaskName { 
            get { return _taskName;}
            set { _taskName = value; }
        }

        public DateTime taskDue{
            get { return _taskDue; }
            set { _taskDue = value; }
        }

        public string Comments{
            get { return _comments; }
            set { _comments = value; }
        }

        public bool taskCompletion{
            get{ return _taskCompletion; }
            set { _taskCompletion = value; }
        }

        public List <ProjectMember> ProjectMembers{
            get{ return projectMembers; }
        }
    }
}