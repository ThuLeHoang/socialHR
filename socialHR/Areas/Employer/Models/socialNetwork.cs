using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace socialHR.Areas.Employer.Models
{
    public class socialNetwork
    {
        public List<AuthorData> most_interactive_friend { get; set; }

        public List<AuthorData> high_influencer_score_friend { get; set; }
        
        public List<fbPost> fb_post { get; set; }

        public List<fbComment> fb_comment { get; set; }

        public List<fbFanpage> fb_fanpage { get; set; }

        public List<fbGroup> fb_group { get; set; }
   

    }
}