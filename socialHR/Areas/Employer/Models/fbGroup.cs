using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace socialHR.Areas.Employer.Models
{
    public class fbGroup
    {
        public string avartar_url { get; set; }

        public string group_url { get; set; }

        public string name { get; set; }

        public int num_like { get; set; }

        public int num_comment { get; set; }
    }
}