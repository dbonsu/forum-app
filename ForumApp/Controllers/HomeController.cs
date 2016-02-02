using ForumApp.Models.IndexVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ForumApp.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// returns a forum with a list of topics
        /// </summary>
        /// <returns></returns>
        public ActionResult Forum()
        {
            var forum = GetForumIndexVM();
            return View(forum);
        }

        /// <summary>
        /// returns index page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Thread(long topicID, long threadID)
        {
            var thread = GetThreads().Where(t => t.ThreadID == threadID).FirstOrDefault();

            return View(thread);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="forumID">If more than 1 forum use this to get topics for a forum</param>
        /// <param name="topicID"></param>
        /// <returns></returns>
        public ActionResult Topic(long forumID, long topicID)
        {
            var topic = GetTopics().Where(x => x.TopicID == topicID).FirstOrDefault();
            return View(topic);
        }

        private ForumIndexVM GetForumIndexVM()
        {
            var topics = GetTopics().ToList();
            return new ForumIndexVM
            {
                ID = 1,
                Description = "Best Forum Ever",

                Title = "Cars A Forum",

                Topics = topics
            };
        }

        private IEnumerable<PostVM> GetPosts()
        {
            var up = new UserProfileVM { Location = "Jersey", NumOfPosts = 155, UserName = "derickCars", JoinDate = new DateTime(2016, 1, 2).ToString("MMMM yyyy") };
            var up2 = new UserProfileVM { Location = "BMore", NumOfPosts = 55, UserName = "porscheguy", JoinDate = new DateTime(2016, 1, 2).ToString("MMMM yyyy") };

            return new List<PostVM>
            {
                new PostVM {TopicID = 1 ,Body="hey there body", PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"),
                    PostID = 1, Subject = "new subject" ,User = up},
                 new PostVM {TopicID = 1 ,Body="hey there body", PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"),
                    PostID = 2, Subject = "new subject" ,User = up2},
                  new PostVM {TopicID = 1 ,Body="hey there body", PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"),
                    PostID = 3, Subject = "new subject" ,User =up2},
                   new PostVM {TopicID = 2 ,Body="hey there body", PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"),
                    PostID = 1, Subject = "new subject" ,User=up}
            };
        }

        private IEnumerable<ThreadVM> GetThreads()
        {
            var posts = GetPosts().ToList();
            var up = new UserProfileVM { Location = "Jersey", NumOfPosts = 155, UserName = "derickCars", JoinDate = new DateTime(2016, 1, 2).ToString("MMMM yyyy") };
            var up2 = new UserProfileVM { Location = "BMore", NumOfPosts = 55, UserName = "porscheguy", JoinDate = new DateTime(2016, 1, 2).ToString("MMMM yyyy") };
            return new List<ThreadVM>
            {
               new ThreadVM {ThreadID =1, Title = "First Thread" ,  NumOfPosts = 56, TopicID = 1 , LatestPost = posts.ElementAtOrDefault(0) , ThreadReplies = posts, User = up, PostDate =new DateTime(2016,1,2,8,25,00).ToString("MMMM dd, yyyy, hh:mm"), Body = "this is the body"},
               new ThreadVM {ThreadID =2,Title = "Second Thread" , NumOfPosts = 56, TopicID = 1 , LatestPost = posts.ElementAtOrDefault(1) , ThreadReplies = posts, User =up2, PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"), Body = "this is the body"},
               new ThreadVM {ThreadID =3, Title = "Thread Thread" ,NumOfPosts = 56, TopicID = 1 , LatestPost = posts.ElementAtOrDefault(2) , ThreadReplies = posts, User = up, PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"), Body = "this is the body"},
               new ThreadVM {ThreadID =4, Title = "Fourth Thread" ,NumOfPosts = 56, TopicID = 1 , LatestPost = posts.ElementAtOrDefault(3) , ThreadReplies = posts, User = up2, PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"), Body = "this is the body"},
               new ThreadVM {ThreadID =5, Title = "Fifth Thread" ,NumOfPosts = 56, TopicID = 1 , LatestPost = posts.ElementAtOrDefault(1) ,ThreadReplies = posts, User = up2, PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"), Body = "this is the body"},
               new ThreadVM {ThreadID =6, Title = "Sixth Thread" ,NumOfPosts = 56, TopicID = 1 , LatestPost = posts.ElementAtOrDefault(0), ThreadReplies = posts , User = up, PostDate =new DateTime(2016,1,2).ToString("MMMM dd, yyyy"), Body = "this is the body"},
            };
        }

        private IEnumerable<TopicVM> GetTopics()
        {
            var threads = GetThreads().ToList();
            var up = new UserProfileVM { Location = "Jersey", NumOfPosts = 155, UserName = "derickCars", JoinDate = new DateTime(2016, 1, 2).ToString("MMMM yyyy") };
            var up2 = new UserProfileVM { Location = "BMore", NumOfPosts = 55, UserName = "porscheguy", JoinDate = new DateTime(2016, 1, 2).ToString("MMMM yyyy") };
            return new List<TopicVM>
            {
                new TopicVM {ForumID =1, TopicID =1, Title="Model A" ,
                    LatestPost = new PostVM { PostDate = new DateTime(2015,12,31).ToString("MMMM dd, yyyy"), Subject="hey", User=up }, Threads = threads},
                new TopicVM {ForumID =1, TopicID =2,  Title="Model B" ,
                    LatestPost = new PostVM { PostDate = new DateTime(2015,12,31).ToString("MMMM dd, yyyy"), Subject="hey", User=up }, Threads = threads},
                new TopicVM {ForumID =1, TopicID =3,  Title="Model C" ,
                    LatestPost = new PostVM { PostDate = new DateTime(2015,12,31).ToString("MMMM dd, yyyy"), Subject="hey", User = up2 },Threads = threads},
                new TopicVM {ForumID =1, TopicID =4,  Title="Model D" ,
                    LatestPost = new PostVM { PostDate = new DateTime(2015,12,31).ToString("MMMM dd, yyyy"), Subject="hey", User=up},Threads = threads},
                new TopicVM {ForumID =1, TopicID =5, Title="Model E" ,
                    LatestPost = new PostVM { PostDate = new DateTime(2015,12,31).ToString("MMMM dd, yyyy"), Subject="hey", User=up2},Threads = threads},
                new TopicVM {ForumID =1, TopicID =6, Title="Model F" ,
                    LatestPost = new PostVM { PostDate = new DateTime(2015,12,31).ToString("MMMM dd, yyyy"), Subject="hey", User=up2}, Threads = threads},
            };
        }
    }
}