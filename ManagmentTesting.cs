using System;
using NUnit.Framework;
using SplashKitSDK;
using System.Collections.Generic;


namespace ManagementApp{
    [TestFixture()]
    public class ManagementTesting{

        /// <summary>
        /// Method to test Addition of Project and project total 
        /// </summary>
        [Test()]
        public void TestAdd(){
            Admin admin= new Admin("brandon", "abc32");
             Project p1 = new Project("P1", new DateTime(2024, 10,10,1,4,12));
            Project p2 = new Project("P2", new DateTime(2024,10,10,1,5,12));
            ProjectManager pm = new ProjectManager("Ben", "123mo", "55");
            pm.AddProject(p1);
            pm.AddProject(p2);
            Assert.AreEqual(pm.CountProject(), 2);
        }

        /// <summary>
        /// Method to test removal of project and project total
        /// </summary>

        [Test()]
        public void TestRemove(){
            Admin admin= new Admin("brandon", "abc32");
             Project p1 = new Project("P1", new DateTime(2024, 10,10,1,4,12));
            Project p2 = new Project("P2", new DateTime(2024,10,10,1,5,12));
            ProjectManager pm = new ProjectManager("Ben", "123oj","55");
            pm.AddProject(p1);
            pm.AddProject(p2);
            pm.RemoveProject(p1);
            Assert.AreEqual(pm.CountProject(), 1);
        }

        /// <summary>
        /// Method to test comment parameter and returning value which is important for project manager to view comment
        /// </summary>

        [Test()]
        public void TestCommentCorrect(){
            ProjectMember pmb = new ProjectMember("Dan", "245lo","34");
            Assert.AreEqual(pmb.AddComment("Task in Production"), "Task in Production");
        }

        /// <summary>
        /// Method to test task storing member comments to be displayed at project manager view
        /// </summary>
        [Test()]

        public void ViewComment(){
            Task task = new Task("Agile Software", new DateTime(2024, 10,10,1,4,12),"Non", false);
            ProjectMember pmb = new ProjectMember("Dan", "245bc", "123");
            task.AddMember(pmb);
            pmb.AddComment("Task in production");
            Assert.AreEqual("Task in production", task.comments());
            

        }


        
    }
}