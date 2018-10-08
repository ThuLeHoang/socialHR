using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace socialHR.Areas.Employer.Models
{
    public class AuthorData
    {
        [Text(Name= "author_avatar_url")]
        public string avatar_url { get; set; }

        [Text(Name = "author_name")]
        public string Name { get; set; }

        [Text(Name = "author_url")]
        public object author_url { get; set; }

        [Text(Name = "birthYear")]
        public object birthYear { get; set; }

        [Text(Name = "birthYearPredict")]
        public object birthYearPredict { get; set; }

        [Text(Name = "education_name")]
        public string EducationName { get; set; }

        [Text(Name = "email")]
        public object email { get; set; }

        [Text(Name = "fb_data")]
        public object FbData { get; set; }

        [Text(Name = "follower_count")]
        public string FollowerCount { get; set; }

        [Text(Name = "friend_count")]
        public string FriendCount { get; set; }

        [Text(Name = "gender")]
        public string Gender { get; set; }

        [Text(Name = "id")]
        public string Id { get; set; }

        [Text(Name = "influence_score")]
        public object influence_score { get; set; }

        [Text(Name = "job_level_name")]
        public string JobLevelName { get; set; }

        [Text(Name = "location")]
        public string Location { get; set; }

        [Text(Name = "phone_mobile")]
        public object phone_number { get; set; }

        [Text(Name = "username")]
        public object username { get; set; }
    }

    //public class FacebookData
    //{
    //    public object 
    //}
}