using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace socialHR.Areas.Employer.Models
{
    public class fbPost
    {
        public string author_name { get; set; }

        public object content { get; set; }
        
        public int influence_score { get; set; }
        
        public int num_like { get; set; }

        public int num_comment { get; set; }

        public DateTime time_post { get; set; }

        public string url { get; set; }
    }
}