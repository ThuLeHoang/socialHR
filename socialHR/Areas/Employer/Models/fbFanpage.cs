using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace socialHR.Areas.Employer.Models
{
    public class fbFanpage
    {
        public string avartar_url { get; set; }

        public string fanpage_url { get; set; }

        public string name { get; set; }

        public int num_like { get; set; }

        public int num_comment { get; set; }
    }
}